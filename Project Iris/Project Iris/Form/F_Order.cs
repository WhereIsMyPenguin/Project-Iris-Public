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
    public partial class F_Order : Form
    {
        //データベース注文テーブルアクセス用クラスのインスタンス化
        OrderAccess orderAccess = new OrderAccess();
        //          営業所
        SalesOfficeAccess salesOfficeAccess = new SalesOfficeAccess();
        //          社員 
        EmployeeAccess employeeAccess = new EmployeeAccess();
        //          顧客
        ClientAccess clientAccess = new ClientAccess();
        //          商品
        ProductAccess productAccess = new ProductAccess();

        //グリッドビュー用の受注データ
        private static List<T_OrderDsp> OrderDsp;
        //グリッドビュー用の注文詳細データ
        private static List<T_OrderDetailDsp> OrderDetailDsp;
        //
        private static List<T_OrderDspHidden> OrderDspHidden;
        //                営業所
        private static List<M_SalesOfficeCombo> SalesOffices;
        //                社員
        private static List<M_EmployeeCombo> Employees;
        //                顧客
        private static List<M_ClientCombo> Clients;
        //                商品
        private static List<M_ProductForOrder> Products;
        bool NO = true;
        bool IsEditMode = false;
        int obtainedID = 0;
        public F_Order()
        {
            InitializeComponent();
        }

        private void F_Order_Load(object sender, EventArgs e)
        {
            groupBoxOr.Visible = false;
            panel3.Visible = false;
            groupBoxHider.Visible = false;
            buttonCoOr.Enabled = false;
            buttonEditOr.Enabled = false;
            label21.Visible = false;
            buttonHide.Visible = false;
            buttonUnHide.Visible = false;
            panelHideConfirm.Visible = false;
            buttonAddPr.Enabled = false;
            comboSearchCa.SelectedIndex = 0;
            comboSearchCa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSo.SelectedIndex = -1;
            LoadUser();
            Clock.Start();
            LoadMainGrid();
            ProductSelectionView();
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
                if (Pos[5] == "R")
                { buttonAddOr.Enabled = false; buttonEditOr.Enabled = false; buttonCoOr.Enabled = false; }
                else if (Pos[5] == "RW") { }
                else this.Enabled = false;
            }
        }
        // メソッド名:LoadCombo()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:コンボボックスの内容設定
        private void LoadCombo(int op)
        {
            NO = true;
            //営業所データの取得
            SalesOffices = salesOfficeAccess.GetSalesOfficeCombos();
            //受注登録
            comboSo.DisplayMember = "Display";
            comboSo.ValueMember = "Value";
            comboSo.DataSource = SalesOffices;
            //コンボボックスに検索機能をつける
            if (op == 1)
            {
                comboSo.SelectedIndex = -1;
                comboEm.Enabled = false;
                comboCl.Enabled = false;
                textBoxCharge.Enabled = false;
            }
            else if (op == 0)
            { 
                var context = new SalesManagement_DevContext();
                int i = dataGridMain.CurrentRow.Index;
                comboSo.SelectedValue = dataGridMain.Rows[i].Cells[1].Value.ToString();
                context.Dispose();
                LoadComboEms(0);
                comboEm.Enabled = true;
                LoadComboCls(0);
                comboCl.Enabled = true;
                textBoxCharge.Text = dataGridMain.Rows[i].Cells[4].Value.ToString();
            }
            if (comboSo.Items.Count > 10)
            {
                comboSo.DropDownStyle = ComboBoxStyle.DropDown;
                comboSo.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboSo.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            NO = false;
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
            OrderDsp = orderAccess.GetOrderDisplay();

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
            dataGridMain.DataSource = OrderDsp.ToList();

            dataGridMain.Columns[0].Width = 150;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 300;
            dataGridMain.Columns[3].Visible = false;
            dataGridMain.Columns[4].Width = 300;
            dataGridMain.Columns[5].Visible = false;
            dataGridMain.Columns[6].Width = 300;
            dataGridMain.Columns[7].Width = 450;
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

        private void SetMainHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = OrderDspHidden.ToList();

            dataGridMain.Columns[0].Width = 150;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 200;
            dataGridMain.Columns[3].Visible = false;
            dataGridMain.Columns[4].Width = 200;
            dataGridMain.Columns[5].Visible = false;
            dataGridMain.Columns[6].Width = 200;
            dataGridMain.Columns[7].Visible = false;
            dataGridMain.Columns[8].Width = 250;
            dataGridMain.Columns[9].Visible = false;
            dataGridMain.Columns[10].Width = 100;
            dataGridMain.Columns[11].Visible = false;
            dataGridMain.Columns[12].Width = 100;
            dataGridMain.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridMain.Refresh();
            Sweeper();
        }
        // メソッド名:ProductSelectionView()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:選択された商品の表示
        private void ProductSelectionView()
        {
            dataGridSelectedProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSelectedProduct.AllowUserToAddRows = false;
            dataGridSelectedProduct.ColumnCount = 4;
            dataGridSelectedProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSelectedProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridSelectedProduct.Columns[0].Width = 150;
            dataGridSelectedProduct.Columns[1].Width = 150;
            dataGridSelectedProduct.Columns[1].Width = 150;
            dataGridSelectedProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridSelectedProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSelectedProduct.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSelectedProduct.Columns[0].HeaderText = "商品ID";
            dataGridSelectedProduct.Columns[1].HeaderText = "商品名";
            dataGridSelectedProduct.Columns[2].HeaderText = "数量";
            dataGridSelectedProduct.Columns[3].HeaderText = "合計金額";
            dataGridSelectedProduct.Columns[0].ReadOnly = true;
            dataGridSelectedProduct.Columns[1].ReadOnly = true;
            dataGridSelectedProduct.Columns[3].ReadOnly = true;
            dataGridSelectedProduct.Refresh();
        }
        private void Sweeper()
        {
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
                groupBoxDesc.Text = "受注 000000";
                checkChumon.Checked = false;
                checkHide.Checked = false;
                buttonEditOr.Enabled = false;
                buttonCoOr.Enabled = false;
                buttonHide.Enabled = false;
                buttonUnHide.Enabled = false;
                dataGridDetail.DataSource = null;
                dataGridDetail.Rows.Clear();
            }
        }

        // 登録ボタンを押したときのメソッド
        private void buttonAddOr_Click(object sender, EventArgs e)
        {
            groupBoxOr.Visible = true;
            groupBoxOr.Text = "登録";     
            buttonAddOr.Enabled = false;
            buttonEditOr.Enabled = false;
            buttonCoOr.Enabled = false;
            LoadCombo(1);
            comboSo.SelectedIndex = -1;
            comboSo.Focus();
            buttonHide.Hide();
            buttonAddNext.Show();
            buttonAddNext.Enabled = false;
        }
        // 変更ボタンを押したときのメソッド
        private void buttonEditOr_Click(object sender, EventArgs e)
        {
            buttonHide.Show();
            buttonAddNext.Hide();
            groupBoxOr.Visible = true;
            groupBoxOr.Text = "更新";
            buttonAddOr.Enabled = false;
            buttonEditOr.Enabled = false;
            buttonCoOr.Enabled = false;
            panel1.Enabled = false;
            panel3.Visible = true;
            if (checkHide.Checked)
            { buttonHide.Visible = false; buttonUnHide.Visible = true; }
            if (checkChumon.Checked)
            { buttonUnHide.Enabled = false; }
            else buttonUnHide.Enabled = true;
            IsEditMode = true;
            LoadCombo(0);
            LoadProducts();
            HideMatching();
            int i = dataGridMain.CurrentRow.Index;
            textBoxCharge.Text = dataGridMain.Rows[i].Cells[7].Value.ToString();
            buttonAddPr.Enabled = true;
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
                int index = dataGridSelectedProduct.Rows.Add();
                dataGridSelectedProduct.Rows[index].Cells[0].Value = dataGridDetail.Rows[i].Cells[1].Value;
                dataGridSelectedProduct.Rows[index].Cells[1].Value = dataGridDetail.Rows[i].Cells[2].Value;
                dataGridSelectedProduct.Rows[index].Cells[2].Value = dataGridDetail.Rows[i].Cells[5].Value;
                dataGridSelectedProduct.Rows[index].Cells[3].Value = dataGridDetail.Rows[i].Cells[6].Value;
                string a = dataGridSelectedProduct.Rows[index].Cells[0].Value.ToString();
                for (int j = 0; j < dataGridProduct.Rows.Count; j++)
                {
                    string b = dataGridProduct.Rows[j].Cells[0].Value.ToString();
                    if (a == b)
                    {
                        CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridProduct.DataSource];
                        currencyManager.SuspendBinding();
                        dataGridProduct.Rows[j].Visible = false;
                        currencyManager.ResumeBinding();
                    }
                }
            }
            PayPayTotal();
        }
        // キャンセルボタンを押したときのメソッド
        private void buttonAddCa_Click(object sender, EventArgs e)
        {
            buttonAddOr.Enabled = true;
            buttonEditOr.Enabled = true;
            buttonCoOr.Enabled = true;
            groupBoxOr.Visible = false;
            panel1.Enabled = true;
            if (groupBoxHider.Visible == true)
            { groupBoxHider.Visible = false; groupBoxHider.Text = ""; }
            if(panel3.Visible == true) panel3.Visible = false;
            if(labelSoID.Text == "--")
            {
                buttonCoOr.Enabled = false;
                buttonEditOr.Enabled = false;
            }
            NO = true;
            comboSo.DataSource = null;
            comboCl.DataSource = null;
            comboEm.DataSource = null;
            textBoxCharge.Text = "";
            labelTotal.Text = "¥0";
            buttonAddPr.Enabled = false;
            dataGridSelectedProduct.Rows.Clear();
        }
        // メソッド名:buttonNext_Click()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:受注データの登録と詳細画面への移動
        private void buttonNext_Click(object sender, EventArgs e)
        {
            SalesManagement_DevContext context = new SalesManagement_DevContext();
            var dt = DateTime.Now;
            //var setOrID = context.T_Orders.Count()+1;
            //label6.Text = "OR" + setOrID.ToString().PadLeft(6, '0');
            T_Order Order = new T_Order()
            {
                SoID = int.Parse(comboSo.SelectedValue.ToString()),
                EmID = int.Parse(comboEm.SelectedValue.ToString()),
                ClID = int.Parse(comboCl.SelectedValue.ToString()),
                ClCharge = textBoxCharge.Text,
                OrDate = dt.Date,

                OrStateFlag = 0,
                OrFlag = 0,
                OrHidden = ""
            };
            context.T_Orders.Add(Order);
            context.SaveChanges();
            obtainedID = Order.OrID;
            labelIDView.Text = "受注番号：" + obtainedID;
            context.Dispose();
            groupBoxOr.Enabled = false;
            dataGridMain.Visible = false;
            panel3.Visible = true;
            panel1.Enabled = false;
            LoadProducts();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (!IsEditMode)
                GenerateDetails();
            else
            {
                int SoID = int.Parse(comboSo.SelectedValue.ToString());
                int EmID = int.Parse(comboEm.SelectedValue.ToString());
                int ClID = int.Parse(comboCl.SelectedValue.ToString());
                T_Order Modify = new T_Order() {
                    OrID = obtainedID,
                    SoID = SoID,
                    EmID = EmID,
                    ClID = ClID,
                    ClCharge = textBoxCharge.Text
                };
                orderAccess.ModifyOrder(Modify);
                GenerateModifyDetails();
            }
            ClosePanel3();
        }

        private void ClosePanel3()
        {
            NO = true;
            panel3.Visible = false;
            panel1.Enabled = true;
            groupBoxOr.Visible = false;
            groupBoxOr.Enabled = true;
            buttonAddOr.Enabled = true;
            buttonEditOr.Enabled = true;
            buttonCoOr.Enabled = true;
            if (labelSoID.Text == "--")
            {
                buttonCoOr.Enabled = false;
                buttonEditOr.Enabled = false;
            }
            comboSo.DataSource = null;
            comboCl.DataSource = null;
            comboEm.DataSource = null;
            buttonHide.Visible = false;
            buttonUnHide.Visible = false;
            textBoxCharge.Text = "";
            dataGridSelectedProduct.Rows.Clear();
            if (!checkHiddenToggle.Checked) GenerateFilter(new object(),new EventArgs());
            dataGridMain.Refresh();
            if (dataGridMain.RowCount > 0) LoadDetailGrid();
            else dataGridDetail.DataSource = null;
            dataGridMain.Visible = true;
        }

        private void GenerateModifyDetails()
        {
            var context = new SalesManagement_DevContext();
            var orID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            int countDB = context.T_OrderDetails.Count(x => x.OrID == orID); int temp = countDB;
            int countDG = dataGridSelectedProduct.Rows.Count;
            int countDD = dataGridDetail.Rows.Count;
            int id = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            context.Dispose();
            if (countDB == 0)
                GenerateDetails();
            else if (countDG < countDB)
            {
                orderAccess.DeleteDetails(id);
                GenerateDetails();
            }
            else
            {
                for (int i = 0; i < countDG; i++)
                {
                    int orDetailID = 0;
                    int orID1 = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                    if (countDD > i) 
                    { orDetailID = int.Parse(dataGridDetail.Rows[i].Cells[0].Value.ToString()); }
                    int prID = int.Parse(dataGridSelectedProduct.Rows[i].Cells[0].Value.ToString());
                    int orQuantity = int.Parse(dataGridSelectedProduct.Rows[i].Cells[2].Value.ToString());
                    int orTotalPrice = int.Parse(dataGridSelectedProduct.Rows[i].Cells[3].Value.ToString());
                    T_OrderDetail orderDetail = new T_OrderDetail()
                    {
                        OrID = orID1,
                        OrDetailID = orDetailID,
                        PrID = prID,
                        OrQuantity = orQuantity,
                        OrTotalPrice = orTotalPrice
                    };
                    if (countDB > i) orderAccess.ModifyDetails(orderDetail);
                    else if (countDB <= i) orderAccess.CreateDetails(orderDetail);
                }
            }
        }

        private void GenerateDetails()
        {
            for (int i = 0; i < dataGridSelectedProduct.Rows.Count; i++)
            {
                int prID = int.Parse(dataGridSelectedProduct.Rows[i].Cells[0].Value.ToString());
                int orQuantity = int.Parse(dataGridSelectedProduct.Rows[i].Cells[2].Value.ToString());
                int orTotalPrice = int.Parse(dataGridSelectedProduct.Rows[i].Cells[3].Value.ToString());
                T_OrderDetail orderDetail = new T_OrderDetail()
                {
                    OrID = obtainedID,
                    PrID = prID,
                    OrQuantity = orQuantity,
                    OrTotalPrice = orTotalPrice
                };
                orderAccess.CreateDetails(orderDetail);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            buttonAddOr.Enabled = true;
            buttonEditOr.Enabled = true;
            buttonCoOr.Enabled = true;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            buttonHide.Enabled = false;
            buttonAddCa.Enabled = false;
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
                T_Order order = new T_Order()
                {
                    OrID = obtainedID,
                    OrFlag = 0
                };
                orderAccess.SnapBackToReality(order);
                OrderDspHidden = orderAccess.GetOrderHiddenDisplay();
                ClosePanel3();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextHideReason.Text = "";
            groupBoxHider.Visible = false;
            buttonHide.Enabled = true;
            buttonAddCa.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            T_Order order = new T_Order()
            {
                OrID = obtainedID,
                OrHidden = richTextHideReason.Text,
                OrFlag = 1
            };
            orderAccess.BravoSixGoingDark(order);
            Lever();
            groupBoxHider.Visible = false;
            buttonHide.Enabled = true;
            buttonAddCa.Enabled = true;
            ClosePanel3();
            richTextHideReason.Text = "";
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
                ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }
        private void buttonCoOr_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("受注ID：" + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString() + "を確定しますか？", "再確認", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                var context = new SalesManagement_DevContext();
                int soID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString());
                int clID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[5].Value.ToString());
                int orID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                T_Order table = new T_Order()
                {
                    OrID = orID,
                    SoID = soID,
                    ClID = clID
                };
                orderAccess.KingsCross(table);
                var complete = context.T_Orders.Single(x => x.OrID == orID);
                complete.OrStateFlag = 1;
                context.SaveChanges();
                context.Dispose();
                GenerateFilter(new object(), new EventArgs());
                buttonCoOr.Enabled = false;
                buttonEditOr.Enabled = false;
            }
        }

        private void LoadComboEms(int op)
        {
            Employees = employeeAccess.GetEmployeeCombo(Convert.ToInt32(comboSo.SelectedValue.ToString()));
            comboEm.ValueMember = "Value";
            comboEm.DisplayMember = "Display";
            comboEm.DataSource = Employees;
            comboEm.Refresh();
            if (op == 1)
                comboEm.SelectedIndex = -1;
            else if (op == 0)
            {
                var context = new SalesManagement_DevContext();
                string Em = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[3].Value.ToString();
                comboEm.SelectedValue = Em;
                context.Dispose();
            }
                
            if(comboEm.Items.Count >= 10)
            {
                comboEm.DropDownStyle = ComboBoxStyle.DropDown;
                comboEm.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboEm.AutoCompleteSource = AutoCompleteSource.ListItems;
            } 
            else
                comboEm.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadComboCls(int op)
        {
            Clients = clientAccess.GetEmployeeCombo(Convert.ToInt32(comboSo.SelectedValue.ToString()));
            comboCl.DisplayMember = "Display";
            comboCl.ValueMember = "Value";
            comboCl.DataSource = Clients;
            if (op == 1)
                    comboCl.SelectedIndex = -1;
            else
            {
                var context = new SalesManagement_DevContext();
                string Cl = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[3].Value.ToString();
                comboCl.SelectedValue = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[5].Value.ToString();
                context.Dispose();
            }

            if (comboCl.Items.Count >= 10)
            {
                comboCl.DropDownStyle = ComboBoxStyle.DropDown;
                comboCl.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboCl.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
                comboCl.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void comboAddSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NO == false)
            {
                NO = true;
                comboEm.DataSource = null;
                comboEm.Items.Clear();
                comboCl.DataSource = null;
                comboCl.Enabled = false;
                comboEm.Enabled = true;
                comboCl.SelectedIndex = -1;
                LoadComboEms(1);
                NO = false;
                comboEm.Focus();
            }
        }

        private void comboAddEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NO == false)
            {
                NO = true;
                comboCl.Enabled = true;
                LoadComboCls(1);
                comboCl.Focus();
                NO = false;
            }
        }

        private void comboAddCl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NO == false)
            {
                textBoxCharge.Focus();
                textBoxCharge.Enabled = true;
            }
        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridMain.RowCount > 0)
            {
                var context = new SalesManagement_DevContext();
                groupBoxDesc.Text = "受注 " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString().PadLeft(6,'0');
                labelSoID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[1].Value.ToString() + "]  営業所名: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[2].Value.ToString();
                labelEmID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[3].Value.ToString() + "]  社員名　　: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[4].Value.ToString();
                labelClID.Text = "[ID: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[5].Value.ToString() + "]  顧客名　　: " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[6].Value.ToString();
                labelClCharge.Text = "顧客担当者 " + dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[7].Value.ToString();
                DateTime getdate = Convert.ToDateTime(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[8].Value.ToString());
                labelDate.Text =  getdate.ToString("yyyy年MM月dd日") + " に受注";
                buttonHide.Visible = true;
                buttonUnHide.Visible = false;
                LoadDetailGrid();
                obtainedID = int.Parse(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
                int counting = context.T_OrderDetails.Count(x => x.OrID == obtainedID);
                context.Dispose();
                if (checkHiddenToggle.Checked)
                {
                    richTextDescHide.Text = dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[13].Value.ToString();
                    checkChumon.Checked = Convert.ToBoolean(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[10].Value);
                    checkHide.Checked = Convert.ToBoolean(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[12].Value);
                    buttonHide.Visible = false;
                    buttonUnHide.Visible = true;
                    if (checkChumon.Checked) { buttonEditOr.Enabled = false; buttonCoOr.Enabled = false; }
                    else { buttonEditOr.Enabled = true;}
                }
                else
                {
                    if (!IsEditMode)
                    {
                        buttonCoOr.Enabled = true;
                        buttonEditOr.Enabled = true;
                    }
                    if (counting == 0)
                        buttonCoOr.Enabled = false;
                }
                SetPosition();
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
            OrderDetailDsp = orderAccess.GetOrderDetail(dataGridMain.Rows[dataGridMain.CurrentRow.Index].Cells[0].Value.ToString());
            SetDetailView();
        }
        private void SetDetailView()
        {
            dataGridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridDetail.RowTemplate.Height = 50;
            dataGridDetail.DataSource = OrderDetailDsp;
            dataGridDetail.Columns[0].Visible = false;
            dataGridDetail.Columns[1].Width = 100;
            dataGridDetail.Columns[2].Width = 200;
            dataGridDetail.Columns[3].Width = 100;
            dataGridDetail.Columns[4].Width = 200;
            dataGridDetail.Columns[5].Width = 50;
            dataGridDetail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            int Total = 0;
            for (int i = 0; i < dataGridDetail.Rows.Count; i++)
            {
                Total += int.Parse(dataGridDetail.Rows[i].Cells[6].Value.ToString());
            }
            labelDisplayTotal.Text = "¥" + Total.ToString("#,##0"); 
        }
        private void textBoxCharge_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCharge.Text) || string.IsNullOrWhiteSpace(textBoxCharge.Text))
                buttonAddNext.Enabled = false;
            else
                buttonAddNext.Enabled = true;
        }

        private void LoadProducts()
        {
            Products = productAccess.SearchProductDisplayForOrder("");
            dataGridProduct.DataSource = Products;
            SetProductView();
        }

        private void SetProductView()
        {
            //行ごと選択
            dataGridProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //
            dataGridProduct.AllowUserToAddRows = false;
            //読み取り専用
            dataGridProduct.ReadOnly = true;
            //ヘッダー位置の指定
            dataGridProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduct.Columns[0].Width = 100;
            dataGridProduct.Columns[1].Width = 100;
            dataGridProduct.Columns[2].Width = 400;
            dataGridProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduct.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduct.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduct.Refresh();
        }
        
        private void buttonPrClear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridProduct.Rows.Count; i++)
            {
                if (dataGridProduct.Rows[i].Visible == false)
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridProduct.DataSource];
                    currencyManager.SuspendBinding();
                    dataGridProduct.Rows[i].Visible = true;
                    currencyManager.ResumeBinding();
                }
            }
            dataGridSelectedProduct.Rows.Clear();
            labelTotal.Text = "¥0";
        }

        private void dataGridProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridProduct.CurrentRow.Index;
            int index = dataGridSelectedProduct.Rows.Add();
            dataGridSelectedProduct.Rows[index].Cells[0].Value = dataGridProduct.Rows[i].Cells[0].Value;
            dataGridSelectedProduct.Rows[index].Cells[1].Value = dataGridProduct.Rows[i].Cells[2].Value;
            dataGridSelectedProduct.Rows[index].Cells[2].Value = 1;
            ((DataGridViewTextBoxColumn)dataGridSelectedProduct.Columns[index]).MaxInputLength = 4;
            dataGridSelectedProduct.Rows[index].Cells[3].Value = dataGridProduct.Rows[i].Cells[3].Value;
            PayPayTotal();
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridProduct.DataSource];
            currencyManager.SuspendBinding();
            dataGridProduct.Rows[i].Visible = false;
            currencyManager.ResumeBinding();
            buttonAddPr.Enabled = true;
        }

        private void dataGridSelectedProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string b = dataGridSelectedProduct.Rows[dataGridSelectedProduct.CurrentRow.Index].Cells[1].Value.ToString();
            for (int i = 0; i < dataGridProduct.Rows.Count; i++)
            {
                string a = dataGridProduct.Rows[i].Cells[2].Value.ToString();
                if (dataGridProduct.Rows[i].Visible == false && a == b)
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridProduct.DataSource];
                    currencyManager.SuspendBinding();
                    dataGridProduct.Rows[i].Visible = true;
                    currencyManager.ResumeBinding();
                    dataGridSelectedProduct.Rows.RemoveAt(dataGridSelectedProduct.CurrentRow.Index);
                }
            }
            PayPayTotal();
            if (dataGridSelectedProduct.Rows.Count <= 0)
                buttonAddPr.Enabled = false;
        }

        private void dataGridSelectedProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSelectedProduct.RowCount > 0)
            {
                dataGridSelectedProduct.CurrentCell = dataGridSelectedProduct.Rows[dataGridSelectedProduct.CurrentRow.Index].Cells[2];
                ((DataGridViewTextBoxColumn)dataGridSelectedProduct.Columns[2]).MaxInputLength = 4;
                dataGridSelectedProduct.BeginEdit(true);
            }
        }

        private void dataGridSelectedProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void dataGridSelectedProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            if (tb != null)
                tb.KeyPress += new KeyPressEventHandler(dataGridSelectedProduct_KeyPress);
        }

        private void dataGridSelectedProduct_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            dataGridSelectedProduct.KeyPress += new KeyPressEventHandler(dataGridSelectedProduct_KeyPress);
        }

        private void dataGridSelectedProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string b = dataGridSelectedProduct.Rows[dataGridSelectedProduct.CurrentRow.Index].Cells[1].Value.ToString();
            int c = dataGridSelectedProduct.CurrentRow.Index;
            try
            {
                for (int i = 0; i < dataGridProduct.Rows.Count; i++)
                {
                    string a = dataGridProduct.Rows[i].Cells[2].Value.ToString();
                    if (a == b && dataGridSelectedProduct.Rows[c].Cells[2].Value != null)
                    {
                        int x = int.Parse(dataGridProduct.Rows[i].Cells[3].Value.ToString());
                        int y = int.Parse(dataGridSelectedProduct.Rows[c].Cells[2].Value.ToString());
                        dataGridSelectedProduct.Rows[c].Cells[3].Value = x * y;
                    }
                    else if(dataGridSelectedProduct.Rows[c].Cells[2].Value == null)
                        dataGridSelectedProduct.Rows[c].Cells[2].Value = 1;
                }
                PayPayTotal();
            }
            catch {dataGridSelectedProduct.Rows[c].Cells[2].Value = 1;}
        }
        // メソッド名:PayPayTotal()
        // 引　数　　:なし
        // 戻り値　　:なし
        // 機能　　　:選択した商品の合計を出力
        private void PayPayTotal()
        {
            int Total = 0;
            for (int i = 0; i < dataGridSelectedProduct.Rows.Count; i++)
            {
                Total += int.Parse(dataGridSelectedProduct.Rows[i].Cells[3].Value.ToString());
            }
            labelTotal.Text = "¥" + Total.ToString("#,##0");
        }

        private void buttonHidCo_Click(object sender, EventArgs e)
        {
            Lever();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Lever();
        }
        private void Lever()
        {
            bool set = (panelHideConfirm.Visible == false) ? panelHideConfirm.Visible = true : panelHideConfirm.Visible = false;
            set = (label21.Visible == false) ? label21.Visible = true : label21.Visible = false;
            set = (panelHide.Visible == true) ? panelHide.Visible = false : panelHide.Visible = true;
            set = (richTextHideReason.Enabled == true) ? richTextHideReason.Enabled = false : richTextHideReason.Enabled = true;
        }

        private void GenerateFilter(object sender,EventArgs e)
        {
            var context = new SalesManagement_DevContext();
            int type = comboSearchCa.SelectedIndex;
            var search = textBoxSearch.Text;
            if(!checkHiddenToggle.Checked)
            { OrderDsp = orderAccess.DefaultSearch(search, type, dateTimeFrom.Value.Date, dateTimeTo.Value.Date, SearchAsDate.Checked); SetMainView(); }
            else
            { OrderDspHidden = orderAccess.HiddenSearch(search, type, dateTimeFrom.Value.Date, dateTimeTo.Value.Date, SearchAsDate.Checked); SetMainHiddenView(); }
        }
        private void checkHiddenToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkHiddenToggle.Checked) { SetMainView();checkChumon.Checked = false;checkHide.Checked = false; GenerateFilter(new object(), new EventArgs()); }
            else { OrderDspHidden = orderAccess.GetOrderHiddenDisplay(); SetMainHiddenView(); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Products = productAccess.SearchProductDisplayForOrder(textBox2.Text.Trim());
            //if (string.IsNullOrEmpty(textBox2.Text)) Products = productAccess.SearchProductDisplayForOrder("");
            dataGridProduct.DataSource = Products;
            dataGridSelectedProduct.Rows.Clear();
            HideMatching();
        }
    }
}
