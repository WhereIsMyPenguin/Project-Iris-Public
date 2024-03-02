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
    public partial class F_SalesOffice : Form
    {
        //          営業所
        SalesOfficeAccess salesOfficeAccess = new SalesOfficeAccess();
        //
        private static List<M_SalesOfficeDsp> SalesOfficeDsp;
        //
        private static List<M_SalesOfficeDspHidden> SalesOfficeDspHidden;
        //
        public F_SalesOffice()
        {
            InitializeComponent();
        }
        bool IsEdit = false;
        int ObtainedID = 0;
        private void F_SalesOffice_Load(object sender, EventArgs e)
        {
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            panelGeneralOp.Visible = false;
            groupBoxHider.Visible = false;
            comboSearchCa.SelectedIndex = 0;
            panelHideConfirm.BackColor = Color.White;
            panelHide.BackColor = Color.RoyalBlue;
            textBoxPhone.ImeMode = ImeMode.Disable;
            labelHiddenReason.Visible = false;
            Clock.Start();
            LoadUser();
            LoadMainGrid();
            SetPosition();
        }
        // メソッド名:LoadUser()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:ログインユーザーの情報を表示
        private void LoadUser()
        {
            using (SalesManagement_DevContext context = new SalesManagement_DevContext())
            {
                LogUser.Text = context.M_Employees.Single(x => x.EmID == D_LoginData.EmID).EmName;
                LogPo.Text = D_LoginData.PoName;
                LogSo.Text = D_LoginData.SoName;
                LogDate.Text = D_LoginData.LogDate.ToString("yyyy年MM月dd日");
            };
        }
        private void SetPosition()
        {
            using (var context = new SalesManagement_DevContext())
            {
                int GetPos = context.M_Employees.Single(x => x.EmID == D_LoginData.EmID).PoID;
                string[] Pos = context.M_Positions.Single(x => x.PoID == GetPos).Positions.Split(',');
                if (Pos[3] == "R")
                { buttonAdd.Enabled = false; buttonEdit.Enabled = false; }
                else if (Pos[3] == "RW") { }
                else this.Close();
            }
        }
        private void LoadMainGrid()
        {
            dataGridMain.ReadOnly = true;
            //行ごと選択
            dataGridMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データ取得
            LoadMainData();
        }
        private void LoadMainData()
        {
            SalesOfficeDsp = salesOfficeAccess.GetSalesOfficeDisplay();

            SetMainView();
        }
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = SalesOfficeDsp.ToList();

            dataGridMain.Columns[0].Width = 80;
            dataGridMain.Columns[1].Width = 100;
            dataGridMain.Columns[2].Width = 100;
            dataGridMain.Columns[3].Width = 180;
            dataGridMain.Columns[4].Width = 250;
            dataGridMain.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
        }

        private void SetHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = SalesOfficeDspHidden.ToList();

            dataGridMain.Columns[0].Width = 80;
            dataGridMain.Columns[1].Width = 100;
            dataGridMain.Columns[2].Width = 100;
            dataGridMain.Columns[3].Width = 180;
            dataGridMain.Columns[4].Width = 120;
            dataGridMain.Columns[5].Width = 250;
            dataGridMain.Columns[6].Visible = false;
            dataGridMain.Columns[7].Visible = false;
            dataGridMain.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            panelGeneralOp.Visible = true;
            panelDisplay.Visible = false;
            panelGeneralOp.BackColor = Color.SpringGreen;
            DecisionPanel.BackColor = Color.SpringGreen;
            IsEdit = false;
            buttonOK.Enabled = false;
            buttonHide.Visible = false;
            buttonUnHide.Visible = false;
            panel1.Enabled = false;
        }

        private void buttonBacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ClearAll();
            panelGeneralOp.Visible = true;
            panelDisplay.Visible = false;
            int i = dataGridMain.CurrentRow.Index;
            textBoxSo.Text = dataGridMain.Rows[i].Cells[1].Value.ToString();
            textBoxAd.Text = dataGridMain.Rows[i].Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridMain.Rows[i].Cells[3].Value.ToString();
            textBoxPostal.Text = dataGridMain.Rows[i].Cells[4].Value.ToString();
            textBoxFAX.Text = dataGridMain.Rows[i].Cells[5].Value.ToString();
            panelGeneralOp.BackColor = Color.RoyalBlue;
            DecisionPanel.BackColor = Color.RoyalBlue;
            IsEdit = true;
            buttonOK.Enabled = true;
            panel1.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelThing();
        }
        private void CancelThing()
        {
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            richTextHideReason.Enabled = true;
            panelHide.Enabled = true;
            groupBoxHider.Visible = false;
            panelGeneralOp.Visible = false;
            ClearAll();
            panelDisplay.Visible = true;
            GenerateFilter();
            panel1.Enabled = true;
        }
        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMain.Rows.Count > 0)
            {
                int i = dataGridMain.CurrentRow.Index;
                labelSoName.Text = dataGridMain.Rows[i].Cells[1].Value.ToString();
                labelSoID.Text = dataGridMain.Rows[i].Cells[0].Value.ToString();
                labelAddress.Text = dataGridMain.Rows[i].Cells[2].Value.ToString();
                labelPhone.Text = dataGridMain.Rows[i].Cells[3].Value.ToString();
                labelPostal.Text = dataGridMain.Rows[i].Cells[4].Value.ToString();
                labelFAX.Text = dataGridMain.Rows[i].Cells[5].Value.ToString();
                ObtainedID = int.Parse(dataGridMain.Rows[i].Cells[0].Value.ToString());
                labelHiddenReason.Visible = false;
                buttonHide.Visible = true;
                buttonUnHide.Visible = false;
                if(checkHiddenToggle.Checked)
                {
                    buttonHide.Visible = false;
                    buttonUnHide.Visible = true;
                    labelHiddenReason.Visible = true;
                    labelHiddenReason.Text = "非表示理由：" + dataGridMain.Rows[i].Cells[8].Value.ToString();
                }
                SetPosition();
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            M_SalesOffice office = new M_SalesOffice()
            {
                SoName = textBoxSo.Text,
                SoAddress = textBoxAd.Text,
                SoPhone = textBoxPhone.Text,
                SoPostal = textBoxPostal.Text,
                SoFAX = textBoxFAX.Text
            };
            if (!IsEdit)
            {
                var context = new SalesManagement_DevContext();
                if (context.M_SalesOffices.Any(x => x.SoName == office.SoName))
                {
                    DialogResult result = MessageBox.Show("営業所名 " + office.SoName + " はすでに存在しています。\n" + "それでも追加しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                }
                if (context.M_SalesOffices.Any(x => x.SoAddress == office.SoAddress))
                {
                    DialogResult result = MessageBox.Show("住所 " + office.SoAddress + " はすでに存在しています。\n" + "それでも追加しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                }
                salesOfficeAccess.AddNew(office);
                context.Dispose();
            }
            else
                salesOfficeAccess.Modify(office, ID);
            CancelThing();
        }
        private void checking()
        {
            if (!string.IsNullOrEmpty(textBoxSo.Text) && !string.IsNullOrEmpty(textBoxAd.Text) &&textBoxFAX.Text.Trim().Length == 13 
                && !string.IsNullOrEmpty(textBoxPostal.Text) && textBoxPhone.Text.Trim().Length == 13)
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }
        private void ClearAll()
        {
            foreach (Control p in panelGeneralOp.Controls)
            {
                if (p is TextBox)
                    (p as TextBox).Clear();
            }
        }

        private void textBoxSo_TextChanged(object sender, EventArgs e)
        {
            checking();
        }

        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {
            checking();
        }

        private void textBoxPostal_TextChanged(object sender, EventArgs e)
        {
            checking();
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            checking();
        }

        private void textBoxFAX_TextChanged(object sender, EventArgs e)
        {
            checking();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            bool set = (groupBoxHider.Visible == true) ? groupBoxHider.Visible = false : groupBoxHider.Visible = true;
        }

        private void buttonHidCo_Click(object sender, EventArgs e)
        {
            label21.Visible = true;
            panelHide.Enabled = false;
            panelHideConfirm.Visible = true;
            richTextHideReason.Enabled = false;
        }

        private void buttonHidCa_Click(object sender, EventArgs e)
        {
            groupBoxHider.Visible = false;
            richTextHideReason.Text = "";
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            M_SalesOffice send = new M_SalesOffice()
            {
                SoID = ObtainedID,
                SoHidden = richTextHideReason.Text,
                SoFlag = 1                
            };
            salesOfficeAccess.BravoSixGoingDark(send);
            CancelThing();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            richTextHideReason.Enabled = true;
            panelHide.Enabled = true;
        }

        private void buttonUnHide_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("表示化させますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            salesOfficeAccess.SnapBackToReality(ObtainedID);
            CancelThing();
        }
        private void GenerateFilter()
        {
            int type = comboSearchCa.SelectedIndex;
            var search = textBoxSearch.Text;
            if (!checkHiddenToggle.Checked)
            { SalesOfficeDsp = salesOfficeAccess.DefaultSearch(type, search); SetMainView(); }
            else
            { SalesOfficeDspHidden = salesOfficeAccess.HiddenSearch(type, search); SetHiddenView(); } 
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GenerateFilter();
        }

        private void comboSearchCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateFilter();
        }

        private void checkHiddenToggle_CheckedChanged(object sender, EventArgs e)
        {
            GenerateFilter();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
