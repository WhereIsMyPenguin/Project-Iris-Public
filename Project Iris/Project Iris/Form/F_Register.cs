using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    public partial class F_Register : Form
    {
        public string Pass { get; set; }
        public string Stats;
        public int ID;
        //パスワードハッシュ用クラスのインスタンス化
        PasswordHash passwordHash = new PasswordHash();
        public F_Register()
        {
            InitializeComponent();
        }

        private void F_Register_Load(object sender, EventArgs e)
        {
            this.Opacity = 1;
            textBox2.Text = "";
            textBox1.Text = "";
            textBox2.PasswordChar = '*';
            textBox1.PasswordChar = '*';
            textBox2.Enabled = false;
            button1.Enabled = false;
            if (Application.OpenForms.OfType<F_EmployeeManagement>().Count() > 0)
            { button1.Text = "確定";
                label3.Text = Stats;
                label3.Font = new Font("UD Digi Kyokasho NK-B", 25);
                if(Stats != "新社員のパスワード")
                {
                    label4.Visible = false;label5.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pw1 = "";
            string pass_add = textBox1.Text.Trim();
            string pass_add_s = textBox2.Text.Trim();
            if(Application.OpenForms.OfType<F_EmployeeManagement>().Count() > 0)
            {
                var pw = passwordHash.CreatePasswordHash(textBox2.Text.Trim());
                {
                    using (var context = new SalesManagement_DevContext())
                    {
                        if (Stats == "ログインユーザーのパスワード")
                            pw1 = context.M_Employees.Single(x => x.EmID == D_LoginData.EmID).EmPassword;
                        else if (Stats == "本人確認")
                            pw1 = context.M_Employees.Single(x => x.EmID == ID).EmPassword;
                        else if(Stats == "新社員のパスワード")
                        {
                            Pass = pw;
                            DialogResult = DialogResult.OK;
                            this.Close();
                            return;
                        }
                        if (pw1 == pw)
                        {
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("パスワードが間違っています", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                if (pass_add != "" && pass_add_s != "" && pass_add == pass_add_s)
                {
                    DialogResult result = MessageBox.Show("登録しますか？", "確認",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var pw = passwordHash.CreatePasswordHash(textBox1.Text.Trim());
                        var Pos = 1; var Sal = 1;
                        SalesManagement_DevContext context = new SalesManagement_DevContext();
                        if (context.M_Positions.Count() == 0)
                        {
                            M_Position position = new M_Position()
                            {
                                PoName = "仮役職",
                                Positions = "RW,RW,R,RW,RW,RW,RW,RW,RW,RW,R,RW,RW",
                                PoFlag = 0
                            };
                            context.M_Positions.Add(position);
                            context.SaveChanges();
                        }
                        Pos = context.M_Positions.First().PoID;
                        if (context.M_SalesOffices.Where(x => x.SoFlag == 0).Count() == 0)
                        {
                            M_SalesOffice salesOffice = new M_SalesOffice()
                            {
                                SoName = "仮営業所",
                                SoPhone = "000-0000-0000",
                                SoAddress = "なし",
                                SoPostal = "0000000",
                                SoFAX = "000-0000-0000",
                                SoFlag = 0
                            };
                            context.M_SalesOffices.Add(salesOffice);
                            context.SaveChanges();
                        }
                        Sal = context.M_SalesOffices.First().SoID;
                        M_Employee employee = new M_Employee()
                        {
                            EmName = "テスター",
                            PoID = Pos,
                            SoID = Sal,
                            EmHiredate = DateTime.Now.Date,
                            EmPassword = pw,
                            EmPhone = "000-0000-0000"
                        };
                        context.M_Employees.Add(employee);
                        context.SaveChanges();
                        if(context.M_MajorClassifications.Where(x =>x.McFlag == 0).Count() == 0)
                        {
                            M_MajorClassification major = new M_MajorClassification()
                            {
                                McName = "仮大分類",
                                McFlag = 0
                            };
                            context.M_MajorClassifications.Add(major);
                            context.SaveChanges();
                            M_SmallClassification small = new M_SmallClassification()
                            {
                                ScName = "仮小分類",
                                McID = major.McID,
                                ScFlag = 0
                            };
                            context.M_SmallClassifications.Add(small);
                            context.SaveChanges();
                        }
                        if(context.M_Makers.Where(x => x.MaFlag == 0).Count() == 0)
                        {
                            M_Maker maker = new M_Maker()
                            {
                                MaName = "仮メーカ",
                                MaAdress = "なし",
                                MaPhone = "000-0000-0000",
                                MaFAX = "000-0000-0000",
                                MaPostal = "0000000",
                                MaFlag = 0
                            };
                            context.M_Makers.Add(maker);
                            context.SaveChanges();
                        }
                        MessageBox.Show("社員ID :" + employee.EmID + "\n として追加しました。\n ログイン画面に戻ります。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        context.Dispose();
                    }
                    else
                        return;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("パスワード一致しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pass_add = textBox1.Text.Trim();
            if (pass_add.Length >= 4)
            {
                textBox2.Enabled = true;
                label4.Text = "✔";
                label4.ForeColor = Color.LimeGreen;
            }
            else
            {
                textBox2.Text = "";
                textBox2.Enabled = false;
                label4.Text = "✘";
                label4.ForeColor = Color.Crimson;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("キャンセルしますか？", "確認",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
                return;
        
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4)
                toolTipFirst.SetToolTip(label4, "4文字以上です。");
            else
                toolTipFirst.SetToolTip(label4, "OKです。");

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox1.Text && !string.IsNullOrEmpty(textBox2.Text))
                toolTipSecond.SetToolTip(label5, "パスワードが一致しました。");
            else
                toolTipSecond.SetToolTip(label5, "パスワードが一致しません。");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == textBox1.Text)
            {
                button1.Enabled = true;
                label5.Text = "✔";
                label5.ForeColor = Color.LimeGreen;
            }
            else
            {
                button1.Enabled = false;
                label5.Text = "✘";
                label5.ForeColor = Color.Crimson;
            }
        }
    }
}

