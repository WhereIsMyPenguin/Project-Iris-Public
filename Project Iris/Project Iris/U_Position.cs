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
    public partial class U_Position : UserControl
    {
        PositionAccess positioneAccess = new PositionAccess();
        //
        private static List<M_PositionDsp> PositionDsp;
        //
        public U_Position()
        {
            InitializeComponent();
        }
        bool IsEditMode = false;
        bool AddMod = false;
        string Pos;
        int ObtainedID;
        private void U_Position_Load(object sender, EventArgs e)
        {
            ContainerSwitch.Panel1Collapsed = true;
            ContainerSwitch.Panel2Collapsed = false;
            ContainerAdd.Panel2Collapsed = true;
            ContainerMod.Panel2Collapsed = true;
            buttonAddYes.Enabled = false;
            buttonMod.Enabled = false;
            SetCombos();
            Clock.Start();
            LoadMainGrid();
            LoadUser();
            SetPosition();
        }
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
                { buttonAdd.Enabled = false; buttonMod.Enabled = false; }
                else if (Pos[0] == "RW") { }
                else this.Enabled = false;
            }
        }
        private void SetCombos()
        {
            comboBoxLevel.SelectedIndex = 0;
            comboBoxPos.SelectedIndex = 0;
            comboSearchPo.SelectedIndex = 0;
            comboBoxLevel.Enabled = false;
            comboBoxPos.Enabled = false;
        }
        private void LoadMainGrid()
        {
            //読み取り専用
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
            PositionDsp = positioneAccess.GetPostitionDisplay();
            SetMainView();
        }
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = PositionDsp.ToList();

            dataGridMain.Columns[0].Width = 200;
            dataGridMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void GenerateFilter(object sender, EventArgs e)
        {
            string Lvl = "";
            if (SearchWithPos.Checked)
            { comboBoxPos.Enabled = true; comboBoxLevel.Enabled = true; }
            else
            { comboBoxPos.Enabled = false;comboBoxLevel.Enabled = false; }
            switch (comboBoxLevel.SelectedItem.ToString())
            {
                case "なし":Lvl = "N";
                    break;
                case "参照":Lvl = "R";
                    break;
                case "登録・更新":Lvl = "RW";
                    break;
                case "決定": Lvl = "RW";
                    break;
            }
            if (!SearchWithPos.Checked)
                dataGridMain.DataSource = positioneAccess.Search(textBoxSearch.Text, comboSearchPo.SelectedIndex, -1,Lvl);
            else
                dataGridMain.DataSource = positioneAccess.Search(textBoxSearch.Text,comboSearchPo.SelectedIndex,comboBoxPos.SelectedIndex,Lvl);
        }
        private void checkBoxEmW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxEmR.Checked && checkBoxEmW.Checked) 
                checkBoxEmR.Checked = true;
        }

        private void checkBoxEmR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxEmR.Checked && checkBoxEmW.Checked)
                checkBoxEmW.Checked = false;
        }

        private void checkBoxClR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxClR.Checked && checkBoxClW.Checked)
                checkBoxClW.Checked = false;
        }

        private void checkBoxClW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxClR.Checked && checkBoxClW.Checked)
                checkBoxClR.Checked = true;
        }

        private void checkBoxSaR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxOrW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxOrR.Checked && checkBoxOrW.Checked)
                checkBoxOrR.Checked = true;
        }

        private void checkBoxOrR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxOrR.Checked && checkBoxOrW.Checked)
                checkBoxOrW.Checked = false;
        }

        private void checkBoxShW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShR.Checked && checkBoxShW.Checked)
                checkBoxShR.Checked = true;
        }

        private void checkBoxShR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShR.Checked && checkBoxShW.Checked)
                checkBoxShW.Checked = false;
        }

        private void checkBoxArW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxArR.Checked && checkBoxArW.Checked)
                checkBoxArR.Checked = true;
        }

        private void checkBoxArR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxArR.Checked && checkBoxArW.Checked)
                checkBoxArW.Checked = false;
        }

        private void checkBoxSoW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSoR.Checked && checkBoxSoW.Checked)
                checkBoxSoR.Checked = true;
        }

        private void checkBoxSoR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSoR.Checked && checkBoxSoW.Checked)
                checkBoxSoW.Checked = false;
        }

        private void checkBoxPrW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxPrR.Checked && checkBoxPrW.Checked)
                checkBoxPrR.Checked = true;
        }

        private void checkBoxPrR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxPrR.Checked && checkBoxPrW.Checked)
                checkBoxPrW.Checked = false;
        }

        private void checkBoxChW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxChR.Checked && checkBoxChW.Checked)
                checkBoxChR.Checked = true;
        }

        private void checkBoxChR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxChR.Checked && checkBoxChW.Checked)
                checkBoxChW.Checked = false;
        }
        private void checkBoxMaW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMaR.Checked && checkBoxMaW.Checked)
                checkBoxMaR.Checked = true;
        }
        private void checkBoxMaR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMaR.Checked && checkBoxMaW.Checked)
                checkBoxMaW.Checked = false;
        }
        private void checkBoxSyW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSyR.Checked && checkBoxSyW.Checked)
                checkBoxSyR.Checked = true;
        }

        private void checkBoxSyR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSyR.Checked && checkBoxSyW.Checked)
                checkBoxSyW.Checked = false;
        }

        private void checkBoxHWW_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxHWR.Checked && checkBoxHWW.Checked)
                checkBoxHWR.Checked = true;
        }

        private void checkBoxHWR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxHWR.Checked && checkBoxHWW.Checked)
                checkBoxHWW.Checked = false;
        }

        private void checkBoxStR_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void SwitchMode()
        {
            if(IsEditMode)
            {
                ContainerMod.Panel1Collapsed = true;
                ContainerMod.Panel2Collapsed = false;
                ContainerAdd.Enabled = false;
            }
            else
            {
                ContainerAdd.Panel1Collapsed = true;
                ContainerAdd.Panel2Collapsed = false;
                ContainerMod.Enabled = false;
            }
            ContainerSwitch.Panel1Collapsed = false;
            ContainerSwitch.Panel2Collapsed = true;
        }
        private void Cancel()
        {
            if(AddMod)
            {
                ContainerAdd.Panel1Collapsed = false;
                ContainerAdd.Panel2Collapsed = true;
                ContainerMod.Enabled = true;
            }
            else
            {
                ContainerMod.Panel1Collapsed = false;
                ContainerMod.Panel2Collapsed = true;
                ContainerAdd.Enabled = true;
            }
            ContainerSwitch.Panel1Collapsed = true;
            ContainerSwitch.Panel2Collapsed = false;
            textBoxPoEnter.Text = "";
            labelPleaseEnter.Visible = true;
            dataGridMain.Enabled = true;
            ClearPosition();
            dataGridMain_CellClick(new object(), new DataGridViewCellEventArgs(0, 0));
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            AddMod = true;
            ClearPosition();
            dataGridMain.Enabled = false;
            SwitchMode();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            AddMod = false;
            ClearPosition();
            LoadtoControl(Pos);
            textBoxPoEnter.Text = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString();
            dataGridMain.Enabled = false;
            SwitchMode();
        }

        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void buttonModNo_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void labelPleaseEnter_Click(object sender, EventArgs e)
        {
            labelPleaseEnter.Visible = false;
            textBoxPoEnter.Focus();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            labelPleaseEnter.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPoEnter.Text))
            { labelPleaseEnter.Visible = false; buttonAddYes.Enabled = true; }
            else { labelPleaseEnter.Visible = true; buttonAddYes.Enabled = false; }
        }

        private void ClearPosition()
        {
            checkBoxArR.Checked = false;
            checkBoxChR.Checked = false;
            checkBoxClR.Checked = false;
            checkBoxEmR.Checked = false;
            checkBoxHWR.Checked = false;
            checkBoxOrR.Checked = false;
            checkBoxPrR.Checked = false;
            checkBoxSaR.Checked = false;
            checkBoxShR.Checked = false;
            checkBoxSoR.Checked = false;
            checkBoxStR.Checked = false;
            checkBoxMaR.Checked = false;
            checkBoxSyR.Checked = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearPosition();
        }
        private string CompliePos()
        {
            string Ar, Ch, Cl, Em, HW, Or, Pr, Sa, Sh, So, St,Ma, Sy;
            if (checkBoxArR.Checked == true)
            {
                Ar = "R";
                if (checkBoxArW.Checked == true) Ar = "RW";
            }
            else Ar = "N";
            if (checkBoxChR.Checked == true)
            {
                Ch = "R";
                if (checkBoxChW.Checked == true) Ch = "RW";
            }
            else Ch = "N";
            if (checkBoxClR.Checked == true)
            {
                Cl = "R";
                if (checkBoxClW.Checked == true) Cl = "RW";
            }
            else Cl = "N";
            if (checkBoxEmR.Checked == true)
            {
                Em = "R";
                if (checkBoxEmW.Checked == true) Em = "RW";
            }
            else Em = "N";
            if (checkBoxHWR.Checked == true)
            {
                HW = "R";
                if (checkBoxHWW.Checked == true) HW = "RW";
            }
            else HW = "N";
            if (checkBoxOrR.Checked == true)
            {
                Or = "R";
                if (checkBoxOrW.Checked == true) Or = "RW";
            }
            else Or = "N";
            if (checkBoxPrR.Checked == true)
            {
                Pr = "R";
                if (checkBoxPrW.Checked == true) Pr = "RW";
            }
            else Pr = "N";
            if (checkBoxSaR.Checked == true)
                Sa = "R";
            else Sa = "N";
            if (checkBoxShR.Checked == true)
            {
                Sh = "R";
                if (checkBoxShW.Checked == true) Sh = "RW";
            }
            else Sh = "N";
            if (checkBoxSoR.Checked == true)
            {
                So = "R";
                if (checkBoxSoW.Checked == true) So = "RW";
            }
            else So = "N";
            if (checkBoxStR.Checked == true)
                St = "R";
            else St = "N";
            if (checkBoxMaR.Checked == true)
            {
                Ma = "R";
                if (checkBoxMaW.Checked == true) Ma = "RW";
            }
            else Ma = "N";            
            if (checkBoxSyR.Checked == true)
            {
                Sy = "R";
                if (checkBoxSyW.Checked == true) Sy = "RW";
            }
            else Sy = "N";
            string Auth = Em + "," + Cl + "," + Sa + "," + So + "," + Sh + "," + Or + "," + Ar + ","
                + Pr + "," + HW + "," + Ch + "," + St + "," + Ma + "," + Sy;
            return Auth;
        }
        private void buttonAddYes_Click(object sender, EventArgs e)
        {

            string Auth = CompliePos();
            var context = new SalesManagement_DevContext();
            if(context.M_Positions.Any(x => x.PoName == textBoxPoEnter.Text))
            {
                DialogResult result = MessageBox.Show("役職名 " + textBoxPoEnter.Text + " はすでに存在しています。\n" + "それでも追加しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
            if(context.M_Positions.Any(x => x.Positions == Auth))
            {
                DialogResult result = MessageBox.Show("この役職の構成はすでに存在しています。\n" + "それでも追加しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
            context.Dispose();
            M_Position position = new M_Position()
            {
                PoName = textBoxPoEnter.Text.Trim(),
                Positions = Auth
            };
            positioneAccess.AddPosition(position);
            GenerateFilter(sender,e);
            Cancel();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridMain.Rows.Count > 0)
            {
                ClearPosition();
                int index = dataGridMain.CurrentRow.Index;
                labelPoName.Text = dataGridMain.Rows[index].Cells[1].Value.ToString();
                var context = new SalesManagement_DevContext();
                var poID = int.Parse(dataGridMain.Rows[index].Cells[0].Value.ToString());
                ObtainedID = poID;
                Pos = context.M_Positions.Single(x => x.PoID == poID).Positions;
                LoadtoControl(Pos);
                context.Dispose();
                buttonMod.Enabled = true;
                SetPosition();
            }
        }
        private void LoadtoControl(string Pos)
        {
            string[] PoList = Pos.Split(',');
            if (PoList[0] == "R") checkBoxEmR.Checked = true;
            else if (PoList[0] == "RW") checkBoxEmW.Checked = true;
            if (PoList[1] == "R") checkBoxClR.Checked = true;
            else if (PoList[1] == "RW") checkBoxClW.Checked = true;
            if (PoList[2] == "R") checkBoxSaR.Checked = true;
            if (PoList[3] == "R") checkBoxSoR.Checked = true;
            else if (PoList[3] == "RW") checkBoxSoW.Checked = true;
            if (PoList[4] == "R") checkBoxShR.Checked = true;
            else if (PoList[4] == "RW") checkBoxShW.Checked = true;
            if (PoList[5] == "R") checkBoxOrR.Checked = true;
            else if (PoList[5] == "RW") checkBoxOrW.Checked = true;
            if (PoList[6] == "R") checkBoxArR.Checked = true;
            else if (PoList[6] == "RW") checkBoxArW.Checked = true;
            if (PoList[7] == "R") checkBoxPrR.Checked = true;
            else if (PoList[7] == "RW") checkBoxPrW.Checked = true;
            if (PoList[8] == "R") checkBoxHWR.Checked = true;
            else if (PoList[8] == "RW") checkBoxHWW.Checked = true;
            if (PoList[9] == "R") checkBoxChR.Checked = true;
            else if (PoList[9] == "RW") checkBoxChW.Checked = true;
            if (PoList[10] == "R") checkBoxStR.Checked = true;
            if (PoList[11] == "R") checkBoxMaR.Checked = true;
            else if (PoList[11] == "RW") checkBoxMaW.Checked = true;
            if (PoList[12] == "R") checkBoxSyR.Checked = true;
            else if (PoList[12] == "RW") checkBoxSyW.Checked = true;
        }

        private void buttonModYes_Click(object sender, EventArgs e)
        {
            string Auth = CompliePos();
            var context = new SalesManagement_DevContext();
            if (context.M_Positions.Any(x => x.PoName == textBoxPoEnter.Text && x.PoID != ObtainedID))
            {
                DialogResult result = MessageBox.Show("役職名 " + textBoxPoEnter.Text + " はすでに存在しています。\n" + "それでも更新しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
            if (context.M_Positions.Any(x => x.Positions == Auth && x.PoID != ObtainedID))
            {
                DialogResult result = MessageBox.Show("この役職の構成はすでに存在しています。\n" + "それでも更新しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
            if (context.M_Positions.AsEnumerable().Count(x => x.Positions.Split(',')[0] == "RW" && x.PoID != ObtainedID) < 1)
            {
                DialogResult result = MessageBox.Show("この役職にはテーブル唯一の社員管理の権限を持っています。\n" + "よって更新できません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            context.Dispose();
            M_Position Modify = new M_Position()
            {
                PoID = ObtainedID,
                PoName = textBoxPoEnter.Text.Trim(),
                Positions = Auth
            };
            positioneAccess.ModifyPosition(Modify);
            Cancel();
            GenerateFilter(sender, e);
        }
    }
}
