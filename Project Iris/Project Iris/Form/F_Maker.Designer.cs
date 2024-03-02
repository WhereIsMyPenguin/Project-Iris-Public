
namespace Project_Iris
{
    partial class F_Maker
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonUnHide = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.labelFAX = new System.Windows.Forms.Label();
            this.labelHiddenReason = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPostal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSoID = new System.Windows.Forms.Label();
            this.labelSoName = new System.Windows.Forms.Label();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.richTextHideReason = new System.Windows.Forms.RichTextBox();
            this.checkHiddenToggle = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSearchCa = new System.Windows.Forms.ComboBox();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonBacc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelGeneralOp = new System.Windows.Forms.Panel();
            this.groupBoxHider = new System.Windows.Forms.GroupBox();
            this.panelHide = new Project_Iris.RoundPanel();
            this.buttonHidCa = new System.Windows.Forms.Button();
            this.buttonHidCo = new System.Windows.Forms.Button();
            this.panelHideConfirm = new Project_Iris.RoundPanel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.DecisionPanel = new Project_Iris.RoundPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LogSo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LogPo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LogUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.textBoxFAX = new System.Windows.Forms.MaskedTextBox();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelGeneralOp.SuspendLayout();
            this.groupBoxHider.SuspendLayout();
            this.panelHide.SuspendLayout();
            this.panelHideConfirm.SuspendLayout();
            this.DecisionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAd.Location = new System.Drawing.Point(195, 190);
            this.textBoxAd.MaxLength = 50;
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(325, 39);
            this.textBoxAd.TabIndex = 12;
            this.textBoxAd.TextChanged += new System.EventHandler(this.checking);
            // 
            // textBoxSo
            // 
            this.textBoxSo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSo.Location = new System.Drawing.Point(200, 101);
            this.textBoxSo.MaxLength = 50;
            this.textBoxSo.Name = "textBoxSo";
            this.textBoxSo.Size = new System.Drawing.Size(325, 39);
            this.textBoxSo.TabIndex = 11;
            this.textBoxSo.TextChanged += new System.EventHandler(this.checking);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Window;
            this.label21.Location = new System.Drawing.Point(65, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(175, 17);
            this.label21.TabIndex = 5;
            this.label21.Text = "本当に非表示化しますか？";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(70, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 31);
            this.label15.TabIndex = 10;
            this.label15.Text = "メーカ名";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(85, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "F　A　X";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(65, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 31);
            this.label12.TabIndex = 8;
            this.label12.Text = "郵便番号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(65, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 31);
            this.label13.TabIndex = 6;
            this.label13.Text = "電話番号";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(120, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 31);
            this.label14.TabIndex = 7;
            this.label14.Text = "住所";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUnHide
            // 
            this.buttonUnHide.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUnHide.FlatAppearance.BorderSize = 0;
            this.buttonUnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnHide.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonUnHide.Location = new System.Drawing.Point(545, 100);
            this.buttonUnHide.Name = "buttonUnHide";
            this.buttonUnHide.Size = new System.Drawing.Size(320, 70);
            this.buttonUnHide.TabIndex = 0;
            this.buttonUnHide.Text = "表示化";
            this.buttonUnHide.UseVisualStyleBackColor = false;
            this.buttonUnHide.Click += new System.EventHandler(this.buttonUnHide_Click_1);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.Transparent;
            this.panelDisplay.Controls.Add(this.labelFAX);
            this.panelDisplay.Controls.Add(this.labelHiddenReason);
            this.panelDisplay.Controls.Add(this.label10);
            this.panelDisplay.Controls.Add(this.labelPostal);
            this.panelDisplay.Controls.Add(this.label5);
            this.panelDisplay.Controls.Add(this.labelPhone);
            this.panelDisplay.Controls.Add(this.labelAddress);
            this.panelDisplay.Controls.Add(this.label4);
            this.panelDisplay.Controls.Add(this.label2);
            this.panelDisplay.Controls.Add(this.labelSoID);
            this.panelDisplay.Controls.Add(this.labelSoName);
            this.panelDisplay.Location = new System.Drawing.Point(17, 143);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(920, 715);
            this.panelDisplay.TabIndex = 26;
            // 
            // labelFAX
            // 
            this.labelFAX.AutoSize = true;
            this.labelFAX.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFAX.Location = new System.Drawing.Point(180, 525);
            this.labelFAX.Name = "labelFAX";
            this.labelFAX.Size = new System.Drawing.Size(44, 31);
            this.labelFAX.TabIndex = 6;
            this.labelFAX.Text = "--";
            this.labelFAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHiddenReason
            // 
            this.labelHiddenReason.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelHiddenReason.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHiddenReason.Location = new System.Drawing.Point(0, 580);
            this.labelHiddenReason.Name = "labelHiddenReason";
            this.labelHiddenReason.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.labelHiddenReason.Size = new System.Drawing.Size(920, 135);
            this.labelHiddenReason.TabIndex = 5;
            this.labelHiddenReason.Text = "非表示理由：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(65, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "F　A　X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPostal
            // 
            this.labelPostal.AutoSize = true;
            this.labelPostal.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPostal.Location = new System.Drawing.Point(180, 436);
            this.labelPostal.Name = "labelPostal";
            this.labelPostal.Size = new System.Drawing.Size(44, 31);
            this.labelPostal.TabIndex = 3;
            this.labelPostal.Text = "--";
            this.labelPostal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(45, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "郵便番号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPhone.Location = new System.Drawing.Point(180, 345);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(44, 31);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "--";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAddress.Location = new System.Drawing.Point(180, 250);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(44, 31);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "--";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(45, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "電話番号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(100, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "住所";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoID
            // 
            this.labelSoID.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSoID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSoID.Location = new System.Drawing.Point(0, 115);
            this.labelSoID.Name = "labelSoID";
            this.labelSoID.Size = new System.Drawing.Size(920, 55);
            this.labelSoID.TabIndex = 1;
            this.labelSoID.Text = "--";
            this.labelSoID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoName
            // 
            this.labelSoName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSoName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSoName.Location = new System.Drawing.Point(0, 0);
            this.labelSoName.Name = "labelSoName";
            this.labelSoName.Size = new System.Drawing.Size(920, 115);
            this.labelSoName.TabIndex = 0;
            this.labelSoName.Text = "--";
            this.labelSoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPostal
            // 
            this.textBoxPostal.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPostal.Location = new System.Drawing.Point(195, 375);
            this.textBoxPostal.MaxLength = 7;
            this.textBoxPostal.Name = "textBoxPostal";
            this.textBoxPostal.Size = new System.Drawing.Size(325, 39);
            this.textBoxPostal.TabIndex = 14;
            this.textBoxPostal.TextChanged += new System.EventHandler(this.checking);
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // richTextHideReason
            // 
            this.richTextHideReason.BackColor = System.Drawing.Color.White;
            this.richTextHideReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextHideReason.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextHideReason.Location = new System.Drawing.Point(5, 25);
            this.richTextHideReason.Name = "richTextHideReason";
            this.richTextHideReason.Size = new System.Drawing.Size(305, 245);
            this.richTextHideReason.TabIndex = 2;
            this.richTextHideReason.Text = "";
            // 
            // checkHiddenToggle
            // 
            this.checkHiddenToggle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkHiddenToggle.AutoSize = true;
            this.checkHiddenToggle.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkHiddenToggle.Location = new System.Drawing.Point(605, 25);
            this.checkHiddenToggle.Name = "checkHiddenToggle";
            this.checkHiddenToggle.Size = new System.Drawing.Size(154, 26);
            this.checkHiddenToggle.TabIndex = 13;
            this.checkHiddenToggle.Text = "非表示切り替え";
            this.checkHiddenToggle.UseVisualStyleBackColor = true;
            this.checkHiddenToggle.CheckedChanged += new System.EventHandler(this.checkHiddenToggle_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "検索";
            // 
            // comboSearchCa
            // 
            this.comboSearchCa.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboSearchCa.FormattingEnabled = true;
            this.comboSearchCa.Items.AddRange(new object[] {
            "選択なし",
            "営業所ID",
            "営業所名",
            "住所",
            "電話番号",
            "郵便番号",
            "FAX"});
            this.comboSearchCa.Location = new System.Drawing.Point(85, 20);
            this.comboSearchCa.Name = "comboSearchCa";
            this.comboSearchCa.Size = new System.Drawing.Size(150, 39);
            this.comboSearchCa.TabIndex = 7;
            this.comboSearchCa.SelectedIndexChanged += new System.EventHandler(this.comboSearchCa_SelectedIndexChanged_1);
            // 
            // dataGridMain
            // 
            this.dataGridMain.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMain.GridColor = System.Drawing.Color.PaleGreen;
            this.dataGridMain.Location = new System.Drawing.Point(15, 80);
            this.dataGridMain.Name = "dataGridMain";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMain.RowHeadersVisible = false;
            this.dataGridMain.Size = new System.Drawing.Size(950, 910);
            this.dataGridMain.TabIndex = 0;
            this.dataGridMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxSearch.Location = new System.Drawing.Point(245, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(210, 39);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged_1);
            // 
            // buttonBacc
            // 
            this.buttonBacc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBacc.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonBacc.FlatAppearance.BorderSize = 0;
            this.buttonBacc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonBacc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonBacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBacc.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBacc.Location = new System.Drawing.Point(1705, 0);
            this.buttonBacc.Name = "buttonBacc";
            this.buttonBacc.Size = new System.Drawing.Size(215, 55);
            this.buttonBacc.TabIndex = 20;
            this.buttonBacc.Text = "↩  戻る";
            this.buttonBacc.UseVisualStyleBackColor = false;
            this.buttonBacc.Click += new System.EventHandler(this.buttonBacc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "メーカ管理";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(477, 74);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(460, 70);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "更新";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(17, 74);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(460, 70);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "登録";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1721, 55);
            this.panel3.TabIndex = 21;
            // 
            // panelGeneralOp
            // 
            this.panelGeneralOp.Controls.Add(this.groupBoxHider);
            this.panelGeneralOp.Controls.Add(this.textBoxFAX);
            this.panelGeneralOp.Controls.Add(this.textBoxPhone);
            this.panelGeneralOp.Controls.Add(this.textBoxPostal);
            this.panelGeneralOp.Controls.Add(this.textBoxAd);
            this.panelGeneralOp.Controls.Add(this.textBoxSo);
            this.panelGeneralOp.Controls.Add(this.label15);
            this.panelGeneralOp.Controls.Add(this.label11);
            this.panelGeneralOp.Controls.Add(this.label12);
            this.panelGeneralOp.Controls.Add(this.label13);
            this.panelGeneralOp.Controls.Add(this.label14);
            this.panelGeneralOp.Controls.Add(this.DecisionPanel);
            this.panelGeneralOp.Controls.Add(this.buttonUnHide);
            this.panelGeneralOp.Controls.Add(this.buttonHide);
            this.panelGeneralOp.Location = new System.Drawing.Point(17, 143);
            this.panelGeneralOp.Name = "panelGeneralOp";
            this.panelGeneralOp.Size = new System.Drawing.Size(920, 715);
            this.panelGeneralOp.TabIndex = 27;
            // 
            // groupBoxHider
            // 
            this.groupBoxHider.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxHider.Controls.Add(this.panelHide);
            this.groupBoxHider.Controls.Add(this.label21);
            this.groupBoxHider.Controls.Add(this.panelHideConfirm);
            this.groupBoxHider.Controls.Add(this.richTextHideReason);
            this.groupBoxHider.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.groupBoxHider.Location = new System.Drawing.Point(550, 185);
            this.groupBoxHider.Name = "groupBoxHider";
            this.groupBoxHider.Size = new System.Drawing.Size(315, 320);
            this.groupBoxHider.TabIndex = 12;
            this.groupBoxHider.TabStop = false;
            this.groupBoxHider.Text = "非表示化理由";
            // 
            // panelHide
            // 
            this.panelHide.Angle = 45F;
            this.panelHide.BorderColor = System.Drawing.Color.Black;
            this.panelHide.BorderCurve = 20;
            this.panelHide.BorderSize = 0;
            this.panelHide.Controls.Add(this.buttonHidCa);
            this.panelHide.Controls.Add(this.buttonHidCo);
            this.panelHide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHide.Location = new System.Drawing.Point(3, 271);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(309, 46);
            this.panelHide.TabIndex = 4;
            // 
            // buttonHidCa
            // 
            this.buttonHidCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHidCa.BackColor = System.Drawing.Color.LightCoral;
            this.buttonHidCa.FlatAppearance.BorderSize = 0;
            this.buttonHidCa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.buttonHidCa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonHidCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHidCa.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.buttonHidCa.Location = new System.Drawing.Point(159, 0);
            this.buttonHidCa.Name = "buttonHidCa";
            this.buttonHidCa.Size = new System.Drawing.Size(155, 46);
            this.buttonHidCa.TabIndex = 2;
            this.buttonHidCa.Text = "キャンセル";
            this.buttonHidCa.UseVisualStyleBackColor = false;
            this.buttonHidCa.Click += new System.EventHandler(this.buttonHidCa_Click_1);
            // 
            // buttonHidCo
            // 
            this.buttonHidCo.BackColor = System.Drawing.Color.LightBlue;
            this.buttonHidCo.FlatAppearance.BorderSize = 0;
            this.buttonHidCo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonHidCo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHidCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHidCo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.buttonHidCo.Location = new System.Drawing.Point(-5, 0);
            this.buttonHidCo.Name = "buttonHidCo";
            this.buttonHidCo.Size = new System.Drawing.Size(150, 46);
            this.buttonHidCo.TabIndex = 3;
            this.buttonHidCo.Text = "確定";
            this.buttonHidCo.UseVisualStyleBackColor = false;
            this.buttonHidCo.Click += new System.EventHandler(this.buttonHidCo_Click_1);
            // 
            // panelHideConfirm
            // 
            this.panelHideConfirm.Angle = 45F;
            this.panelHideConfirm.BorderColor = System.Drawing.Color.Black;
            this.panelHideConfirm.BorderCurve = 10;
            this.panelHideConfirm.BorderSize = 0;
            this.panelHideConfirm.Controls.Add(this.buttonNo);
            this.panelHideConfirm.Controls.Add(this.buttonYes);
            this.panelHideConfirm.Location = new System.Drawing.Point(5, 150);
            this.panelHideConfirm.Name = "panelHideConfirm";
            this.panelHideConfirm.Size = new System.Drawing.Size(305, 25);
            this.panelHideConfirm.TabIndex = 4;
            // 
            // buttonNo
            // 
            this.buttonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNo.BackColor = System.Drawing.Color.LightCoral;
            this.buttonNo.FlatAppearance.BorderSize = 0;
            this.buttonNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.buttonNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.buttonNo.Location = new System.Drawing.Point(155, 0);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(150, 25);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "いいえ";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click_1);
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.LightBlue;
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.buttonYes.Location = new System.Drawing.Point(0, 0);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(145, 25);
            this.buttonYes.TabIndex = 3;
            this.buttonYes.Text = "はい";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click_1);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBoxPhone.Location = new System.Drawing.Point(195, 285);
            this.textBoxPhone.Mask = "000-0000-0000";
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PromptChar = ' ';
            this.textBoxPhone.Size = new System.Drawing.Size(325, 39);
            this.textBoxPhone.TabIndex = 16;
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.checking);
            // 
            // DecisionPanel
            // 
            this.DecisionPanel.Angle = 45F;
            this.DecisionPanel.BorderColor = System.Drawing.Color.Black;
            this.DecisionPanel.BorderCurve = 35;
            this.DecisionPanel.BorderSize = 0;
            this.DecisionPanel.Controls.Add(this.buttonCancel);
            this.DecisionPanel.Controls.Add(this.buttonOK);
            this.DecisionPanel.Location = new System.Drawing.Point(15, 640);
            this.DecisionPanel.Name = "DecisionPanel";
            this.DecisionPanel.Size = new System.Drawing.Size(890, 65);
            this.DecisionPanel.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.Location = new System.Drawing.Point(450, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(440, 65);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.LightBlue;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(0, 0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(440, 65);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "確定";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHide.FlatAppearance.BorderSize = 0;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonHide.Location = new System.Drawing.Point(545, 100);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(320, 70);
            this.buttonHide.TabIndex = 0;
            this.buttonHide.Text = "非表示化";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.checkHiddenToggle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboSearchCa);
            this.panel1.Controls.Add(this.dataGridMain);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Location = new System.Drawing.Point(937, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 1000);
            this.panel1.TabIndex = 18;
            // 
            // LogDate
            // 
            this.LogDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogDate.AutoSize = true;
            this.LogDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogDate.Location = new System.Drawing.Point(540, 1035);
            this.LogDate.Name = "LogDate";
            this.LogDate.Size = new System.Drawing.Size(112, 22);
            this.LogDate.TabIndex = 29;
            this.LogDate.Text = "ログイン日時";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(415, 1035);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "ログイン日時";
            // 
            // LogSo
            // 
            this.LogSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogSo.AutoSize = true;
            this.LogSo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogSo.Location = new System.Drawing.Point(540, 995);
            this.LogSo.Name = "LogSo";
            this.LogSo.Size = new System.Drawing.Size(67, 22);
            this.LogSo.TabIndex = 31;
            this.LogSo.Text = "営業所";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(460, 995);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "営業所";
            // 
            // LogPo
            // 
            this.LogPo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPo.AutoSize = true;
            this.LogPo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogPo.Location = new System.Drawing.Point(540, 955);
            this.LogPo.Name = "LogPo";
            this.LogPo.Size = new System.Drawing.Size(48, 22);
            this.LogPo.TabIndex = 33;
            this.LogPo.Text = "権限";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(480, 955);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "権限";
            // 
            // LogUser
            // 
            this.LogUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogUser.AutoSize = true;
            this.LogUser.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogUser.Location = new System.Drawing.Point(540, 910);
            this.LogUser.Name = "LogUser";
            this.LogUser.Size = new System.Drawing.Size(145, 22);
            this.LogUser.TabIndex = 35;
            this.LogUser.Text = "ログインユーザー";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(385, 910);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "ログインユーザー";
            // 
            // ClockLabel
            // 
            this.ClockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(70, 960);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(161, 50);
            this.ClockLabel.TabIndex = 28;
            this.ClockLabel.Text = "00 : 00";
            // 
            // textBoxFAX
            // 
            this.textBoxFAX.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBoxFAX.Location = new System.Drawing.Point(195, 465);
            this.textBoxFAX.Mask = "000-0000-0000";
            this.textBoxFAX.Name = "textBoxFAX";
            this.textBoxFAX.PromptChar = ' ';
            this.textBoxFAX.Size = new System.Drawing.Size(325, 39);
            this.textBoxFAX.TabIndex = 16;
            this.textBoxFAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFAX.TextChanged += new System.EventHandler(this.checking);
            // 
            // F_Maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.LogDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LogSo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LogPo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LogUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.buttonBacc);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.panelGeneralOp);
            this.Controls.Add(this.panelDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Maker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Maker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Maker_Load);
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelGeneralOp.ResumeLayout(false);
            this.panelGeneralOp.PerformLayout();
            this.groupBoxHider.ResumeLayout(false);
            this.groupBoxHider.PerformLayout();
            this.panelHide.ResumeLayout(false);
            this.panelHideConfirm.ResumeLayout(false);
            this.DecisionPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSo;
        private System.Windows.Forms.Label label21;
        private RoundPanel panelHideConfirm;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private RoundPanel panelHide;
        private System.Windows.Forms.Button buttonHidCa;
        private System.Windows.Forms.Button buttonHidCo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private RoundPanel DecisionPanel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonUnHide;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Label labelFAX;
        private System.Windows.Forms.Label labelHiddenReason;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPostal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSoID;
        private System.Windows.Forms.Label labelSoName;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.RichTextBox richTextHideReason;
        private System.Windows.Forms.CheckBox checkHiddenToggle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSearchCa;
        private System.Windows.Forms.DataGridView dataGridMain;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonBacc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelGeneralOp;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.GroupBox groupBoxHider;
        private System.Windows.Forms.MaskedTextBox textBoxPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LogSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LogPo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LogUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.MaskedTextBox textBoxFAX;
    }
}