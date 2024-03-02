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
    public partial class U_Hattyu : UserControl
    {
        //データベース注文テーブルアクセス用クラスのインスタンス化
        HattyuAccess hattyuAccess = new HattyuAccess();
        //          メーカー
        MakerAccess makerAccess = new MakerAccess();
        //          社員 
        EmployeeAccess employeeAccess = new EmployeeAccess();
        //          商品
        ProductAccess productAccess = new ProductAccess();

        //グリッドビュー用の発注データ
        private static List<T_HattyuDsp> HattyuDsp;
        //いつか使うかもしれない発注
        private static List<T_Hattyu> Hattyu;
        //グリッドビュー用の注文詳細データ
        private static List<T_HattyuDetailDsp> HattyuDetailDsp;
        //
        private static List<T_HattyuDspHidden> HattyuDspHidden;
        //いつか使うかもしれない発注詳細
        private static List<T_HattyuDetail> HattyuDetail;
        //                メーカ
        private static List<M_MakerCombo> Makers;
        //                社員
        private static List<M_EmployeeCombo> Employees;
        //                商品
        private static List<M_ProductDsp> Products;

        bool NO = true;
        bool IsEditMode = false;
        int obtainedID = 0;
        public U_Hattyu()
        {
            InitializeComponent();
        }

        private void U_Hattyu_Load(object sender, EventArgs e)
        {
            groupBoxHider.Visible = false;
            panelOp.Visible = false;
            groupBoxHider.Visible = false;
            buttonCoHa.Enabled = false;
            buttonEditHa.Enabled = false;
            buttonOK.Enabled = false;
            ContainerVA.Panel2Collapsed = true;
            comboSearchCa.SelectedIndex = 0;
            comboSearchCa.DropDownStyle = ComboBoxStyle.DropDownList;
            Clock.Start();
            LoadMainGrid();
            ProductSelectionView();
            panelOp.Visible = false;
            LoadUser();
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
        // 機能　　　:発注データの取得
        private void LoadMainData()
        {
            HattyuDsp = hattyuAccess.GetHattyuDisplay();

            SetMainView();
        }

        // メソッド名:SetMainView()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:発注データの表示
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = HattyuDsp.ToList();

            dataGridMain.Columns[0].Width = 150;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 300;
            dataGridMain.Columns[3].Visible = false;
            dataGridMain.Columns[4].Width = 450;
            dataGridMain.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
        }

        private void SetMainHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = HattyuDspHidden.ToList();

            dataGridMain.Columns[0].Width = 150;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 300;
            dataGridMain.Columns[3].Visible = false;
            dataGridMain.Columns[4].Width = 450;
            dataGridMain.Columns[5].Width = 350;
            dataGridMain.Columns[6].Visible = false;
            dataGridMain.Columns[7].Width = 100;
            dataGridMain.Columns[8].Visible = false;
            dataGridMain.Columns[9].Width = 100;
            dataGridMain.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            dataGridMain.Refresh();
        }

        private void SetMainHidd()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = HattyuDspHidden.ToList();

            dataGridMain.Columns[0].Width = 150;
            dataGridMain.Columns[1].Width = 200;
            dataGridMain.Columns[2].Width = 200;
            dataGridMain.Columns[3].Width = 200;
            dataGridMain.Columns[4].Width = 250;
            dataGridMain.Columns[5].Width = 350;
            dataGridMain.Columns[6].Visible = false;
            dataGridMain.Columns[7].Width = 100;
            dataGridMain.Columns[8].Visible = false;
            dataGridMain.Columns[9].Width = 100;
            dataGridMain.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            dataGridMain.Refresh();
        }

        // メソッド名:ProductSelectionView()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:選択された商品の表示
        private void ProductSelectionView()
        {
            dataGridSelectedPro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSelectedPro.AllowUserToAddRows = false;
            dataGridSelectedPro.ColumnCount = 4;
            dataGridSelectedPro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSelectedPro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridSelectedPro.Columns[0].Width = 150;
            dataGridSelectedPro.Columns[1].Width = 150;
            dataGridSelectedPro.Columns[1].Width = 150;
            dataGridSelectedPro.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridSelectedPro.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSelectedPro.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSelectedPro.Columns[0].HeaderText = "商品ID";
            dataGridSelectedPro.Columns[1].HeaderText = "商品名";
            dataGridSelectedPro.Columns[2].HeaderText = "数量";
            dataGridSelectedPro.Columns[3].HeaderText = "合計金額";
            dataGridSelectedPro.Columns[0].ReadOnly = true;
            dataGridSelectedPro.Columns[1].ReadOnly = true;
            dataGridSelectedPro.Columns[3].ReadOnly = true;
            dataGridSelectedPro.Refresh();
        }
        private void LoadCombo()
        {
            MakerAccess makerAccess = new MakerAccess();
            List<M_MakerCombo> Maker = makerAccess.GetMakerCombo();
            comboMa.DisplayMember = "Display";
            comboMa.ValueMember = "Value";
            comboMa.DataSource = Maker;
            //メーカの数が10を超えたとき
            if (comboMa.Items.Count > 10)
            {
                comboMa.DropDownStyle = ComboBoxStyle.DropDown;
                comboMa.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboMa.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            EmployeeAccess employeeAccess = new EmployeeAccess();
            List<M_EmployeeCombo> Employee = employeeAccess.GetEmployeeCombo(D_LoginData.SoID);
            comboEm.DisplayMember = "Display";
            comboEm.ValueMember = "Value";
            comboEm.DataSource = Employee;
            //社員の数が10を超えたとき
            if (comboEm.Items.Count > 10)
            {
                comboEm.DropDownStyle = ComboBoxStyle.DropDown;
                comboEm.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboEm.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }
        private void buttonAddHa_Click(object sender, EventArgs e)
        {
            LoadCombo();
            ContainerVA.Panel1Collapsed = true;
            ContainerVA.Panel2Collapsed = false;
            ContainerButton.Enabled = false;
        }

        private void buttonEditHa_Click(object sender, EventArgs e)
        {

        }

        // メソッド名:HideMatching()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:すでに入ってある商品リストと商品DBからの商品リストがかぶらないようにする
        private void HideMatching()
        {
            var context = new SalesManagement_DevContext();
            for (int i = 0; i < dataGridDetail.Rows.Count; i++)
            {
                int index = dataGridSelectedPro.Rows.Add();
                dataGridSelectedPro.Rows[index].Cells[0].Value = dataGridDetail.Rows[i].Cells[0].Value;
                dataGridSelectedPro.Rows[index].Cells[1].Value = dataGridDetail.Rows[i].Cells[1].Value;
                dataGridSelectedPro.Rows[index].Cells[2].Value = dataGridDetail.Rows[i].Cells[4].Value;
                dataGridSelectedPro.Rows[index].Cells[3].Value = dataGridDetail.Rows[i].Cells[5].Value;
                string a = dataGridSelectedPro.Rows[index].Cells[0].Value.ToString();
                for (int j = 0; j < dataGridPro.Rows.Count; j++)
                {
                    string b = dataGridPro.Rows[j].Cells[0].Value.ToString();
                    if (a == b)
                    {
                        CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridPro.DataSource];
                        currencyManager.SuspendBinding();
                        dataGridPro.Rows[j].Visible = false;
                        currencyManager.ResumeBinding();
                    }
                }
            }
            PayPayTotal();
        }

        // キャンセルボタンを押したときのメソッド
        private void buttonAddCa_Click(object sender, EventArgs e)
        {

        }

        //メソッド名:buttonNext_Click()
        // 引　数  :なし
        // 戻り値　:なし
        // 機能　　:発注データの登録と詳細画面への移動
        private void buttonNext_Click(object sender, EventArgs e)
        {
            SalesManagement_DevContext context = new SalesManagement_DevContext();
            var dt = DateTime.Now;
            T_Hattyu Hattyu= new T_Hattyu()
            {
                MaID = int.Parse(comboMa.SelectedValue.ToString()),
                EmID = int.Parse(comboEm.SelectedValue.ToString()),
                HaDate = dt.Date,

                WaWarehouseFlag = 0,
                HaFlag = 0,
                HaHidden = ""
            };
            context.T_Hattyus.Add(Hattyu);
            context.SaveChanges();
            obtainedID = Hattyu.HaID;
            context.Dispose();
            ContainerButton.Visible = false;
            ContainerMain.Visible = false;
            panelOp.Visible = true;
            LoadProducts();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (!IsEditMode)
            {
                //GenerateOrder();
                GenerateDetails();
            }
            else GenerateModifyDetails();
            ClosePanel3();
        }

        private void ClosePanel3()
        {
            NO = true;
            panelOp.Visible = false;
            panelSearch.Enabled = true;
            buttonAddHa.Enabled = true;
            buttonEditHa.Enabled = true;
            buttonCoHa.Enabled = true;
            comboMa.DataSource = null;
            comboEm.DataSource = null;
            dataGridSelectedPro.Rows.Clear();
            if (!checkHiddenToggle.Checked) GenerateFilter();
            else GenerateHiddenFilter();
            dataGridMain.Refresh();
            LoadDetailGrid();
        }

        private void GenerateDetails()
        {
            for (int i = 0; i < dataGridSelectedPro.Rows.Count; i++)
            {
                int prID = int.Parse(dataGridSelectedPro.Rows[i].Cells[0].Value.ToString());
                int haQuantity = int.Parse(dataGridSelectedPro.Rows[i].Cells[2].Value.ToString());
                int haTotalPrice = int.Parse(dataGridSelectedPro.Rows[i].Cells[3].Value.ToString());
                T_HattyuDetail hattyuDetail = new T_HattyuDetail()
                {
                    HaID = obtainedID,
                    PrID = prID,
                    HaQuantity = haQuantity,
                    HaTotalPrice = haTotalPrice
                };
                hattyuAccess.CreateDetails(hattyuDetail);
            }
        }

        private void GenerateModifyDetails()
        {
            var context = new SalesManagement_DevContext();
            var haID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            int countDB = context.T_HattyuDetails.Count(x => x.HaID == haID); int temp = countDB;
            int countDG = dataGridSelectedPro.Rows.Count;
            int countDD = dataGridDetail.Rows.Count;
            int id = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            context.Dispose();
            if (countDB == 0)
                GenerateDetails();
            else if (countDG < countDB)
            {
                hattyuAccess.DeleteDetails(id);
                GenerateDetails();
            }
            else
            {
                for (int i = 0; i < countDG; i++)
                {
                    int haDetailID = 0;
                    int haID1 = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                    int prID = int.Parse(dataGridSelectedPro.Rows[i].Cells[0].Value.ToString());
                    if (countDD > i) haDetailID = int.Parse(dataGridDetail.Rows[i].Cells[0].Value.ToString());
                    int haQuantity = int.Parse(dataGridSelectedPro.Rows[i].Cells[2].Value.ToString());
                    int haTotalPrice = int.Parse(dataGridSelectedPro.Rows[i].Cells[3].Value.ToString());
                    T_HattyuDetail hattyuDetail = new T_HattyuDetail()
                    {
                        HaID = haID1,
                        HaDetailID = haDetailID,
                        PrID = prID,
                        HaQuantity = haQuantity,
                        HaTotalPrice = haTotalPrice
                    };
                    if (countDB > i) hattyuAccess.ModifyDetails(hattyuDetail);
                    else if (countDB <= i) hattyuAccess.CreateDetails(hattyuDetail);
                }
            }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            groupBoxHider.Visible = true;
            richTextHideReason.Focus();
        }

        private void buttonUnHide_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("非表示化を解除しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                T_Hattyu hattyu = new T_Hattyu()
                {
                    HaID = obtainedID,
                    HaFlag = 0
                };
                hattyuAccess.SnapBackToReality(hattyu);
                HattyuDspHidden = hattyuAccess.GetHattyuHiddenDisplay();
                ClosePanel3();
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void buttonCoHa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("発注しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                var context = new SalesManagement_DevContext();
                var p = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString();
                int maID = context.M_Makers.Single(x => x.MaName == p).MaID;
                p = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[3].Value.ToString();
                int emID = context.M_Employees.Single(x => x.EmName == p).EmID;
                p = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString();
                int haID = int.Parse(p);
                T_Hattyu table = new T_Hattyu()
                {
                    HaID = haID,
                    MaID = maID,
                    EmID = emID
                };
                hattyuAccess.KingsCross(table);
                var complete = context.T_Hattyus.Single(x => x.HaID == haID);
                complete.WaWarehouseFlag = 1;
                context.SaveChanges();
                context.Dispose();
                GenerateFilter();
            }
        }

        private void LoadComboEms(int op)
        {
            int a;
            bool MaID = int.TryParse(comboMa.SelectedValue.ToString(), out a);
            if (MaID == false) { }
            Employees = employeeAccess.GetEmployeeCombo(Convert.ToInt32(comboMa.SelectedValue));
            comboEm.DataSource = Employees;
            comboEm.DisplayMember = "EmName";
            comboEm.ValueMember = "EmID";
            if (op == 1)
                comboEm.SelectedIndex = -1;
            else if (op == 0)
            {
                var context = new SalesManagement_DevContext();
                string Em = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[2].Value.ToString();
                comboEm.SelectedValue = Int32.Parse(context.M_Employees.Single(x => x.EmName.Contains(Em)).EmID.ToString());
                context.Dispose();
            }

            if (comboEm.Items.Count >= 10)
            {
                comboEm.DropDownStyle = ComboBoxStyle.DropDown;
                comboEm.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboEm.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
                comboEm.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboMaker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NO == false)
            {
                NO = true;
                comboEm.DataSource = null;
                comboEm.Enabled = false;
                comboEm.Enabled = true;
                comboEm.SelectedIndex = -1;
                LoadComboEms(1);
                NO = false;
                comboEm.Focus();
            }
        }

        private void comboEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NO == false)
            {
                NO = true;
                comboMa.Enabled = true;
                comboMa.Focus();
                NO = false;
            }
        }

        private void dataGridmain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMain.RowCount > 0)
            {
                var context = new SalesManagement_DevContext();
                groupBoxDesc.Text = "発注 " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString().PadLeft(6, '0');
                var p = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString();
                labelMaID.Text = "[ID: " + context.M_Makers.Single(x => x.MaName == p).MaID.ToString() + "]  メーカ名: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString();
                p = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[2].Value.ToString();
                labelEmID.Text = "[ID: " + context.M_Employees.Single(x => x.EmName == p).EmID.ToString() + "]  社員名　　: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[2].Value.ToString();
                p = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[3].Value.ToString();
                DateTime getdate = Convert.ToDateTime(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[5].Value.ToString());
                labelHaDate.Text = getdate.ToString("yyyy年MM月dd日") + " に発注";
                LoadDetailGrid();
                context.Dispose();
                if (checkHiddenToggle.Checked)
                {
                    richTextDescHide.Text = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[10].Value.ToString();
                    checkWarehouseFlag.Checked = Convert.ToBoolean(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[7].Value);
                    checkHaHide.Checked = Convert.ToBoolean(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[9].Value);
                    if (checkWarehouseFlag.Checked) { buttonEditHa.Enabled = false; buttonCoHa.Enabled = false; }
                    else { buttonEditHa.Enabled = true; }
                }
                else
                {
                    if (!IsEditMode)
                    {
                        buttonCoHa.Enabled = true;
                        buttonEditHa.Enabled = true;
                    }
                }
                obtainedID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            }
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
            HattyuDetailDsp = hattyuAccess.GetHattyuDetail(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            SetDetailView();
        }

        private void SetDetailView()
        {
            dataGridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridDetail.RowTemplate.Height = 50;
            dataGridDetail.DataSource = HattyuDetailDsp;
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

        private void LoadProducts()
        {
            int MaID = int.Parse(comboMa.SelectedValue.ToString());
            Products = productAccess.GetProductByMa(MaID);
            dataGridPro.DataSource = Products;
            SetProductView();
        }

        private void SetProductView()
        {
            //行ごと選択
            dataGridPro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //
            dataGridPro.AllowUserToAddRows = false;
            //読み取り専用
            dataGridPro.ReadOnly = true;
            //ヘッダー位置の指定
            dataGridPro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridPro.Columns[0].Width = 100;
            dataGridPro.Columns[1].Visible = false;
            dataGridPro.Columns[2].Visible = false;
            dataGridPro.Columns[3].Width = 200;
            dataGridPro.Columns[4].Width = 200;
            dataGridPro.Columns[5].Visible = false;
            dataGridPro.Columns[6].Visible = false;
            dataGridPro.Columns[7].Visible = false;
            dataGridPro.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridPro.Columns[9].Visible = false;
            dataGridPro.Columns[10].Visible = false;
            dataGridPro.Columns[11].Visible = false;

            dataGridPro.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPro.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPro.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPro.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPro.Refresh();
        }

        private void buttonPrClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridPro.Rows.Count; i++)
            {
                if (dataGridPro.Rows[i].Visible == false)
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridPro.DataSource];
                    currencyManager.SuspendBinding();
                    dataGridPro.Rows[i].Visible = true;
                    currencyManager.ResumeBinding();
                }
            }
            dataGridSelectedPro.Rows.Clear();
            labelTotal.Text = "¥0";
        }

        private void dataGridPro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridPro.CurrentRow.Index;
            int index = dataGridSelectedPro.Rows.Add();
            dataGridSelectedPro.Rows[index].Cells[0].Value = dataGridPro.Rows[i].Cells[0].Value;
            dataGridSelectedPro.Rows[index].Cells[1].Value = dataGridPro.Rows[i].Cells[3].Value;
            dataGridSelectedPro.Rows[index].Cells[2].Value = 1;
            ((DataGridViewTextBoxColumn)dataGridSelectedPro.Columns[index]).MaxInputLength = 4;
            dataGridSelectedPro.Rows[index].Cells[3].Value = dataGridPro.Rows[i].Cells[4].Value;
            PayPayTotal();
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridPro.DataSource];
            currencyManager.SuspendBinding();
            dataGridPro.Rows[i].Visible = false;
            currencyManager.ResumeBinding();
            buttonOK.Enabled = true;
        }

        private void dataGridSelectedPro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string b = dataGridSelectedPro.Rows[dataGridSelectedPro.CurrentRow.Index].Cells[1].Value.ToString();
            for (int i = 0; i < dataGridPro.Rows.Count; i++)
            {
                string a = dataGridPro.Rows[i].Cells[2].Value.ToString();
                if (dataGridPro.Rows[i].Visible == false && a == b)
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridPro.DataSource];
                    currencyManager.SuspendBinding();
                    dataGridPro.Rows[i].Visible = true;
                    currencyManager.ResumeBinding();
                    dataGridSelectedPro.Rows.RemoveAt(dataGridSelectedPro.CurrentRow.Index);
                }
            }
            PayPayTotal();
            if (dataGridSelectedPro.Rows.Count <= 0)
                buttonOK.Enabled = false;
        }

        private void dataGridSelectedPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSelectedPro.RowCount > 0)
            {
                dataGridSelectedPro.CurrentCell = dataGridSelectedPro.Rows[dataGridSelectedPro.CurrentRow.Index].Cells[2];
                dataGridSelectedPro.BeginEdit(true);
            }
        }

        private void dataGridSelectedPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void dataGridSelectedPro_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            if (tb != null)
                tb.KeyPress += new KeyPressEventHandler(dataGridSelectedPro_KeyPress);
        }

        private void dataGridSelectedPro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            dataGridSelectedPro.KeyPress += new KeyPressEventHandler(dataGridSelectedPro_KeyPress);
        }

        private void dataGridSelectedProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string b = dataGridSelectedPro.Rows[dataGridSelectedPro.CurrentRow.Index].Cells[1].Value.ToString();
            int c = dataGridSelectedPro.CurrentRow.Index;
            try
            {
                for (int i = 0; i < dataGridPro.Rows.Count; i++)
                {
                    string a = dataGridPro.Rows[i].Cells[2].Value.ToString();
                    if (a == b && dataGridSelectedPro.Rows[c].Cells[2].Value != null)
                    {
                        int x = int.Parse(dataGridPro.Rows[i].Cells[3].Value.ToString());
                        int y = int.Parse(dataGridSelectedPro.Rows[c].Cells[2].Value.ToString());
                        dataGridSelectedPro.Rows[c].Cells[3].Value = x * y;
                    }
                    else if (dataGridSelectedPro.Rows[c].Cells[2].Value == null)
                        dataGridSelectedPro.Rows[c].Cells[2].Value = 1;
                }
                PayPayTotal();
            }
            catch { dataGridSelectedPro.Rows[c].Cells[2].Value = 1; }
        }
        // メソッド名:PayPayTotal()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:選択した商品の合計を出力
        private void PayPayTotal()
        {
            int Total = 0;
            for (int i = 0; i < dataGridSelectedPro.Rows.Count; i++)
            {
                Total += int.Parse(dataGridSelectedPro.Rows[i].Cells[3].Value.ToString());
            }
            labelTotal.Text = "¥" + Total.ToString("#,##0");
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {

        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
           // Lever();
        }

        private void buttonHidCa_Click(object sender, EventArgs e)
        {
            //Lever();
        }

        //private void Lever()
        //{
        //    bool set = (panelHideConfirm.Visible == false) ? panelHideConfirm.Visible = true : panelHideConfirm.Visible = false;
        //    set = (label21.Visible == false) ? label21.Visible = true : label21.Visible = false;
        //    set = (panelHide.Visible == true) ? panelHide.Visible = false : panelHide.Visible = true;
        //    set = (richTextHideReason.Enabled == true) ? richTextHideReason.Enabled = false : richTextHideReason.Enabled = true;
        //}

        private void GenerateFilter()
        {
            var context = new SalesManagement_DevContext();
            int a = comboSearchCa.SelectedIndex;
            var b = textBoxSearch.Text;
            bool valid = int.TryParse(textBoxSearch.Text.Trim(), out var c);
            T_HattyuDsp search = new T_HattyuDsp();
            switch (a)
            {
                case 0:
                    {
                        search = new T_HattyuDsp()
                        {
                            MaName = b,
                            EmName = b,
                        };
                    }
                    break;
                case 1:
                    search = new T_HattyuDsp() { MaName = b };
                    break;
                case 2:
                    search = new T_HattyuDsp() { MaName = b };
                    break;
                case 3:
                    search = new T_HattyuDsp() { EmName = b };
                    break;
            }
            if (!SearchAsDate.Checked) HattyuDsp = hattyuAccess.WhereAreYou(search, a);
            else HattyuDsp = hattyuAccess.WhenAndWhere(search, dateTimeFrom.Value, dateTimeTo.Value, a);
            if (string.IsNullOrEmpty(textBoxSearch.Text)) HattyuDsp = hattyuAccess.GetHattyuDisplay();
            if (string.IsNullOrEmpty(textBoxSearch.Text) && SearchAsDate.Checked) HattyuDsp = hattyuAccess.When(dateTimeFrom.Value, dateTimeTo.Value);
            dataGridMain.DataSource = HattyuDsp;
            SetMainView();
        }

        private void GenerateHiddenFilter()
        {
            var context = new SalesManagement_DevContext();
            int a = comboSearchCa.SelectedIndex;
            var b = textBoxSearch.Text;
            bool valid = int.TryParse(textBoxSearch.Text.Trim(), out var c);
            T_HattyuDspHidden search = new T_HattyuDspHidden();
            switch (a)
            {
                case 0:
                    {

                        search = new T_HattyuDspHidden()
                        {
                            MaName = b,
                            EmName = b,
                        };
                    }
                    break;
                case 1:
                    search = new T_HattyuDspHidden() { MaName = b };
                    break;
                case 2:
                    search = new T_HattyuDspHidden() { MaName = b };
                    break;
                case 3:
                    search = new T_HattyuDspHidden() { EmName = b };
                    break;
            }
            if (!SearchAsDate.Checked) HattyuDspHidden = hattyuAccess.WhereAreYouHiding(search, a);
            else HattyuDspHidden = hattyuAccess.WhenAndWhereHiding(search, dateTimeFrom.Value, dateTimeTo.Value, a);
            if (string.IsNullOrEmpty(textBoxSearch.Text)) HattyuDsp = hattyuAccess.GetHattyuDisplay();
            if (string.IsNullOrEmpty(textBoxSearch.Text) && SearchAsDate.Checked) HattyuDsp = hattyuAccess.When(dateTimeFrom.Value, dateTimeTo.Value);
            dataGridMain.DataSource = HattyuDspHidden;
            SetMainHiddenView();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!checkHiddenToggle.Checked) GenerateFilter();
            else GenerateHiddenFilter();
        }

        private void comboSearchCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkHiddenToggle.Checked) GenerateFilter();
            else GenerateHiddenFilter();
        }

        private void SearchAsDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkHiddenToggle.Checked) GenerateFilter();
            else GenerateHiddenFilter();
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            if (SearchAsDate.Checked == true)
            {
                if (!checkHiddenToggle.Checked) GenerateFilter();
                else GenerateHiddenFilter();
            }
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            if (SearchAsDate.Checked == true)
            {
                if (!checkHiddenToggle.Checked) GenerateFilter();
                else GenerateHiddenFilter();
                GenerateFilter();
            }
        }

        private void checkHiddenToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkHiddenToggle.Checked) { SetMainView(); checkWarehouseFlag.Checked = false; checkHaHide.Checked = false; GenerateFilter(); }
            else { HattyuDspHidden = hattyuAccess.GetHattyuHiddenDisplay(); SetMainHiddenView(); GenerateHiddenFilter(); }
        }
    }
}