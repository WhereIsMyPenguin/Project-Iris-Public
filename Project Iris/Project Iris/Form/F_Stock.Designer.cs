
namespace Project_Iris
{
    partial class F_Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.SearchAsDate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSearchCa = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogDate = new System.Windows.Forms.Label();
            this.LogSo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LogPo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LogUser = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBacc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMa = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSafe = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelRDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPrID = new System.Windows.Forms.Label();
            this.labelPrName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMain
            // 
            this.dataGridMain.AllowUserToAddRows = false;
            this.dataGridMain.AllowUserToDeleteRows = false;
            this.dataGridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMain.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMain.ColumnHeadersHeight = 25;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMain.GridColor = System.Drawing.Color.DarkOrchid;
            this.dataGridMain.Location = new System.Drawing.Point(15, 485);
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.RowHeadersVisible = false;
            this.dataGridMain.RowTemplate.Height = 25;
            this.dataGridMain.Size = new System.Drawing.Size(1890, 578);
            this.dataGridMain.TabIndex = 13;
            this.dataGridMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellClick);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeTo.CalendarFont = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimeTo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold);
            this.dateTimeTo.Location = new System.Drawing.Point(1328, 15);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(220, 32);
            this.dateTimeTo.TabIndex = 26;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeFrom.CalendarFont = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimeFrom.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold);
            this.dateTimeFrom.Location = new System.Drawing.Point(1058, 15);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(220, 32);
            this.dateTimeFrom.TabIndex = 27;
            // 
            // SearchAsDate
            // 
            this.SearchAsDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchAsDate.AutoSize = true;
            this.SearchAsDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchAsDate.Location = new System.Drawing.Point(913, 20);
            this.SearchAsDate.Name = "SearchAsDate";
            this.SearchAsDate.Size = new System.Drawing.Size(140, 26);
            this.SearchAsDate.TabIndex = 24;
            this.SearchAsDate.Text = "発売日で絞る";
            this.SearchAsDate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1288, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "検索";
            // 
            // comboSearchCa
            // 
            this.comboSearchCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchCa.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboSearchCa.FormattingEnabled = true;
            this.comboSearchCa.Items.AddRange(new object[] {
            "選択なし",
            "商品ID",
            "商品名",
            "メーカ名",
            "価格",
            "安全在庫数",
            "型版",
            "小分類",
            "色"});
            this.comboSearchCa.Location = new System.Drawing.Point(85, 15);
            this.comboSearchCa.Name = "comboSearchCa";
            this.comboSearchCa.Size = new System.Drawing.Size(150, 39);
            this.comboSearchCa.TabIndex = 21;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxSearch.Location = new System.Drawing.Point(250, 15);
            this.textBoxSearch.MaxLength = 50;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(325, 39);
            this.textBoxSearch.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.dateTimeTo);
            this.panel1.Controls.Add(this.comboSearchCa);
            this.panel1.Controls.Add(this.dateTimeFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SearchAsDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1890, 65);
            this.panel1.TabIndex = 28;
            // 
            // LogDate
            // 
            this.LogDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogDate.AutoSize = true;
            this.LogDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogDate.Location = new System.Drawing.Point(1745, 345);
            this.LogDate.Name = "LogDate";
            this.LogDate.Size = new System.Drawing.Size(112, 22);
            this.LogDate.TabIndex = 39;
            this.LogDate.Text = "ログイン日時";
            // 
            // LogSo
            // 
            this.LogSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogSo.AutoSize = true;
            this.LogSo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogSo.Location = new System.Drawing.Point(1745, 305);
            this.LogSo.Name = "LogSo";
            this.LogSo.Size = new System.Drawing.Size(67, 22);
            this.LogSo.TabIndex = 40;
            this.LogSo.Text = "営業所";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(1625, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "ログイン日時";
            // 
            // LogPo
            // 
            this.LogPo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPo.AutoSize = true;
            this.LogPo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogPo.Location = new System.Drawing.Point(1740, 265);
            this.LogPo.Name = "LogPo";
            this.LogPo.Size = new System.Drawing.Size(48, 22);
            this.LogPo.TabIndex = 42;
            this.LogPo.Text = "権限";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(1670, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "営業所";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(1685, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "権限";
            // 
            // LogUser
            // 
            this.LogUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogUser.AutoSize = true;
            this.LogUser.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogUser.Location = new System.Drawing.Point(1740, 220);
            this.LogUser.Name = "LogUser";
            this.LogUser.Size = new System.Drawing.Size(145, 22);
            this.LogUser.TabIndex = 45;
            this.LogUser.Text = "ログインユーザー";
            // 
            // ClockLabel
            // 
            this.ClockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(1625, 110);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(161, 50);
            this.ClockLabel.TabIndex = 46;
            this.ClockLabel.Text = "00 : 00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(1590, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "ログインユーザー";
            // 
            // buttonBacc
            // 
            this.buttonBacc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBacc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonBacc.FlatAppearance.BorderSize = 0;
            this.buttonBacc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonBacc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonBacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBacc.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBacc.Location = new System.Drawing.Point(1705, -3);
            this.buttonBacc.Name = "buttonBacc";
            this.buttonBacc.Size = new System.Drawing.Size(215, 65);
            this.buttonBacc.TabIndex = 48;
            this.buttonBacc.Text = "↩  戻る";
            this.buttonBacc.UseVisualStyleBackColor = false;
            this.buttonBacc.Click += new System.EventHandler(this.buttonBacc_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 67);
            this.panel2.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "在庫";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(470, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.label23);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.labelModel);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.labelMa);
            this.splitContainer1.Panel1.Controls.Add(this.labelPrice);
            this.splitContainer1.Panel1.Controls.Add(this.labelSafe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.label19);
            this.splitContainer1.Panel2.Controls.Add(this.labelClass);
            this.splitContainer1.Panel2.Controls.Add(this.labelColor);
            this.splitContainer1.Panel2.Controls.Add(this.labelRDate);
            this.splitContainer1.Size = new System.Drawing.Size(920, 355);
            this.splitContainer1.SplitterDistance = 459;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(435, 160);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 31);
            this.label23.TabIndex = 14;
            this.label23.Text = "＜";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(30, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "安全在庫";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelModel.Location = new System.Drawing.Point(165, 305);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(44, 31);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "--";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(40, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "メーカ名";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(85, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "価格";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(85, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 31);
            this.label11.TabIndex = 5;
            this.label11.Text = "型版";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMa.Location = new System.Drawing.Point(165, 30);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(44, 31);
            this.labelMa.TabIndex = 2;
            this.labelMa.Text = "--";
            this.labelMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPrice.Location = new System.Drawing.Point(165, 125);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 31);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "--";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSafe
            // 
            this.labelSafe.AutoSize = true;
            this.labelSafe.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSafe.Location = new System.Drawing.Point(165, 215);
            this.labelSafe.Name = "labelSafe";
            this.labelSafe.Size = new System.Drawing.Size(79, 31);
            this.labelSafe.TabIndex = 2;
            this.labelSafe.Text = "-- 個";
            this.labelSafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(-10, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 31);
            this.label20.TabIndex = 14;
            this.label20.Text = "＞";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(60, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 31);
            this.label17.TabIndex = 13;
            this.label17.Text = "大分類";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(60, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 31);
            this.label16.TabIndex = 12;
            this.label16.Text = "発売日";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(110, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 31);
            this.label19.TabIndex = 8;
            this.label19.Text = "色";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelClass.Location = new System.Drawing.Point(165, 35);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(79, 62);
            this.labelClass.TabIndex = 9;
            this.labelClass.Text = "--\r\n┗ --";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelColor.Location = new System.Drawing.Point(165, 130);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(44, 31);
            this.labelColor.TabIndex = 11;
            this.labelColor.Text = "--";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRDate
            // 
            this.labelRDate.AutoSize = true;
            this.labelRDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRDate.Location = new System.Drawing.Point(165, 220);
            this.labelRDate.Name = "labelRDate";
            this.labelRDate.Size = new System.Drawing.Size(44, 31);
            this.labelRDate.TabIndex = 10;
            this.labelRDate.Text = "--";
            this.labelRDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelPrID);
            this.panel3.Controls.Add(this.labelPrName);
            this.panel3.Location = new System.Drawing.Point(15, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 355);
            this.panel3.TabIndex = 51;
            // 
            // labelPrID
            // 
            this.labelPrID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelPrID.Location = new System.Drawing.Point(0, 240);
            this.labelPrID.Name = "labelPrID";
            this.labelPrID.Size = new System.Drawing.Size(450, 115);
            this.labelPrID.TabIndex = 1;
            this.labelPrID.Text = "--";
            this.labelPrID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrName
            // 
            this.labelPrName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrName.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 48F, System.Drawing.FontStyle.Bold);
            this.labelPrName.Location = new System.Drawing.Point(0, 0);
            this.labelPrName.Name = "labelPrName";
            this.labelPrName.Size = new System.Drawing.Size(450, 240);
            this.labelPrName.TabIndex = 0;
            this.labelPrName.Text = "--";
            this.labelPrName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonBacc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LogDate);
            this.Controls.Add(this.LogSo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LogPo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LogUser);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Stock";
            this.Text = "F_Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMain;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.CheckBox SearchAsDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSearchCa;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogDate;
        private System.Windows.Forms.Label LogSo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LogPo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LogUser;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBacc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSafe;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelRDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelPrName;
        private System.Windows.Forms.Label labelPrID;
    }
}