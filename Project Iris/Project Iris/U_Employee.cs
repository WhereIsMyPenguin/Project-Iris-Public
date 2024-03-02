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
    public partial class U_Employee : UserControl
    {
        //社員
        EmployeeAccess employeeAccess = new EmployeeAccess();
        //
        private static List<M_EmployeeDsp> EmployeeDsp;
        //
        private static List<M_EmployeeDspHidden> EmployeeDspHidden;
        public U_Employee()
        {
            InitializeComponent();
        }
        bool IsEdit = false;
        int ObtainedID = 0;
        private void U_Employee_Load(object sender, EventArgs e)
        {
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            panelGeneralOp.Visible = false;
            groupBoxHider.Visible = false;
            comboSearchCa.SelectedIndex = 0;
            panelHideConfirm.BackColor = Color.White;
            panelHide.BackColor = Color.RoyalBlue;
            textBoxPhone.ImeMode = ImeMode.Disable;
            buttonEdit.Enabled = false;
            labelHiddenReason.Visible = false;
            panelChangePass.Visible = false;
            textBoxPass.Enabled = false;
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
                if (Pos[0] == "R")
                { buttonAdd.Enabled = false; buttonEdit.Enabled = false; }
                else if (Pos[0] == "RW") { }
                else this.Enabled = false;
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
            EmployeeDsp = employeeAccess.GetEmployeeDisplay();
            //
            SalesOfficeAccess access = new SalesOfficeAccess();
            List<M_SalesOfficeCombo> SalesOffice = access.GetSalesOfficeCombos();
            comboSo.DisplayMember = "Display";
            comboSo.ValueMember = "Value";
            comboSo.DataSource = SalesOffice;
            if(comboSo.Items.Count > 10)
            {
                comboSo.DropDownStyle = ComboBoxStyle.DropDown;
                comboSo.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboSo.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            //
            PositionAccess access1 = new PositionAccess();
            List<M_PositionCombo> Position = access1.GetPostitionCombo();
            comboPo.DisplayMember = "Display";
            comboPo.ValueMember = "Value";
            comboPo.DataSource = Position;
            if (comboPo.Items.Count > 10)
            {
                comboPo.DropDownStyle = ComboBoxStyle.DropDown;
                comboPo.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboPo.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            SetMainView();
        }
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = EmployeeDsp.ToList();

            dataGridMain.Columns[0].Width = 80;
            dataGridMain.Columns[1].Width = 100;
            dataGridMain.Columns[2].Visible = false;
            dataGridMain.Columns[3].Width = 100;
            dataGridMain.Columns[4].Visible = false;
            dataGridMain.Columns[5].Width = 180;
            dataGridMain.Columns[6].Width = 250;
            dataGridMain.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
        }
        private void SetHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = EmployeeDspHidden.ToList();

            dataGridMain.Columns[0].Width = 80;
            dataGridMain.Columns[1].Width = 100;
            dataGridMain.Columns[2].Visible = false;
            dataGridMain.Columns[3].Width = 100;
            dataGridMain.Columns[4].Visible = false;
            dataGridMain.Columns[5].Width = 180;
            dataGridMain.Columns[6].Width = 180;
            dataGridMain.Columns[7].Width = 180;
            dataGridMain.Columns[8].Visible = false;
            dataGridMain.Columns[9].Width = 100;
            dataGridMain.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
        }
        private void ClearAll()
        {
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxPass.Text = "";
            comboSo.SelectedIndex = 0;
            comboPo.SelectedIndex = 0;
            EmDate.Value = DateTime.Now.Date;
        }
        private void Check(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && textBoxPhone.Text.Trim().Length == 13)
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }
        private void GenerateFilter(object sender, EventArgs e)
        {
            int type = comboSearchCa.SelectedIndex;
            var search = textBoxSearch.Text;
            if (!checkHiddenToggle.Checked)
            { EmployeeDsp = employeeAccess.DefaultSearch(type,search,SearchAsDate.Checked,dateTimeFrom.Value,dateTimeTo.Value); SetMainView(); }
            else
            { EmployeeDspHidden = employeeAccess.HiddenSearch(type, search, SearchAsDate.Checked, dateTimeFrom.Value, dateTimeTo.Value); SetHiddenView(); }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            panelGeneralOp.Visible = true;
            panelDisplay.Visible = false;
            panelGeneralOp.BackColor = Color.SpringGreen;
            DecisionPanel.BackColor = Color.SpringGreen;
            IsEdit = false;
            panelChangePass.Visible = false;
            groupBoxHider.Visible = false;
            buttonOK.Enabled = false;
            buttonHide.Visible = false;
            buttonUnHide.Visible = false;
            panel1.Enabled = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ClearAll();
            EmDate.Enabled = false;
            panelGeneralOp.Visible = true;
            panelDisplay.Visible = false;
            int i = dataGridMain.CurrentRow.Index;
            textBoxName.Text = dataGridMain.Rows[i].Cells[1].Value.ToString();
            comboSo.SelectedValue = dataGridMain.Rows[i].Cells[2].Value.ToString();
            comboPo.SelectedValue = dataGridMain.Rows[i].Cells[4].Value.ToString();
            var Date = dataGridMain.Rows[i].Cells[6].Value;
            EmDate.Value = Convert.ToDateTime(Date).Date;
            textBoxPhone.Text = dataGridMain.Rows[i].Cells[7].Value.ToString();
            panelGeneralOp.BackColor = Color.RoyalBlue;
            DecisionPanel.BackColor = Color.RoyalBlue;
            IsEdit = true;
            buttonOK.Enabled = true;
            buttonHide.Visible = true;
            buttonUnHide.Visible = false;
            panel1.Enabled = false;
            panelChangePass.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelThing();
        }
        private void CancelThing()
        {
            SetNewPass.Checked = false;
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            richTextHideReason.Enabled = true;
            panelHide.Enabled = true;
            groupBoxHider.Visible = false;
            panelGeneralOp.Visible = false;
            EmDate.Enabled = true;
            ClearAll();
            panelChangePass.Visible = false;
            panelDisplay.Visible = true;
            GenerateFilter(new object(), new EventArgs());
            panel1.Enabled = true;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMain.Rows.Count > 0)
            {
                int i = dataGridMain.CurrentRow.Index;
                labelEmName.Text = dataGridMain.Rows[i].Cells[1].Value.ToString();
                labelEmID.Text = dataGridMain.Rows[i].Cells[0].Value.ToString();
                labelSo.Text = dataGridMain.Rows[i].Cells[3].Value.ToString();
                labelPo.Text = dataGridMain.Rows[i].Cells[5].Value.ToString();
                labelPhone.Text = dataGridMain.Rows[i].Cells[7].Value.ToString();
                DateTime Date = Convert.ToDateTime(dataGridMain.Rows[i].Cells[6].Value.ToString());
                labelDate.Text = Date.ToString("yyyy年MM月dd日");
                ObtainedID = int.Parse(dataGridMain.Rows[i].Cells[0].Value.ToString());
                labelHiddenReason.Visible = false;
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

        private void buttonHide_Click(object sender, EventArgs e)
        {
            bool set = (groupBoxHider.Visible == true) ? groupBoxHider.Visible = false : groupBoxHider.Visible = true;
            set = (panelChangePass.Visible == true) ? panelChangePass.Visible = false : panelChangePass.Visible = true;
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
            panelChangePass.Visible = true;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            richTextHideReason.Enabled = true;
            panelHide.Enabled = true;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            M_Employee send = new M_Employee()
            {
                EmID = ObtainedID,
                EmHidden = richTextHideReason.Text,
                EmFlag = 1
            };
            employeeAccess.BravoSixGoingDark(send);
            CancelThing();
            GenerateFilter(sender, e);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            int soID = int.Parse(comboSo.SelectedValue.ToString().Split(' ')[0]);
            int poID = int.Parse(comboPo.SelectedValue.ToString());
            if (!IsEdit)
            {
                var context = new SalesManagement_DevContext();
                if (context.M_Employees.Any(x => x.EmName == textBoxName.Text))
                {
                    DialogResult result = MessageBox.Show("社員名 " + textBoxName.Text + " はすでに入社しています。\n" + "それでも追加しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                }
                using(var form = new F_Register())
                {
                    form.Stats = "新社員のパスワード";
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string Pass = form.Pass;
                        M_Employee employeeA = new M_Employee()
                        {
                            EmName = textBoxName.Text,
                            SoID = soID,
                            PoID = poID,
                            EmPhone = textBoxPhone.Text,
                            EmHiredate = EmDate.Value.Date,
                            EmPassword = Pass
                        };
                        employeeAccess.AddNew(employeeA);
                    }
                    else
                        return;
                }
                context.Dispose();
            }
            else
            { var ID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                if(!SetNewPass.Checked)
                {
                    using (var form = new F_Register())
                    {
                        form.Stats = "ログインユーザーのパスワード";
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            string Pass = form.Pass;
                            M_Employee employee = new M_Employee()
                            {
                                EmName = textBoxName.Text,
                                SoID = soID,
                                PoID = poID,
                                EmPhone = textBoxPhone.Text,
                            };
                            employeeAccess.Modify(employee, ID);
                        }
                        else
                            return;
                    }
                }
                else
                {
                    using (var form = new F_Register())
                    {
                        form.Stats = "本人確認";
                        form.ID = ID;
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            PasswordHash hash = new PasswordHash();
                            string Pass = hash.CreatePasswordHash(textBoxPass.Text);
                            M_Employee employee = new M_Employee()
                            {
                                EmPassword = Pass
                            };
                            employeeAccess.ModifyPass(employee, ID);
                        }
                        else
                            return;
                    }
                }
            }
            CancelThing();
            GenerateFilter(sender,e);
        }

        private void PassStats_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxPass.TextLength < 4)
                toolTipPass.SetToolTip(PassStats, "4文字以上です");
            else
                toolTipPass.SetToolTip(PassStats, "OKです");
        }

        private void labelToggle_Click(object sender, EventArgs e)
        {
            if (labelToggle.Text == "・") { labelToggle.Text = "●"; textBoxPass.PasswordChar = '\0'; }
            else { labelToggle.Text = "・"; textBoxPass.PasswordChar = '●'; } 
        }

        private void SetNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if(SetNewPass.Checked)
            {
                textBoxName.Enabled = false;
                textBoxPhone.Enabled = false;
                comboPo.Enabled = false;
                comboSo.Enabled = false;
                textBoxPass.Enabled = true;
                CheckPass(sender, e);
            }
            else
            {
                textBoxName.Enabled = true;
                textBoxPhone.Enabled = true;
                comboPo.Enabled = true;
                comboSo.Enabled = true;
                textBoxPass.Enabled = false;
                Check(sender, e);
            }
        }

        private void CheckPass(object sender, EventArgs e)
        {
            if (SetNewPass.Checked && !string.IsNullOrEmpty(textBoxPass.Text) && textBoxPass.TextLength >= 4)
            { buttonOK.Enabled = true; PassStats.Text = "✔";PassStats.ForeColor = Color.LimeGreen; toolTipPass.SetToolTip(PassStats, "OKです"); }
            else
            { buttonOK.Enabled = false; PassStats.Text = "✘"; PassStats.ForeColor = Color.Crimson; toolTipPass.SetToolTip(PassStats, "4文字以上です"); }
        }

        private void buttonUnHide_Click(object sender, EventArgs e)
        {
            M_Employee send = new M_Employee()
            {
                EmID = ObtainedID,
                EmFlag = 0
            };
            employeeAccess.SnapBackToReality(send);
            CancelThing();
            GenerateFilter(sender, e);
        }
    }
}
