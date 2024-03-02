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
    public partial class F_Syukko : Form
    {
        //データベース注文テーブルアクセス用クラスのインスタンス化
        SyukkoAccess syukkoAccess = new SyukkoAccess();
        //          顧客
        ClientAccess clientAccess = new ClientAccess();

        //出庫データ
        private static List<T_SyukkoDsp> SyukkoDsp;
        //出庫非表示データ
        private static List<T_SyukkoDspHidden> SyukkoDspHidden;
        //グリッドビュー用の注文詳細データ
        private static List<T_SyukkoDetailDsp> SyukkoDetailDsp;
        int obtainedID = 0;
        public F_Syukko()
        {
            InitializeComponent();
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
            SyukkoDsp = syukkoAccess.GetSyukkoDisplay();

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
            dataGridMain.DataSource = SyukkoDsp.ToList();

            dataGridMain.Columns[0].Width = 150;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 300;
            dataGridMain.Columns[3].Visible = false;
            dataGridMain.Columns[4].Width = 300;
            dataGridMain.Columns[5].Visible = false;
            dataGridMain.Columns[6].Width = 450;
            dataGridMain.Columns[7].Width = 300;
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
            SyukkoDetailDsp = syukkoAccess.GetSyukkoDetail(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            SetDetailView();
        }
        private void SetDetailView()
        {
            dataGridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridDetail.RowTemplate.Height = 50;
            dataGridDetail.DataSource = SyukkoDetailDsp;
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
        private void F_Syukko_Load(object sender, EventArgs e)
        {
            groupBoxHider.Visible = false;
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
                if (Pos[12] == "R")
                { buttonHide.Enabled = false; buttonUnHide.Enabled = false; buttonCoOr.Enabled = false; }
                else if (Pos[12] == "RW") { }
                else this.Enabled = false;
            }
        }
        private void buttonBacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }
        private void Sweeper()
        {
            checkHide.Checked = false;
            checkAr.Checked = false;
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
                labelDisplayTotal.Text = "\0";
                groupBoxDesc.Text = "出庫000000";
                checkAr.Checked = false;
                checkHide.Checked = false;
                buttonCoOr.Enabled = false;
                buttonHide.Enabled = false;
                buttonUnHide.Enabled = false;
                dataGridDetail.DataSource = null;
                dataGridDetail.Rows.Clear();
            }
        }
        private void buttonCoOr_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("出庫しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                var context = new SalesManagement_DevContext();
                int soID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString());
                int clID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[5].Value.ToString());
                int syID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                int orID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[7].Value.ToString());
                T_Syukko table = new T_Syukko()
                {
                    SyID = syID,
                    ClID = clID,
                    SoID=soID,
                    OrID = orID
                };
                syukkoAccess.KingsCross(table);
                var complete = context.T_Syukkos.Single(x => x.SyID == syID);
                complete.SyStateFlag = 1;
                complete.SyDate = DateTime.Now.Date;
                complete.EmID = D_LoginData.EmID;
                context.SaveChanges();
                context.Dispose();
                GenerateFilter(sender, e);
                buttonCoOr.Enabled = false;
            }
        }

        private void buttonHidCo_Click(object sender, EventArgs e)
        {

            richTextHideReason.Visible = false;
            buttonHidCo.Visible = false;
            buttonHidCa.Visible = false;
            panelHide.Visible = false;
        }

        private void buttonBacc_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetMainHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = SyukkoDspHidden.ToList();

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
        private void checkHiddenToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkHiddenToggle.Checked)
            {
                buttonUnHide.Visible = false;
                buttonHide.Visible = true;
                SetMainView();
            }
            else
            {
                buttonHide.Visible = false;
                buttonUnHide.Visible = true;
                SyukkoDspHidden = syukkoAccess.GetSyukkoHiddenDisplay();
                SetMainHiddenView();
            }
        }
        private void buttonUnHide_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("出庫 :" + obtainedID +"を復元しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            { syukkoAccess.SnapBackToReality(obtainedID); buttonUnHide.Enabled = false; GenerateFilter(sender, e); }
        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMain.RowCount > 0)
            {
                var context = new SalesManagement_DevContext();
                groupBoxDesc.Text = "出庫" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString().PadLeft(6, '0');
                labelSoID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString() + "] 営業所名: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[2].Value.ToString();
                labelClID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[5].Value.ToString() + "]  顧客名　: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[6].Value.ToString();
                labelOrID.Text = "[受注ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[7].Value.ToString() + "]";
                LoadDetailGrid();
                obtainedID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                int counting = context.T_SyukkoDetails.Count(x => x.SyID == obtainedID);
                context.Dispose();
                labelEmID.Text = "--";
                labelDate.Text = "--";
                buttonCoOr.Enabled = true;
                if (checkHiddenToggle.Checked)
                {
                    richTextDescHide.Text = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[13].Value?.ToString();
                    checkAr.Checked = Convert.ToBoolean(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[10].Value);
                    checkHide.Checked = Convert.ToBoolean(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[12].Value);
                    if (checkAr.Checked)
                    {
                        labelEmID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[3].Value.ToString() + "]  社員名　　: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[4].Value.ToString();
                        DateTime getdate = Convert.ToDateTime(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[8].Value.ToString());
                        labelDate.Text = getdate.ToString("yyyy年MM月dd日") + " に出庫";
                    }
                    buttonCoOr.Enabled = false;
                }
                else buttonHide.Enabled = true;
                if (checkAr.Checked) { buttonUnHide.Enabled = false; buttonCoOr.Enabled = false; }
                else { buttonUnHide.Enabled = true; }
                SetPosition();
            }
        }

        private void GenerateFilter(object sender, EventArgs e)
        {
            int type = comboSearchCa.SelectedIndex;
            if (!checkHiddenToggle.Checked) { SyukkoDsp = syukkoAccess.DefaultSearch(textBoxSearch.Text, type); buttonHide.Visible = true; buttonUnHide.Visible = false; SetMainView(); }
            else { SyukkoDspHidden = syukkoAccess.HiddenSearch(textBoxSearch.Text, type, SearchAsDate.Checked, dateTimeFrom.Value.Date, dateTimeTo.Value.Date); buttonHide.Visible = false; buttonUnHide.Visible = true; SetMainHiddenView(); }
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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("出庫 :" + obtainedID +"を取り消しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            { syukkoAccess.BravoSixGoingDark(obtainedID, richTextHideReason.Text);
                groupBoxHider.Visible = false;
                richTextHideReason.Text = "";
                buttonHide.Enabled = false;
                GenerateFilter(sender, e); }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            richTextHideReason.Text = null;
            groupBoxHider.Visible = false;
        }
    }
    }
