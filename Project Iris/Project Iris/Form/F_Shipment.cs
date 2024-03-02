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
    public partial class F_Shipment : Form
    {
        ShipmentAccess shipmentAccess = new ShipmentAccess();
        private static List<T_ShipmentDsp> ShipmentDsp;
        private static List<T_ShipmentDspHidden> ShipmentDspHidden;
        private static List<T_ShipmentDetailDsp> ShipmentDetailDsp;
        int obtainedID = 0;
        public F_Shipment()
        {
            InitializeComponent();
        }
        private void F_Shipment_Load(object sender, EventArgs e)
        {
            groupBoxHider.Visible = false;
            richTextHideReason.Visible = false;
            buttonHidCo.Visible = false;
            buttonHidCa.Visible = false;
            comboSearchCa.SelectedIndex = 0;
            comboSearchCa.DropDownStyle = ComboBoxStyle.DropDownList;
            Clock.Start();
            LoadMainGrid();
            LoadUser();
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
        //
        private void SetPosition()
        {
            using (var context = new SalesManagement_DevContext())
            {
                int GetPos = context.M_Employees.Single(x => x.EmID == D_LoginData.EmID).PoID;
                string[] Pos = context.M_Positions.Single(x => x.PoID == GetPos).Positions.Split(',');
                if (Pos[4] == "R")
                { buttonHide.Enabled = false; buttonUnHide.Enabled = false; buttonCoSh.Enabled = false; }
                else if (Pos[4] == "RW") { }
                else this.Close();
            }
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
            ShipmentDsp = shipmentAccess.GetShipmentDisplay();

            SetMainView();
        }
        // メソッド名:SetMainView()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:注文データの表示
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = ShipmentDsp.ToList();

            dataGridMain.Columns[0].Width = 100;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 200;
            dataGridMain.Columns[3].Visible = false;
            dataGridMain.Columns[4].Width = 200;
            dataGridMain.Columns[5].Visible = false;
            dataGridMain.Columns[6].Width = 200;
            dataGridMain.Columns[7].Width = 200;
            dataGridMain.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Refresh();
            Sweeper();
        }
        // メソッド名:LoadDetailGrid()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:グリッドデータの設定
        private void LoadDetailGrid()
        {
            //読み取り専用
            dataGridDetail.ReadOnly = true;
            //行ごと選択
            dataGridDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データの取得
            LoadDetailData();
        }
        private void LoadDetailData()
        {
            ShipmentDetailDsp = shipmentAccess.GetShipmentDetail(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            SetDetailView();
        }
        private void SetDetailView()
        {
            dataGridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridDetail.RowTemplate.Height = 50;
            dataGridDetail.DataSource = ShipmentDetailDsp;
            dataGridDetail.Columns[0].Visible = false;
            dataGridDetail.Columns[1].Width = 200;
            dataGridDetail.Columns[2].Width = 200;
            dataGridDetail.Columns[3].Width = 120;
            dataGridDetail.Columns[4].Width = 200;
            dataGridDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridDetail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            int Total = 0;
            for (int i = 0; i < dataGridDetail.Rows.Count; i++)
            {
                Total += int.Parse(dataGridDetail.Rows[i].Cells[4].Value.ToString()) * int.Parse(dataGridDetail.Rows[i].Cells[5].Value.ToString());
            }
            labelDisplayTotal.Text = "¥" + Total.ToString("#,##0");

        }
        private void SetMainHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = ShipmentDspHidden.ToList();

            dataGridMain.Columns[0].Width = 150;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 200;
            dataGridMain.Columns[3].Visible = false;
            dataGridMain.Columns[4].Width = 200;
            dataGridMain.Columns[5].Visible = false;
            dataGridMain.Columns[6].Width = 200;
            dataGridMain.Columns[7].Width = 250;
            dataGridMain.Columns[8].Width = 350;
            dataGridMain.Columns[9].Visible = false;
            dataGridMain.Columns[10].Width = 100;
            dataGridMain.Columns[11].Visible = false;
            dataGridMain.Columns[12].Width = 100;
            dataGridMain.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            dataGridMain.Refresh();
            Sweeper();
        }
        private void GenerateFilter(object sender, EventArgs e)
        {
            int type = comboSearchCa.SelectedIndex;
            var search = textBoxSearch.Text;
            if (!checkHiddenToggle.Checked)
            { ShipmentDsp = shipmentAccess.DefaultSearch(search, type); buttonHide.Visible = true; buttonUnHide.Visible = false; SetMainView(); }
            else
            { ShipmentDspHidden = shipmentAccess.HiddenSearch(search, type, dateTimeFrom.Value.Date, dateTimeTo.Value.Date, SearchAsDate.Checked); buttonHide.Visible = false; buttonUnHide.Visible = true; SetMainHiddenView(); }
        }
        private void Sweeper()
        {
            checkBoxHide.Checked = false;
            checkBoxSh.Checked = false;
            bool check = dataGridMain.RowCount > 0 ? true : false;
            foreach (DataGridViewRow row in dataGridMain.Rows)
            {
                if (row.Cells[0].Value.ToString() == obtainedID.ToString())
                { check = true; break; }
                else
                    check = false;
            }
            if (!check)
            {
                foreach (Control p in groupBoxDesc.Controls)
                {
                    if (p is Label)
                        (p as Label).Text = "--";
                }
                groupBoxDesc.Text = "出荷000000";
                labelDisplayTotal.Text = "\0";
                buttonCoSh.Enabled = false;
                buttonHide.Enabled = false;
                buttonUnHide.Enabled = false;
                dataGridDetail.DataSource = null;
                dataGridDetail.Rows.Clear();
            }
        }
        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMain.RowCount > 0)
            {
                var context = new SalesManagement_DevContext();
                groupBoxDesc.Text = "出荷" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString().PadLeft(6, '0');
                labelSoID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString() + "]  営業所名: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[2].Value.ToString();
                labelClID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[5].Value.ToString() + "]  顧客名　　: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[6].Value.ToString();
                labelOrID.Text = "[受注ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[7].Value.ToString() + "]";

                LoadDetailGrid();
                obtainedID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                int counting = context.T_OrderDetails.Count(x => x.OrID == obtainedID);
                context.Dispose();
                labelEmID.Text = "--";
                labelDate.Text = "--";
                buttonCoSh.Enabled = true;
                if (checkHiddenToggle.Checked)
                {
                    richTextDescHide.Text = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[13].Value?.ToString();
                    checkBoxSh.Checked = Convert.ToBoolean(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[10].Value);
                    checkBoxHide.Checked = Convert.ToBoolean(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[12].Value);
                    if (checkBoxSh.Checked)
                    {
                        labelEmID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[3].Value.ToString() + "]  社員名　　: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[4].Value.ToString();
                        DateTime getdate = Convert.ToDateTime(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[8].Value.ToString());
                        labelDate.Text = getdate.ToString("yyyy年MM月dd日") + " に出荷";
                    }
                    buttonCoSh.Enabled = false;
                }
                else buttonHide.Enabled = true;
                if (checkBoxSh.Checked) { buttonUnHide.Enabled = false; buttonCoSh.Enabled = false; }
                else { buttonUnHide.Enabled = true; }
                SetPosition();
            }
        }

        private void buttonCoOr_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("出荷しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                var context = new SalesManagement_DevContext();
                int soID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString());
                int clID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[5].Value.ToString());
                int orID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[7].Value.ToString());
                int emID = context.T_Orders.Single(x => x.OrID == orID).EmID;
                T_Shipment table = new T_Shipment()
                {
                    SoID = soID,
                    ClID = clID,
                    OrID = orID
                };
                shipmentAccess.KingsCross(table,emID);
                var complete = context.T_Shipments.Single(x => x.ShID == obtainedID);
                complete.ShStateFlag = 1;
                complete.EmID = D_LoginData.EmID;
                complete.ShFinishDate = DateTime.Now.Date;
                context.SaveChanges();
                context.Dispose();
                GenerateFilter(sender, e);
                buttonCoSh.Enabled = false;
            }
        }

        private void buttonBacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (groupBoxHider.Visible == false)
            {
                groupBoxHider.Visible = true;
                richTextHideReason.Visible = true;
                panelHide.Visible = true;
                buttonHidCo.Visible = true;
                buttonHidCa.Visible = true;
            }
            else
            {
                groupBoxHider.Visible = false;
                richTextHideReason.Visible = false;
                buttonHidCo.Visible = false;
                buttonHidCa.Visible = false;
                panelHide.Visible = false;
            }
        }

        private void buttonHidCo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("出荷ID :" + obtainedID + "を取り消しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                shipmentAccess.BravoSixGoingDark(obtainedID, richTextDescHide.Text);
                groupBoxHider.Visible = false;
                richTextHideReason.Text = "";
                buttonHide.Enabled = false;
                GenerateFilter(sender, e);
            }
        }

        private void buttonHidCa_Click(object sender, EventArgs e)
        {
            groupBoxHider.Visible = false;
            richTextHideReason.Text = null;
        }

        private void buttonUnHide_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("出荷ID :" + obtainedID + "を復元しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            { shipmentAccess.SnapBackToReality(obtainedID); buttonUnHide.Enabled = false; GenerateFilter(sender, e); }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }
    }
}
