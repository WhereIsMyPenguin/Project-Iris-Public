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
    public partial class F_Client : Form
    {
        //          営業所
        ClientAccess clientAccess = new ClientAccess();
        //
        private static List<M_ClientDsp> ClientDsp;
        //
        private static List<M_ClientDspHidden> ClientDspHidden;
        //
        public F_Client()
        {
            InitializeComponent();
        }
        bool IsEdit = false;
        int ObtainedID = 0;

        private void F_Client_Load(object sender, EventArgs e)
        {
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            panelGeneralOp.Visible = false;
            groupBoxHider.Visible = false;
            comboSearchCa.SelectedIndex = 0;
            panelHideConfirm.BackColor = Color.White;
            panelHide.BackColor = Color.RoyalBlue;
            labelHiddenReason.Visible = false;
            buttonEdit.Enabled = false;
            Clock.Start();
            LoadUser();
            LoadMainGrid();
            LoadCombo();
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
                if (Pos[1] == "R")
                { buttonAdd.Enabled = false; buttonEdit.Enabled = false; }
                else if (Pos[1] == "RW") { }
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
            ClientDsp = clientAccess.GetClientDisplay();

            SetMainView();
        }
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = ClientDsp.ToList();

            dataGridMain.Columns[0].Width = 80;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 100;
            dataGridMain.Columns[3].Width = 100;
            dataGridMain.Columns[4].Width = 180;
            dataGridMain.Columns[5].Width = 250;
            dataGridMain.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
        }

        private void SetHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = ClientDspHidden.ToList();

            dataGridMain.Columns[0].Width = 80;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 100;
            dataGridMain.Columns[3].Width = 100;
            dataGridMain.Columns[4].Width = 180;
            dataGridMain.Columns[5].Width = 120;
            dataGridMain.Columns[6].Width = 250;
            dataGridMain.Columns[7].Visible = false;
            dataGridMain.Columns[8].Visible = false;
            dataGridMain.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
        private void LoadCombo()
        {
            List<M_SalesOfficeCombo> combo = new List<M_SalesOfficeCombo>();
            SalesOfficeAccess salesOfficeAccess = new SalesOfficeAccess();
            combo = salesOfficeAccess.GetSalesOfficeCombos();
            comboSo.ValueMember = "Value";
            comboSo.DisplayMember = "Display";
            comboSo.DataSource = combo;
            if(comboSo.Items.Count > 10)
            {
                comboSo.DropDownStyle = ComboBoxStyle.DropDown;
                comboSo.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboSo.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ClearAll();
            panelGeneralOp.Visible = true;
            panelDisplay.Visible = false;
            int i = dataGridMain.CurrentRow.Index;
            comboSo.SelectedValue = dataGridMain.Rows[i].Cells[1].Value.ToString();
            textBoxClName.Text = dataGridMain.Rows[i].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridMain.Rows[i].Cells[4].Value.ToString();
            textBoxPhone.Text = dataGridMain.Rows[i].Cells[5].Value.ToString();
            textBoxPostal.Text = dataGridMain.Rows[i].Cells[6].Value.ToString();
            textBoxFax.Text = dataGridMain.Rows[i].Cells[7].Value.ToString();
            panelGeneralOp.BackColor = Color.RoyalBlue;
            DecisionPanel.BackColor = Color.RoyalBlue;
            IsEdit = true;
            buttonOK.Enabled = true;
            panel1.Enabled = false;
            buttonAdd.Enabled = false;
        }

        private void ClearAll()
        {
            textBoxClName.Text = "";
            comboSo.SelectedIndex = 0;
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxPostal.Text = "";
            textBoxFax.Text = "";
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
            buttonEdit.Enabled = false;
        }


        private void buttonHide_Click(object sender, EventArgs e)
        {
            bool set = (groupBoxHider.Visible == true) ? groupBoxHider.Visible = false : groupBoxHider.Visible = true;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            M_Client send = new M_Client()
            {
                ClID = ObtainedID,
                ClHidden = richTextHideReason.Text,
                ClFlag = 1
            };
            clientAccess.BravoSixGoingDark(send);
            CancelThing();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            richTextHideReason.Enabled = true;
            panelHide.Enabled = true;
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int SoID = int.Parse(comboSo.SelectedValue.ToString());
            M_Client Client = new M_Client()
            {
                ClName = textBoxClName.Text,
                SoID = SoID,
                ClAddress = textBoxAddress.Text,
                ClPhone = textBoxPhone.Text,
                ClPostal = textBoxPostal.Text,
                ClFAX = textBoxFax.Text
            };
                var context = new SalesManagement_DevContext();
                if (context.M_Clients.Any(x => x.ClName == Client.ClName))
                {
                    DialogResult result = MessageBox.Show("顧客名 " + Client.ClName + " はすでに存在しています。\n" + "それでも追加しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                }
                if (context.M_Clients.Any(x => x.ClAddress == Client.ClAddress))
                {
                    DialogResult result = MessageBox.Show("住所 " + Client.ClAddress + " はすでに存在しています。\n" + "それでも追加しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                }
             if (!IsEdit)
            {
                clientAccess.AddNew(Client);
                context.Dispose();
            }  
            else
            { var ID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString()); clientAccess.Modify(Client, ID); }
            CancelThing();
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
            buttonEdit.Enabled = true;
            buttonAdd.Enabled = true;
        }
        private void GenerateFilter()
        {
            int type = comboSearchCa.SelectedIndex;
            var search = textBoxSearch.Text;
            if (!checkHiddenToggle.Checked)
            { ClientDsp = clientAccess.DefaultSearch(type, search); SetMainView(); }
            else
            { ClientDspHidden = clientAccess.HiddenSearch(type, search); SetHiddenView(); }

        }

        private void comboSearchCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateFilter();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GenerateFilter();
        }

        private void checkHiddenToggle_CheckedChanged(object sender, EventArgs e)
        {
            GenerateFilter();
        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMain.Rows.Count > 0)
            {
                int i = dataGridMain.CurrentRow.Index;
                labelClName.Text = dataGridMain.Rows[i].Cells[3].Value.ToString();
                labelClID.Text = dataGridMain.Rows[i].Cells[0].Value.ToString();
                labelSoName.Text = dataGridMain.Rows[i].Cells[2].Value.ToString();
                labelAddress.Text = dataGridMain.Rows[i].Cells[4].Value.ToString();
                labelPhone.Text = dataGridMain.Rows[i].Cells[5].Value.ToString();
                labelPostal.Text = dataGridMain.Rows[i].Cells[6].Value.ToString();
                labelFAX.Text = dataGridMain.Rows[i].Cells[7].Value.ToString();
                ObtainedID = int.Parse(dataGridMain.Rows[i].Cells[0].Value.ToString());
                labelHiddenReason.Visible = false;
                buttonHide.Visible = true;
                buttonUnHide.Visible = false;
                buttonEdit.Enabled = true;
                if (checkHiddenToggle.Checked)
                {
                    buttonHide.Visible = false;
                    buttonUnHide.Visible = true;
                    labelHiddenReason.Visible = true;
                    labelHiddenReason.Text = "非表示理由：" + dataGridMain.Rows[i].Cells[10].Value.ToString();
                }
                SetPosition();
            }
        }

        private void buttonUnHide_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("表示化させますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            clientAccess.SnapBackToReality(ObtainedID);
            CancelThing();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void buttonBacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckText(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxClName.Text) && !string.IsNullOrEmpty(textBoxAddress.Text) && textBoxPhone.Text.Trim().Length == 13
                && textBoxPostal.Text.Trim().Length == 7 && textBoxFax.Text.Trim().Length >= 11)
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }
    }
}