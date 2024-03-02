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
    public partial class U_Classify : UserControl
    {
        public U_Classify()
        {
            InitializeComponent();
        }
        ClassificationAccess classificationAccess = new ClassificationAccess();
        //
        private static List<M_MajorClassificationDsp> MajorDsp;
        //
        private static List<M_MajorClassificationHiddenDsp> MajorHiddenDsp;
        //
        private static List<M_SmallClassificationDsp> SmallDsp;
        private void U_Classify_Load(object sender, EventArgs e)
        {
            panelAddMajor.Visible = false;
            panelModMajor.Visible = false;
            panelAddSmall.Visible = false;
            panelModSmall.Visible = false;
            panelHideMajor.Visible = false;
            defaultOpenModMajor.Enabled = false;
            defaultOpenModSmall.Enabled = false;
            defaultOpenAddSmall.Enabled = false;
            defaultCancelMajor.Visible = false;
            defaultCancelSmall.Visible = false;
            labelHideReason.Visible = false;        
            LoadUser();
            Clock.Start();
            LoadMainGrid();
            SetPosition();
        }
        int ObtainedMID = 0;
        int ObtainedSID = 0;
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
                if (Pos[7] == "R")
                { defaultOpenAddMajor.Enabled = false; defaultOpenAddSmall.Enabled = false;
                    defaultOpenModMajor.Enabled = false; defaultOpenModSmall.Enabled = false; }
                else if (Pos[7] == "RW") { }
                else this.Enabled = false;
            }
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }
        // メソッド名:LoadMainGrid()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:グリッドデータの設定
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
        // メソッド名:LoadMainData()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文データの取得
        private void LoadMainData()
        {
            MajorDsp = classificationAccess.GetMajorClassDisplay();

            SetMainView();
        }
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = MajorDsp.ToList();

            dataGridMain.Columns[0].Width = 100;
            dataGridMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
        }
        private void SetMainHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = MajorHiddenDsp.ToList();

            dataGridMain.Columns[0].Width = 100;
            dataGridMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridMain.Columns[2].Visible = false;
            dataGridMain.Columns[3].Visible = false;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Refresh();
        }
        private void defaultOpenAddMajor_Click(object sender, EventArgs e)
        {
            panelAddMajor.Visible = true;
            panelModMajor.Visible = false;
            defaultCancelMajor.Visible = true;
            defaultAddMajor.Enabled = false;
            textBoxAddMajor.Focus();
            panelDatas.Enabled = false;
        }
        private void defaultOpenModMajor_Click(object sender, EventArgs e)
        {
            panelAddMajor.Visible = false;
            panelModMajor.Visible = true;
            defaultCancelMajor.Visible = true;
            defaultModMajor.Enabled = false;
            labelModNameM.Text = "大分類" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString()
                + "を、";
            textBoxModMajor.Focus();
            panelDatas.Enabled = false;
        }
        private void defaultOpenAddSmall_Click(object sender, EventArgs e)
        {
            panelAddSmall.Visible = true;
            panelModSmall.Visible = false;
            defaultAddSmall.Enabled = false;
            defaultCancelSmall.Visible = true;
            panelDatas.Enabled = false;
        }
        private void defaultOpenModSmall_Click(object sender, EventArgs e)
        {
            panelAddSmall.Visible = false;
            panelModSmall.Visible = true;
            defaultModSmall.Enabled = false;
            defaultCancelSmall.Visible = true;
            panelDatas.Enabled = false;
        }
        private void defaultHideMajor_Click(object sender, EventArgs e)
        {
            panelAddMajor.Visible = false;
            panelModMajor.Visible = false;
            panelHideMajor.Visible = true;
            textBoxMajorHideReason.Focus();
        }
        private void defaultHideSmall_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(labelSelectedSmall.Text + "非表示にしますか？", "確認",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                M_SmallClassification Del = new M_SmallClassification() { ScID = ObtainedSID, ScHidden = "Dead Man Tells No Tales" };
                classificationAccess.BravoSixGoingDarkSmall(Del); CancelSmallOp();
            }

        }
        private void CancelMajorOp()
        {
            defaultCancelMajor.Visible = false;
            panelAddMajor.Visible = false;
            panelModMajor.Visible = false;
            panelHideMajor.Visible = false;
            textBoxAddMajor.Text = "";
            textBoxModMajor.Text = "";
            textBoxMajorHideReason.Text = "";
            panelDatas.Enabled = true;
            SearchMajor(new object(), new EventArgs());
        }
        private void CancelSmallOp()
        {
            defaultCancelSmall.Visible = false;
            panelAddSmall.Visible = false;
            panelModSmall.Visible = false;
            textBoxAddSmall.Text = "";
            textBoxModSmall.Text = "";
            panelDatas.Enabled = true;
            SearchSmall(new object(), new EventArgs());
        }

        private void defaultAddMajor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("大分類" + textBoxAddMajor.Text + "を追加しますか？", "確認",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            { classificationAccess.AddMajor(textBoxAddMajor.Text); CancelMajorOp(); }
        }

        private void defaultModMajor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(labelModNameM.Text + textBoxModMajor.Text + "に更新しますか？", "確認",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                M_MajorClassification Mod = new M_MajorClassification() { McID = ObtainedMID, McName = textBoxModMajor.Text };
                classificationAccess.ModifyMajor(Mod); CancelMajorOp(); }
        }

        private void defaultAddSmall_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("小分類" + textBoxAddSmall.Text + "を追加しますか？", "確認",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            { classificationAccess.AddSmall(textBoxAddSmall.Text, ObtainedMID); CancelSmallOp(); }
        }
        private void defaultModSmall_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(labelSelectedSmall.Text + textBoxModSmall.Text + "に更新しますか？", "確認",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                M_SmallClassification Mod = new M_SmallClassification() { ScID = ObtainedSID, ScName = textBoxModSmall.Text };
                classificationAccess.ModifySmall(Mod); CancelSmallOp();
            }
        }
        private void defaultCoHideMajor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(labelModNameM.Text + "非表示にしますか？", "確認",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                M_MajorClassification Del = new M_MajorClassification() { McID = ObtainedMID, McHidden = textBoxMajorHideReason.Text };
                classificationAccess.BravoSixGoingDarkMajor(Del); CancelMajorOp();
            }
        }
        private void defaultCancelMajor_Click(object sender, EventArgs e)
        {
            CancelMajorOp();
        }

        private void defaultCancelSmall_Click(object sender, EventArgs e)
        {
            CancelSmallOp();
        }

        private void textBoxMajor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxAddMajor.Text) || !string.IsNullOrEmpty(textBoxModMajor.Text))
            { defaultAddMajor.Enabled = true; defaultModMajor.Enabled = true; }
            else
            { defaultAddMajor.Enabled = false; defaultModMajor.Enabled = false; }
        }
        private void textBoxSmall_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxAddSmall.Text) || !string.IsNullOrEmpty(textBoxModSmall.Text))
            { defaultAddSmall.Enabled = true; defaultModSmall.Enabled = true; }
            else
            { defaultAddSmall.Enabled = false; defaultModSmall.Enabled = false; }
        }
        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMain.RowCount > 0)
            {
                ObtainedMID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                DspMajorID.Text = "大分類ID： " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString();
                DspMajorName.Text = "大分類名： " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString();
                LoadSmallClass();
                defaultOpenModMajor.Enabled = true;
                labelSelectedSmall.Text = "大分類" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString()
                    + "の小分類を、";
                defaultOpenModSmall.Enabled = false;
                defaultOpenAddSmall.Enabled = true;
                if (checkHiddenToggle.Checked)
                    labelHideReason.Text = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[3].Value.ToString();
                SetPosition();
            }
        }
        private void dataGridSecond_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridSecond.RowCount > 0)
            {
                ObtainedSID = int.Parse(dataGridSecond.Rows[dataGridSecond.CurrentRow.Index].Cells[0].Value.ToString());
                labelSelectedSmall.Text = "小分類" + dataGridSecond.Rows[dataGridSecond.CurrentRow.Index].Cells[1].Value.ToString()
                    + "を、";
                defaultOpenModSmall.Enabled = true;
                defaultOpenAddSmall.Enabled = false;
                SetPosition();
            }
        }
        private void LoadSmallClass()
        {
            //読み取り専用
            dataGridSecond.ReadOnly = true;
            //行ごと選択
            dataGridSecond.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridSecond.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データの取得
            LoadSmallData();
        }
        private void LoadSmallData()
        {
            SmallDsp = classificationAccess.GetSmallClassDisplay(ObtainedMID);
            SetSecondView();
        }
        private void SetSecondView()
        {
            dataGridSecond.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridSecond.RowTemplate.Height = 50;
            dataGridSecond.DataSource = SmallDsp;
            dataGridSecond.Columns[0].Width = 100;
            dataGridSecond.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridSecond.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSecond.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridSecond.Refresh();
            //
            int cnt = dataGridSecond.RowCount;
            DspTotalSmall.Text = "小分類" + cnt + "個を保有";
        }

        private void SearchMajor(object sender, EventArgs e)
        {
            var search = textBoxSearchMa.Text;
            if(!checkHiddenToggle.Checked)
            { MajorDsp = classificationAccess.DefaultSearchMajor(search); SetMainView();labelHideReason.Visible = false; }
            else
            { MajorHiddenDsp = classificationAccess.HiddenSearch(search); SetMainHiddenView(); labelHideReason.Visible = true; }
            bool check = dataGridMain.RowCount > 0 ? true : false;
            foreach (DataGridViewRow row in dataGridMain.Rows)
            {
                if (row.Cells[0].Value.ToString() == ObtainedMID.ToString())
                { check = true; break; }
                else
                    check = false;
            }
            if (!check)
            {
                dataGridSecond.DataSource = null;
                dataGridSecond.Rows.Clear();
                ObtainedMID = 0; ObtainedSID = 0;
                defaultOpenAddSmall.Enabled = false;
                defaultOpenModSmall.Enabled = false;
                defaultOpenModMajor.Enabled = false;
                DspTotalSmall.Text = "小分類　個を保有";
                DspMajorID.Text = "大分類ID：　";
                DspMajorName.Text = "大分類名： ";
                labelSelectedSmall.Text = "大分類、又は小分類を選択してください";
            }
        }

        private void SearchSmall(object sender, EventArgs e)
        {
            var search = textBoxSearchSm.Text;
            SmallDsp = classificationAccess.SearchSmall(search, ObtainedMID); SetSecondView();
        }
    }
}
