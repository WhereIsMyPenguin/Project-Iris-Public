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
    public partial class F_MainMenu : Form
    {
        public F_MainMenu()
        {
            InitializeComponent();
            this.Size = new Size(330, 684); 
        }

        private void F_MainMenu_Load(object sender, EventArgs e)
        {
            roundPanel1.BackColor = Color.MediumSlateBlue;
            SalesManagement_DevContext context = new SalesManagement_DevContext();
            label1.Text = context.M_Employees.Single(x => x.EmID == D_LoginData.EmID).EmName;
            label2.Text = D_LoginData.PoName;
            label3.Text = D_LoginData.SoName;
            label4.Text = D_LoginData.LogDate.ToString("yyyy年MM月dd日") + "にログイン";
            context.Dispose();
            SetPosition();
        }
        private void SetPosition()
        {
            using(var context = new SalesManagement_DevContext())
            {
                int GetPos = context.M_Employees.Single(x => x.EmID == D_LoginData.EmID).PoID;
                string[] Pos = context.M_Positions.Single(x => x.PoID == GetPos).Positions.Split(',');
                if (Pos[0] == "N")
                    buttonEmManage.Enabled = false;
                if (Pos[1] == "N")
                    buttonClient.Enabled = false;
                if (Pos[2] == "N")
                    buttonSales.Enabled = false;
                if (Pos[3] == "N")
                    buttonSaleOffice.Enabled = false;
                if (Pos[4] == "N")
                    buttonSh.Enabled = false;
                if (Pos[5] == "N")
                    buttonOrder.Enabled = false;
                if (Pos[6] == "N")
                    buttonAr.Enabled = false;
                if (Pos[7] == "N")
                    buttonProduct.Enabled = false; 
                if (Pos[8] == "N")
                    buttonHW.Enabled = false;
                if (Pos[9] == "N")
                    buttonCh.Enabled = false;
                if (Pos[10] == "N")
                    buttonSt.Enabled = false;
                if (Pos[11] == "N")
                    buttonMaker.Enabled = false;
                if (Pos[12] == "N")
                    buttonSy.Enabled = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("終了します。\nよろしいですか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                DialogResult = DialogResult.Cancel;
                Logger.WriteLogLeave(DateTime.Now, D_LoginData.EmID + " " + D_LoginData.EmName, "終了");
                this.Close();
            }
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ログアウトします。\nよろしいですか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                DialogResult = DialogResult.OK;
                Logger.WriteLogLeave(DateTime.Now, D_LoginData.EmID + " " + D_LoginData.EmName, "ログアウト");
                this.Close();
            }
        }
        private void buttonHQ_Click(object sender, EventArgs e)
        {
            this.Size = new Size(666, 684);
            panelSO.Visible = false;
            panelSU.Visible = false;
            panelHQ.Visible = true;
        }

        private void buttonSO_Click(object sender, EventArgs e)
        {
            this.Size = new Size(666, 684);
            panelHQ.Visible = false;
            panelSU.Visible = false;
            panelSO.Visible = true;
        }

        private void buttonSupply_Click(object sender, EventArgs e)
        {
            this.Size = new Size(666, 684);
            panelHQ.Visible = false;
            panelSO.Visible = false;
            panelSU.Visible = true;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            OpenSesame("受注管理",5);
        }
        //OpenSesame()
        //指定したフォームを開く
        private void OpenSesame(string key,int Op)
        {
            var form = new Form();
            switch(key)
            {
                case "受注管理": form = new F_Order(); //受注
                    break;
                case "社員管理": form = new F_EmployeeManagement();   //社員管理
                    break;
                case "営業所": form = new F_SalesOffice();
                    break;
                case "注文管理": form = new F_Chumon();
                    break;
                case "商品管理": form = new F_ProductManagement();
                    break;
                case "メーカ管理": form = new F_Maker();
                    break;
                case "顧客管理": form = new F_Client();
                    break;
                case "出庫管理": form = new F_Syukko();
                    break;
                case "売上管理": form = new F_Sales();
                    break;
                case "入荷管理": form = new F_Arrival();
                    break;
                case "在庫管理": form = new F_Stock();
                    break;
                case "出荷管理": form = new F_Shipment();
                    break;
                case "発注管理": form = new F_Hattyu();
                    break;
            }
            string Position = "";
            using (var context = new SalesManagement_DevContext())
            {
                int GetPos = context.M_Employees.Single(x => x.EmID == D_LoginData.EmID).PoID;
                string[] Pos = context.M_Positions.Single(x => x.PoID == GetPos).Positions.Split(',');
                if (Pos[Op] == "R")
                    Position = "参照";
                else if (Pos[Op] == "RW")
                    Position = "登録・更新・参照";
                else
                    Position = "ありません";
            }
            Logger.WriteLogEnter(DateTime.Now, D_LoginData.EmID + " " + D_LoginData.EmName, key, Position);
            this.Hide();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                Logger.WriteLogLeave(DateTime.Now, D_LoginData.EmID + " " + D_LoginData.EmName, key + "を破棄");
                this.Show(); }
        }

        private void buttonSaleOffice_Click(object sender, EventArgs e)
        {
            OpenSesame("営業所管理",3);
        }

        private void buttonEmManage_Click(object sender, EventArgs e)
        {
            OpenSesame("社員管理",0);
        }

        private void buttonCh_Click(object sender, EventArgs e)
        {
            OpenSesame("注文管理",9);
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            OpenSesame("商品管理",7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenSesame("顧客管理",1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenSesame("出庫管理",12);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenSesame("発注管理",8);
        }

        private void buttonMaker_Click(object sender, EventArgs e)
        {
            OpenSesame("メーカ管理",11);
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            OpenSesame("売上管理",2);
        }

        private void buttonArrival_Click(object sender, EventArgs e)
        {
            OpenSesame("入荷管理",6);
        }

        private void buttonSt_Click(object sender, EventArgs e)
        {
            OpenSesame("在庫管理",10);
        }

        private void buttonSh_Click(object sender, EventArgs e)
        {
            OpenSesame("出荷管理",4);
        }
    }
}
