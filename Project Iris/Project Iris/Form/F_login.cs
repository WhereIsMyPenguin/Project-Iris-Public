using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Project_Iris
{
    public partial class F_Login : Form
    {
        //パスワードハッシュ用クラスのインスタンス化
        PasswordHash passwordHash = new PasswordHash();
        public F_Login()
        {
            InitializeComponent();
        }
        
        int pressCnt = 0;
        private void F_Login_Load(object sender, EventArgs e)
        {
            using (var context = new SalesManagement_DevContext())
            {
                bool Exist = context.Database.Exists();
                if (Exist)
                    linkOpenRegister.Visible = false;
                else
                { defaultLogin.Enabled = false; }
            }
            this.Opacity = 1;
            textBox1.PasswordChar = '●';
            this.AcceptButton = defaultLogin;
            this.CancelButton = defaultExt;
            //Regex.IsMatch(str,"[^a-zA-Z0-9]+"$)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("フォームを閉じますか？", "確認",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if(D_LoginData.EmName != null)
                    Logger.WriteLogLeave(DateTime.Now, D_LoginData.EmID + " " + D_LoginData.EmName, "終了");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int loginSID = int.Parse(textBox2.Text.Trim());
                string loginPwd = textBox1.Text;
                bool flg;
                //ユーザID・PWの入力状況チェック
                if (loginPwd.Trim() == "" || loginPwd == null)
                {
                    //ID・PW未入力メッセージ
                    MessageBox.Show("社員idかパスワードが入力されてません", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //ユーザID・PWチェック
                var context = new SalesManagement_DevContext();
                var pw = passwordHash.CreatePasswordHash(textBox1.Text.Trim());
                //ユーザID・PWが存在するか
                flg = context.M_Employees.Any(x => x.EmID == loginSID && x.EmPassword == pw);
                if (flg == true)
                {
                    var PoID = context.M_Employees.Single(X => X.EmID == loginSID).PoID;
                    var SoID = context.M_Employees.Single(x => x.EmID == loginSID).SoID;
                    D_LoginData.EmID = loginSID;
                    D_LoginData.EmName = context.M_Employees.Single(x => x.EmID == loginSID).EmName;
                    D_LoginData.PoName = context.M_Positions.Single(x => x.PoID == PoID).PoName;
                    D_LoginData.PoID = PoID;
                    D_LoginData.SoName = context.M_SalesOffices.Single(x => x.SoID == SoID).SoName;
                    D_LoginData.SoID = SoID;
                    D_LoginData.LogDate = DateTime.Now.Date;
                    var form = new F_MainMenu();
                    string Name = D_LoginData.EmID + " " + D_LoginData.EmName;
                    Logger.WriteLogEnter(DateTime.Now, Name, "メインメニュー", "社員");
                    this.Hide();
                    if (form.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    else
                        this.Show();
                }
                else
                {
                    MessageBox.Show("社員ID、又はパスワードが間違っています。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (pressCnt == 0)
            {
                textBox1.PasswordChar = '\0';
                pressCnt = 1;
            }
            else if (pressCnt == 1)
            {
                textBox1.PasswordChar = '●';
                pressCnt = 0;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(var context = new SalesManagement_DevContext())
            {
                if(context.M_Employees.Where(x => x.EmFlag == 0).Count() > 0)
                { MessageBox.Show("すでに社員が登録されています。", ".", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }    
            };
            var form = new F_Register();
            this.Opacity = 0;
            if (form.ShowDialog() == DialogResult.Cancel)
                this.Opacity = 1;
        }
    }
}
