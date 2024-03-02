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
    public partial class F_Sales : Form
    {
        //
        SalesAccess salesAccess = new SalesAccess();
        //
        private static List<T_SaleDsp> saleDsp;
        //
        private static List<T_SaleDetailDsp> saleDetailDsp;
        //
        public F_Sales()
        {
            InitializeComponent();
        }

        private void F_Sales_Load(object sender, EventArgs e)
        {
            foreach(Control p in ChartView.Controls)
            {
                p.Font = new Font("UD Digi Kyokasho NK-B", 24);
            }
            Clock.Start();
            LoadUser();
            LoadMainGrid();
            comboSearchCa.SelectedIndex = 0;
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
                if (Pos[2] != "R")
                    this.Close();
            }
        }
        private void LoadMainGrid()
        {
            dataGridMain.ReadOnly = true;
            dataGridDetail.ReadOnly = true;
            //行ごと選択
            dataGridMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー位置の指定
            dataGridMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データ取得
            LoadMainData();
        }
        private void LoadMainData()
        {
            saleDsp = salesAccess.GetSaleDisplay();

            SetMainView();
        }
        private void LoadDetailData(int ID)
        {
            saleDetailDsp = salesAccess.GetSaleDetailDisplay(ID);

            SetDetailView();
        }
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = saleDsp.ToList();

            dataGridMain.Columns[0].Width = 100;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Visible = false;
            dataGridMain.Columns[3].Visible = false;
            dataGridMain.Columns[4].Width = 150;
            dataGridMain.Columns[5].Visible = false;
            dataGridMain.Columns[6].Width = 150;
            dataGridMain.Columns[7].Visible = false;
            dataGridMain.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
        }
        private void SetDetailView()
        {
            dataGridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridDetail.RowTemplate.Height = 50;
            dataGridDetail.DataSource = saleDetailDsp.ToList();

            dataGridDetail.Columns[0].Width = 100;
            dataGridDetail.Columns[1].Visible = false;
            dataGridDetail.Columns[2].Visible = false;
            dataGridDetail.Columns[3].Width = 150;
            dataGridDetail.Columns[4].Width = 150;
            dataGridDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void buttonBacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridMain.Rows.Count > 0)
            {
                int i = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                LoadDetailData(i);
                ChartView.Series["SaPr"].XValueMember = "PrName";
                ChartView.Series["SaPr"].YValueMembers = "SaQuantity";
                ChartView.DataSource = saleDetailDsp;
                if (ChartView.Titles.Count == 0)
                    ChartView.Titles.Add("売上：" + i.ToString());
                else
                    ChartView.Titles[0].Text = ("売上：" + i.ToString());
                ChartView.Titles[0].Font = new Font("UD Digi Kyokasho NK-B", 22);
                labelEm.Text = "受注社員：" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[6].Value.ToString();
                labelCl.Text = "顧客　　　 ：" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[2].Value.ToString();
                labelSo.Text = "営業所   ：" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[4].Value.ToString();
                labelChID.Text = "注文ID：" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[7].Value.ToString();
                SetPosition();
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void checkBoxPrice_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPrice.Checked)
                ChartView.Series["SaPr"].YValueMembers = "SaPrTotalPrice";
            else
                ChartView.Series["SaPr"].YValueMembers = "SaQuantity";
            checkBoxNum_CheckedChanged(sender, e);
        }

        private void checkBoxNum_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNum.Checked)
                ChartView.Series["SaPr"].IsValueShownAsLabel = true;
            else
                ChartView.Series["SaPr"].IsValueShownAsLabel = false;
        }
        private void GenerateFilter(object sender,EventArgs e)
        {
            int type = comboSearchCa.SelectedIndex;
            saleDsp = salesAccess.Search(textBoxSearch.Text, type, SearchAsDate.Checked, dateTimeFrom.Value.Date, dateTimeTo.Value.Date);
            SetMainView();
            dataGridDetail.DataSource = null;
            dataGridDetail.Rows.Clear();
        }
    }
}
