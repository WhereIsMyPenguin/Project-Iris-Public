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
    public partial class U_Warehousing : UserControl
    {

        public U_Warehousing()
        {
            InitializeComponent();
        }

        //データベース注文テーブルアクセス用クラスのインスタンス化
        WarehousingAccess warehousingAccess = new WarehousingAccess();
        HattyuAccess hattyuAccess = new HattyuAccess();
        //          メーカ
        MakerAccess makerAccess = new MakerAccess();
        //          社員 
        EmployeeAccess employeeAccess = new EmployeeAccess();
        //          商品
        ProductAccess productAccess = new ProductAccess();

        //出庫
        private static List<T_Warehousing> warehousings;
        //出庫データ
        private static List<T_WarehousingDsp> WarehousingDsp;
        //出庫非表示データ
        private static List<T_WarehousingDspHidden> SyukkoDspHidden;
        //グリッドビュー用の受注データ
        private static List<T_HattyuDsp> HattyuDsp;
        //いつか使うかもしれない受注
        private static List<T_Hattyu> Hattyu;
        //グリッドビュー用の注文詳細データ
        private static List<T_WarehousingDetailDsp> WarehousingDetailDsp;
        //
        private static List<T_HattyuDspHidden> HattyuDspHidden;
        //いつか使うかもしれない受注詳細
        private static List<T_OrderDetail> HattyuDetail;
        //                営業所
        private static List<M_Maker> Makers;
        //                社員
        private static List<M_Employee> Employees;
        //                商品
        private static List<M_Product> Products;

        bool NO = true;
        bool IsEditMode = false;
        int obtainedID = 0;

        // メソッド名:LoadMainGrid()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:グリッドデータの設定
        private void LoadMainGrid()
        {
            //読み取り専用
            dataGridmain.ReadOnly = true;
            //行ごと選択
            dataGridmain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridmain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データ取得
            LoadMainData();
        }

        // メソッド名:LoadMainData()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:発注データの取得
        private void LoadMainData()
        {
            WarehousingDsp = warehousingAccess.GetWarehousingDisplay();

            SetMainView();
        }
        // メソッド名:SetMainView()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:発注データの表示
        private void SetMainView()
        {
            dataGridmain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridmain.RowTemplate.Height = 50;
            dataGridmain.DataSource = WarehousingDsp.ToList();

            dataGridmain.Columns[0].Width = 150;
            dataGridmain.Columns[1].Width = 300;
            dataGridmain.Columns[2].Width = 300;
            dataGridmain.Columns[3].Width = 300;
            dataGridmain.Columns[4].Width = 450;
            dataGridmain.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridmain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridmain.Refresh();
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
            WarehousingDetailDsp = warehousingAccess.GetWarehousingDetail(dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[0].Value.ToString());
            SetDetailView();
        }
        private void SetDetailView()
        {
            dataGridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridDetail.RowTemplate.Height = 50;
            dataGridDetail.DataSource = WarehousingDetailDsp;
            dataGridDetail.Columns[0].Width = 100;
            dataGridDetail.Columns[1].Width = 200;
            dataGridDetail.Columns[2].Width = 100;
            dataGridDetail.Columns[3].Width = 200;
            dataGridDetail.Columns[4].Width = 50;
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
                Total += int.Parse(dataGridDetail.Rows[i].Cells[5].Value.ToString());
            }
            labelDisplayTotal.Text = "¥" + Total.ToString("#,##0");
        }
        private void F_Syukko_Load(object sender, EventArgs e)
        {
            groupBoxHider.Visible = false;
            richTextHideReason.Visible = false;
            buttonHidCo.Visible = false;
            buttonHidCa.Visible = false;
            panelHideConfirm.Visible = false;
            Clock.Start();
            LoadMainGrid();
        }

        private void buttonCoWa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("出庫しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                var context = new SalesManagement_DevContext();
                var p = dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[1].Value.ToString();
                int EmID = context.M_Employees.Single(x => x.EmName == p).EmID;
                p = dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[2].Value.ToString();
                int MaID = context.M_Makers.Single(x => x.MaName == p).MaID;
                p = dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[0].Value.ToString();
                int WaID = int.Parse(p);
                T_Warehousing table = new T_Warehousing()
                {
                    WaID = WaID,
                    EmID = EmID,
                    HaID = WaID

                };
                warehousingAccess.KingsCross(table);
                var complete = context.T_Warehousings.Single(x => x.WaID == WaID);
                complete.WaShelfFlag = 1;
                complete.WaDate = DateTime.Now.Date;
                context.SaveChanges();
                context.Dispose();

            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            groupBoxHider.Visible = true;
            richTextHideReason.Visible = true;
            panelHide.Visible = true;
            buttonHidCo.Visible = true;
            buttonHidCa.Visible = true;
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            buttonYes.Visible = false;
            buttonNo.Visible = false;
        }

        private void buttonHidCo_Click(object sender, EventArgs e)
        {

            richTextHideReason.Visible = false;
            buttonHidCo.Visible = false;
            buttonHidCa.Visible = false;
            panelHide.Visible = false;
            label21.Visible = true;
            panelHideConfirm.Visible = true;
            buttonYes.Visible = true;
            buttonNo.Visible = true;
        }

        private void SetMainHiddenView()
        {
            dataGridmain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridmain.RowTemplate.Height = 50;
            dataGridmain.DataSource = SyukkoDspHidden.ToList();

            dataGridmain.Columns[0].Width = 150;
            dataGridmain.Columns[1].Width = 200;
            dataGridmain.Columns[2].Width = 200;
            dataGridmain.Columns[3].Width = 200;
            dataGridmain.Columns[4].Width = 250;
            dataGridmain.Columns[5].Width = 350;
            dataGridmain.Columns[6].Visible = false;
            dataGridmain.Columns[7].Width = 100;
            dataGridmain.Columns[8].Visible = false;

            dataGridmain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridmain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            dataGridmain.Refresh();
        }
        private void checkHiddenToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkHiddenToggle.Checked)
            {
                buttonUnHide.Visible = false;
                button1.Visible = true;
                SetMainView();
            }
            else
            {
                button1.Visible = false;
                buttonUnHide.Visible = true;
                SetMainHiddenView();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (groupBoxHider.Visible == false)
            {
                groupBoxHider.Visible = true;
                richTextHideReason.Visible = true;
                panelHide.Visible = true;
                buttonHidCo.Visible = true;
                buttonHidCa.Visible = true;
                label21.Visible = false;
                panelHideConfirm.Visible = false;
                buttonYes.Visible = false;
                buttonNo.Visible = false;
            }
            else
            {
                groupBoxHider.Visible = false;
                richTextHideReason.Visible = false;
                buttonHidCo.Visible = false;
                buttonHidCa.Visible = false;
                panelHide.Visible = false;
                label21.Visible = false;
                panelHideConfirm.Visible = false;
                buttonYes.Visible = false;
                buttonNo.Visible = false;
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            T_Warehousing warehousing = new T_Warehousing()
            {
                WaID = obtainedID,
                WaHidden = richTextHideReason.Text,
                WaFlag = 1
            };
            warehousingAccess.BravoSixGoingDark(warehousing);
            groupBoxHider.Visible = false;
            richTextHideReason.Text = "";
        }

        private void buttonHidCa_Click_1(object sender, EventArgs e)
        {
            groupBoxHider.Visible = false;

        }

        private void buttonUnHide_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("表示化させますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            warehousingAccess.SnapBackToReality(obtainedID);


        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridmain.RowCount > 0)
            {
                var context = new SalesManagement_DevContext();
                groupBoxDesc.Text = "入庫" + dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[0].Value.ToString().PadLeft(6, '0');
                labelWaID.Text = "[ID: " + dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[1].Value.ToString() + "] 入庫順: " + dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[2].Value.ToString();
                labelEmName.Text = "[ID: " + dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[3].Value.ToString() + "]  社員名　　: " + dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[4].Value.ToString();
                labelHaID.Text = "[ID: " + dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[5].Value.ToString() + "]  発注順　　: " + dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[6].Value.ToString();
                DateTime getdate = Convert.ToDateTime(dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[8].Value.ToString());
                labelWaDate.Text = getdate.ToString("yyyy年MM月dd日") + " 入庫に";
                button1.Visible = true;
                buttonUnHide.Visible = false;
                LoadDetailGrid();
                obtainedID = int.Parse(dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[0].Value.ToString());
                int counting = context.T_SyukkoDetails.Count(x => x.SyID == obtainedID);
                context.Dispose();
                if (checkHiddenToggle.Checked)
                {
                    richTextDescHide.Text = dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[13].Value.ToString();
                    checkWaShelfFlag.Checked = Convert.ToBoolean(dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[10].Value);
                    checkWaHide.Checked = Convert.ToBoolean(dataGridmain.Rows[dataGridmain.CurrentRow.Index].Cells[12].Value);
                    button1.Visible = false;
                    buttonUnHide.Visible = true;

                }
                else
                {
                    if (!IsEditMode)
                    {
                        buttonCoWa.Enabled = true;

                    }
                    if (counting == 0)
                        buttonCoWa.Enabled = false;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("表示化させますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            warehousingAccess.SnapBackToReality(obtainedID);
            CancelThing();
        }
        private void CancelThing()
        {
            label21.Visible = false;
            panelHideConfirm.Visible = false;
            richTextHideReason.Enabled = true;
            panelHide.Enabled = true;
            groupBoxHider.Visible = false;

            panel1.Enabled = true;
        }

        private void dataGridDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void U_Warehousing_Load(object sender, EventArgs e)
        {

        }
    }
}

