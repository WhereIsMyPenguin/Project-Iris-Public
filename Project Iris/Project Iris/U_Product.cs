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
    public partial class U_Product : UserControl
    {
        //
        ProductAccess productAccess = new ProductAccess();
        //
        private static List<M_ProductDsp> productDsp;
        //
        private static List<M_ProductDspHidden> productDspHidden;
        //
        public U_Product()
        {
            InitializeComponent();
        }
        bool IsEdit = false;
        int ObtainedID = 0;
        bool stop = false;
        private void U_Product_Load(object sender, EventArgs e)
        {
            panelGeneralOp.Visible = false;
            panelDisplay.Visible = true;
            buttonEdit.Enabled = false;
            comboSearchCa.SelectedIndex = 0;
            LoadMainGrid();
            Clock.Start();
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
        private void SetPosition()
        {
            using (var context = new SalesManagement_DevContext())
            {
                int GetPos = context.M_Employees.Single(x => x.EmID == D_LoginData.EmID).PoID;
                string[] Pos = context.M_Positions.Single(x => x.PoID == GetPos).Positions.Split(',');
                if (Pos[7] == "R")
                { buttonAdd.Enabled = false; buttonEdit.Enabled = false; }
                else if (Pos[7] == "RW") { }
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
            productDsp = productAccess.GetProductDisplay();
            //
            SetMainView();
        }
        private void SetMainView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = productDsp.ToList();

            dataGridMain.Columns[0].Width = 100;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 200;
            dataGridMain.Columns[3].Width = 200;
            dataGridMain.Columns[4].Width = 150;
            dataGridMain.Columns[5].Visible = false;
            dataGridMain.Columns[6].Width = 100;
            dataGridMain.Columns[7].Visible = false;
            dataGridMain.Columns[8].Width = 200;
            dataGridMain.Columns[9].Width = 200;
            dataGridMain.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void SetHiddenView()
        {
            dataGridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridMain.RowTemplate.Height = 50;
            dataGridMain.DataSource = productDspHidden.ToList();

            dataGridMain.Columns[0].Width = 100;
            dataGridMain.Columns[1].Visible = false;
            dataGridMain.Columns[2].Width = 200;
            dataGridMain.Columns[3].Width = 200;
            dataGridMain.Columns[4].Width = 150;
            dataGridMain.Columns[5].Visible = false;
            dataGridMain.Columns[6].Width = 100;
            dataGridMain.Columns[7].Visible = false;
            dataGridMain.Columns[8].Width = 200;
            dataGridMain.Columns[9].Width = 200;
            dataGridMain.Columns[10].Width = 200;
            dataGridMain.Columns[11].Width = 200;
            dataGridMain.Columns[12].Visible = false;
            dataGridMain.Columns[13].Visible = false;
            dataGridMain.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void LoadCombo()
        {
            MakerAccess makerAccess = new MakerAccess();
            List<M_MakerCombo> Maker = makerAccess.GetMakerCombo();
            comboMa.DisplayMember = "Display";
            comboMa.ValueMember = "Value";
            comboMa.DataSource = Maker;

            ClassificationAccess classificationAccess = new ClassificationAccess();
            List<M_MajorClassificationCombo> Major = classificationAccess.GetMajorClassCombo(null);
            comboBoxMajor.DisplayMember = "Display";
            comboBoxMajor.ValueMember = "Value";
            comboBoxMajor.DataSource = Major;
            comboBoxMajor.Refresh();
            
            //メーカの数が10を超えたとき
            if(comboMa.Items.Count > 10)
            {
                comboMa.DropDownStyle = ComboBoxStyle.DropDown;
                comboMa.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboMa.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            //大分類の数が10を超えたとき
            if(comboBoxMajor.Items.Count > 10)
            {
                comboBoxMajor.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxMajor.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBoxMajor.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            ReloadSmallCombo();
        }
        private void ReloadSmallCombo()
        {
            if (stop) return;
            else
            {
                ClassificationAccess classificationAccess = new ClassificationAccess();
                int Temp = int.Parse(comboBoxMajor.SelectedValue.ToString());
                List<M_SmallClassificationCombo> Small = classificationAccess.GetSmallClassCombo(Temp);
                comboSmall.DisplayMember = "Display";
                comboSmall.ValueMember = "Value";
                comboSmall.DataSource = Small;
                comboSmall.Refresh();
                //小分類の数が10を超えたとき
                if (comboSmall.Items.Count > 10)
                {
                    comboSmall.DropDownStyle = ComboBoxStyle.DropDown;
                    comboSmall.AutoCompleteMode = AutoCompleteMode.Suggest;
                    comboSmall.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH : mm : ss");
        }
        private void ClearAll()
        {
            foreach (Control p in panelGeneralOp.Controls)
             {
                if (p is TextBox)
                    (p as TextBox).Clear();
            }
            comboBoxMajor.SelectedIndex = 0;
            comboMa.SelectedIndex = 0;
            comboSmall.SelectedIndex = 0;
            numericSafe.Value = 0;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelDisplay.Visible = false;
            panelGeneralOp.Visible =true;
            buttonHide.Visible = false;
            buttonUnHide.Visible = false;
            groupBoxHider.Visible = false;
            buttonEdit.Enabled = false;
            buttonOK.Enabled = false;
            panel1.Enabled = false;
            panelGeneralOp.BackColor = Color.SpringGreen;
            IsEdit = false;
            LoadCombo();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            panelDisplay.Visible = false;
            panelGeneralOp.Visible = true;
            if(checkHiddenToggle.Checked)
            { buttonUnHide.Visible = true; buttonHide.Visible = false; }
            else
            { buttonUnHide.Visible = false; buttonHide.Visible = true; }
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;
            buttonOK.Enabled = false;
            panel1.Enabled = false;
            groupBoxHider.Visible = false;
            IsEdit = true;
            panelGeneralOp.BackColor = Color.RoyalBlue;
            LoadCombo();
            LoadEditData();
        }
        private void LoadEditData()
        {
            int i = dataGridMain.CurrentRow.Index;
            textBoxName.Text = dataGridMain.Rows[i].Cells[3].Value.ToString();
            comboMa.SelectedValue = dataGridMain.Rows[i].Cells[1].Value.ToString();
            numericPrice.Value = int.Parse(dataGridMain.Rows[i].Cells[4].Value.ToString());
            numericSafe.Value = int.Parse(dataGridMain.Rows[i].Cells[6].Value.ToString());
            textBoxColor.Text = dataGridMain.Rows[i].Cells[10].Value.ToString();
            textBoxModel.Text = dataGridMain.Rows[i].Cells[9].Value.ToString();
            PrDate.Value = Convert.ToDateTime(dataGridMain.Rows[i].Cells[11].Value);
            using (var context = new SalesManagement_DevContext())
            {
                int small = int.Parse(dataGridMain.Rows[i].Cells[7].Value.ToString());
                int major = context.M_SmallClassifications.Single(x => x.ScID == small).McID;
                comboBoxMajor.SelectedValue = major.ToString();
                stop = true;
                comboSmall.SelectedValue = small.ToString();
                stop = false;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
            panelGeneralOp.Visible = false;
            buttonAdd.Enabled = true;
            panelDisplay.Visible = true;
            panel1.Enabled = true;
            GenerateFilter(sender,e);
        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridMain.Rows.Count > 0)
            {
                int i = dataGridMain.CurrentRow.Index;
                labelPrName.Text = dataGridMain.Rows[i].Cells[3].Value.ToString();              //商品名
                labelPrID.Text = dataGridMain.Rows[i].Cells[0].Value.ToString();                   //商品ID
                ObtainedID = int.Parse(labelPrID.Text);                                                             //取得ID
                labelMa.Text = dataGridMain.Rows[i].Cells[2].Value.ToString();                     //メーカ名
                int price = int.Parse(dataGridMain.Rows[i].Cells[4].Value.ToString());
                labelPrice.Text = price.ToString("#,##0") + "￥";                                              //価格
                int stock = int.Parse(dataGridMain.Rows[i].Cells[6].Value.ToString());
                labelSafe.Text = stock.ToString("#,##0") + " 個";                                           //安全在庫数
                labelModel.Text = dataGridMain.Rows[i].Cells[9].Value.ToString();                //型番
                using (var context = new SalesManagement_DevContext())
                {
                    int small = int.Parse(dataGridMain.Rows[i].Cells[7].Value.ToString());
                    int major = context.M_SmallClassifications.Single(x => x.ScID == small).McID;
                    string a = context.M_MajorClassifications.Single(x => x.McID == major).McName;
                    labelClass.Text = a + "\n┗ " + dataGridMain.Rows[i].Cells[8].Value.ToString();
                }
                labelColor.Text = dataGridMain.Rows[i].Cells[10].Value.ToString();              //色
                DateTime date = Convert.ToDateTime(dataGridMain.Rows[i].Cells[11].Value);
                labelRDate.Text = date.Date.ToString("yyyy年MM月dd日");                            //販売開始日
                if (checkHiddenToggle.Checked)
                    labelHiddenReason.Text = dataGridMain.Rows[i].Cells[14].Value.ToString();
                buttonEdit.Enabled = true;
                SetPosition();
            }
        }
        private void comboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadSmallCombo();
        }

        private void CheckText(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxColor.Text) && numericSafe.Value > 0
                && textBoxModel.Text.Trim().Length > 0 && numericPrice.Value > 0)
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int MaID = Convert.ToInt32(comboMa.SelectedValue.ToString());
            int ScID = Convert.ToInt32(comboSmall.SelectedValue.ToString());
            var context = new SalesManagement_DevContext();
            M_Product product = new M_Product()
            {
                PrName = textBoxName.Text,
                MaID = MaID,
                Price = int.Parse(numericPrice.Value.ToString()),
                PrSafetyStock = int.Parse(numericSafe.Value.ToString()),
                PrColor = textBoxColor.Text,
                PrModelNumber = textBoxModel.Text,
                PrReleaseDate = PrDate.Value.Date,
                ScID = ScID
            };
            if (context.M_Products.Any(x => x.MaID == MaID && x.PrName == textBoxName.Text))
            {
                DialogResult result = MessageBox.Show("メーカ" + comboMa.Text.Split(' ')[1].ToString() + " に、商品" + textBoxName.Text + "は既に存在しています\nそれでも追加しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
            if (!IsEdit)
            { productAccess.AddProduct(product); }
            else
            { productAccess.Modify(product,ObtainedID); }
            GenerateFilter(new object(), new EventArgs());
            buttonCancel_Click(sender, e);
        }
        private void GenerateFilter(object sender,EventArgs e)
        {
            int type = comboSearchCa.SelectedIndex;
            string search = textBoxSearch.Text;
            if(!checkHiddenToggle.Checked)
            { productDsp = productAccess.DefaultSearch(search, type, SearchAsDate.Checked, dateTimeFrom.Value.Date, dateTimeTo.Value.Date); SetMainView();  }
            else { productDspHidden = productAccess.HiddenSearch(search, type, SearchAsDate.Checked, dateTimeFrom.Value.Date, dateTimeTo.Value.Date); SetHiddenView(); }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            groupBoxHider.Visible = true;
            panelClass.Visible = false;
        }

        private void buttonHidCa_Click(object sender, EventArgs e)
        {
            groupBoxHider.Visible = false;
            panelClass.Visible = true;
            richTextHideReason.Clear();
        }

        private void buttonHidCo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("非表示にしますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
                productAccess.BravoSixGoingDark(ObtainedID, richTextHideReason.Text);
            buttonCancel_Click(sender, e);
        }

        private void buttonUnHide_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("表示させますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
                productAccess.SnapBackToReality(ObtainedID);
            buttonCancel_Click(sender, e);
        }
    }
}
