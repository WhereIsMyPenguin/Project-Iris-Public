
namespace Project_Iris
{
    partial class F_Shipment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCoSh = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.buttonBacc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDesc = new System.Windows.Forms.GroupBox();
            this.labelOrID = new System.Windows.Forms.Label();
            this.richTextDescHide = new System.Windows.Forms.RichTextBox();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.checkBoxSh = new System.Windows.Forms.CheckBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClID = new System.Windows.Forms.Label();
            this.labelEmID = new System.Windows.Forms.Label();
            this.labelSoID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonUnHide = new System.Windows.Forms.Button();
            this.richTextHideReason = new System.Windows.Forms.RichTextBox();
            this.groupBoxHider = new System.Windows.Forms.GroupBox();
            this.panelHide = new Project_Iris.RoundPanel();
            this.buttonHidCa = new System.Windows.Forms.Button();
            this.buttonHidCo = new System.Windows.Forms.Button();
            this.LogDate = new System.Windows.Forms.Label();
            this.LogSo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LogPo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LogUser = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.SearchAsDate = new System.Windows.Forms.CheckBox();
            this.checkHiddenToggle = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSearchCa = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.labelDisplayTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridDetail = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBoxDesc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxHider.SuspendLayout();
            this.panelHide.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCoSh
            // 
            this.buttonCoSh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCoSh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCoSh.FlatAppearance.BorderSize = 0;
            this.buttonCoSh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCoSh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCoSh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCoSh.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21F);
            this.buttonCoSh.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCoSh.Location = new System.Drawing.Point(35, 380);
            this.buttonCoSh.Name = "buttonCoSh";
            this.buttonCoSh.Size = new System.Drawing.Size(256, 60);
            this.buttonCoSh.TabIndex = 1;
            this.buttonCoSh.Text = "出荷確定";
            this.buttonCoSh.UseVisualStyleBackColor = false;
            this.buttonCoSh.Click += new System.EventHandler(this.buttonCoOr_Click);
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // buttonBacc
            // 
            this.buttonBacc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBacc.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonBacc.FlatAppearance.BorderSize = 0;
            this.buttonBacc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.buttonBacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBacc.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBacc.Location = new System.Drawing.Point(1690, 0);
            this.buttonBacc.Name = "buttonBacc";
            this.buttonBacc.Size = new System.Drawing.Size(215, 65);
            this.buttonBacc.TabIndex = 13;
            this.buttonBacc.Text = "↩  戻る";
            this.buttonBacc.UseVisualStyleBackColor = false;
            this.buttonBacc.Click += new System.EventHandler(this.buttonBacc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "出荷管理";
            // 
            // groupBoxDesc
            // 
            this.groupBoxDesc.Controls.Add(this.labelOrID);
            this.groupBoxDesc.Controls.Add(this.richTextDescHide);
            this.groupBoxDesc.Controls.Add(this.checkBoxHide);
            this.groupBoxDesc.Controls.Add(this.checkBoxSh);
            this.groupBoxDesc.Controls.Add(this.labelDate);
            this.groupBoxDesc.Controls.Add(this.labelClID);
            this.groupBoxDesc.Controls.Add(this.labelEmID);
            this.groupBoxDesc.Controls.Add(this.labelSoID);
            this.groupBoxDesc.Controls.Add(this.buttonCoSh);
            this.groupBoxDesc.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 21.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxDesc.Location = new System.Drawing.Point(14, 76);
            this.groupBoxDesc.Name = "groupBoxDesc";
            this.groupBoxDesc.Size = new System.Drawing.Size(321, 451);
            this.groupBoxDesc.TabIndex = 47;
            this.groupBoxDesc.TabStop = false;
            this.groupBoxDesc.Text = "概要";
            // 
            // labelOrID
            // 
            this.labelOrID.AutoSize = true;
            this.labelOrID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelOrID.Location = new System.Drawing.Point(15, 155);
            this.labelOrID.Name = "labelOrID";
            this.labelOrID.Size = new System.Drawing.Size(34, 24);
            this.labelOrID.TabIndex = 3;
            this.labelOrID.Text = "--";
            // 
            // richTextDescHide
            // 
            this.richTextDescHide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextDescHide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextDescHide.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 14.25F, System.Drawing.FontStyle.Bold);
            this.richTextDescHide.Location = new System.Drawing.Point(35, 265);
            this.richTextDescHide.Name = "richTextDescHide";
            this.richTextDescHide.ReadOnly = true;
            this.richTextDescHide.Size = new System.Drawing.Size(256, 103);
            this.richTextDescHide.TabIndex = 2;
            this.richTextDescHide.Text = "";
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Enabled = false;
            this.checkBoxHide.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxHide.Location = new System.Drawing.Point(33, 238);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxHide.Size = new System.Drawing.Size(80, 21);
            this.checkBoxHide.TabIndex = 1;
            this.checkBoxHide.Text = "非表示　";
            this.checkBoxHide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxHide.UseVisualStyleBackColor = true;
            // 
            // checkBoxSh
            // 
            this.checkBoxSh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSh.AutoSize = true;
            this.checkBoxSh.Enabled = false;
            this.checkBoxSh.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxSh.Location = new System.Drawing.Point(196, 238);
            this.checkBoxSh.Name = "checkBoxSh";
            this.checkBoxSh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxSh.Size = new System.Drawing.Size(95, 21);
            this.checkBoxSh.TabIndex = 1;
            this.checkBoxSh.Text = "出荷状態　";
            this.checkBoxSh.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelDate.Location = new System.Drawing.Point(15, 190);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(34, 24);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "--";
            // 
            // labelClID
            // 
            this.labelClID.AutoSize = true;
            this.labelClID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelClID.Location = new System.Drawing.Point(15, 120);
            this.labelClID.Name = "labelClID";
            this.labelClID.Size = new System.Drawing.Size(34, 24);
            this.labelClID.TabIndex = 0;
            this.labelClID.Text = "--";
            // 
            // labelEmID
            // 
            this.labelEmID.AutoSize = true;
            this.labelEmID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelEmID.Location = new System.Drawing.Point(15, 82);
            this.labelEmID.Name = "labelEmID";
            this.labelEmID.Size = new System.Drawing.Size(34, 24);
            this.labelEmID.TabIndex = 0;
            this.labelEmID.Text = "--";
            // 
            // labelSoID
            // 
            this.labelSoID.AutoSize = true;
            this.labelSoID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelSoID.Location = new System.Drawing.Point(15, 50);
            this.labelSoID.Name = "labelSoID";
            this.labelSoID.Size = new System.Drawing.Size(34, 24);
            this.labelSoID.TabIndex = 0;
            this.labelSoID.Text = "--";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 68);
            this.panel2.TabIndex = 55;
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonHide.FlatAppearance.BorderSize = 0;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonHide.Location = new System.Drawing.Point(1225, 110);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(320, 70);
            this.buttonHide.TabIndex = 59;
            this.buttonHide.Text = "取り消し";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonUnHide
            // 
            this.buttonUnHide.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonUnHide.FlatAppearance.BorderSize = 0;
            this.buttonUnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnHide.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold);
            this.buttonUnHide.Location = new System.Drawing.Point(1225, 110);
            this.buttonUnHide.Name = "buttonUnHide";
            this.buttonUnHide.Size = new System.Drawing.Size(320, 70);
            this.buttonUnHide.TabIndex = 58;
            this.buttonUnHide.Text = "復元";
            this.buttonUnHide.UseVisualStyleBackColor = false;
            this.buttonUnHide.Click += new System.EventHandler(this.buttonUnHide_Click);
            // 
            // richTextHideReason
            // 
            this.richTextHideReason.BackColor = System.Drawing.Color.White;
            this.richTextHideReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextHideReason.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextHideReason.Location = new System.Drawing.Point(5, 27);
            this.richTextHideReason.Name = "richTextHideReason";
            this.richTextHideReason.Size = new System.Drawing.Size(310, 146);
            this.richTextHideReason.TabIndex = 2;
            this.richTextHideReason.Text = "";
            // 
            // groupBoxHider
            // 
            this.groupBoxHider.Controls.Add(this.richTextHideReason);
            this.groupBoxHider.Controls.Add(this.panelHide);
            this.groupBoxHider.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.groupBoxHider.Location = new System.Drawing.Point(1230, 189);
            this.groupBoxHider.Name = "groupBoxHider";
            this.groupBoxHider.Size = new System.Drawing.Size(315, 233);
            this.groupBoxHider.TabIndex = 57;
            this.groupBoxHider.TabStop = false;
            this.groupBoxHider.Text = "取り消し理由";
            // 
            // panelHide
            // 
            this.panelHide.Angle = 45F;
            this.panelHide.BorderColor = System.Drawing.Color.Black;
            this.panelHide.BorderCurve = 20;
            this.panelHide.BorderSize = 0;
            this.panelHide.Controls.Add(this.buttonHidCa);
            this.panelHide.Controls.Add(this.buttonHidCo);
            this.panelHide.Location = new System.Drawing.Point(5, 179);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(305, 49);
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
            this.buttonHidCa.Location = new System.Drawing.Point(155, 1);
            this.buttonHidCa.Name = "buttonHidCa";
            this.buttonHidCa.Size = new System.Drawing.Size(150, 49);
            this.buttonHidCa.TabIndex = 2;
            this.buttonHidCa.Text = "キャンセル";
            this.buttonHidCa.UseVisualStyleBackColor = false;
            this.buttonHidCa.Click += new System.EventHandler(this.buttonHidCa_Click);
            // 
            // buttonHidCo
            // 
            this.buttonHidCo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonHidCo.FlatAppearance.BorderSize = 0;
            this.buttonHidCo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonHidCo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHidCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHidCo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.buttonHidCo.Location = new System.Drawing.Point(1, 1);
            this.buttonHidCo.Name = "buttonHidCo";
            this.buttonHidCo.Size = new System.Drawing.Size(150, 49);
            this.buttonHidCo.TabIndex = 3;
            this.buttonHidCo.Text = "確定";
            this.buttonHidCo.UseVisualStyleBackColor = false;
            this.buttonHidCo.Click += new System.EventHandler(this.buttonHidCo_Click);
            // 
            // LogDate
            // 
            this.LogDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogDate.AutoSize = true;
            this.LogDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogDate.Location = new System.Drawing.Point(1730, 345);
            this.LogDate.Name = "LogDate";
            this.LogDate.Size = new System.Drawing.Size(112, 22);
            this.LogDate.TabIndex = 61;
            this.LogDate.Text = "ログイン日時";
            // 
            // LogSo
            // 
            this.LogSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogSo.AutoSize = true;
            this.LogSo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogSo.Location = new System.Drawing.Point(1730, 305);
            this.LogSo.Name = "LogSo";
            this.LogSo.Size = new System.Drawing.Size(67, 22);
            this.LogSo.TabIndex = 62;
            this.LogSo.Text = "営業所";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(1610, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 63;
            this.label9.Text = "ログイン日時";
            // 
            // LogPo
            // 
            this.LogPo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPo.AutoSize = true;
            this.LogPo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogPo.Location = new System.Drawing.Point(1725, 265);
            this.LogPo.Name = "LogPo";
            this.LogPo.Size = new System.Drawing.Size(48, 22);
            this.LogPo.TabIndex = 64;
            this.LogPo.Text = "権限";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(1655, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 65;
            this.label8.Text = "営業所";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(1670, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 66;
            this.label7.Text = "権限";
            // 
            // LogUser
            // 
            this.LogUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogUser.AutoSize = true;
            this.LogUser.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogUser.Location = new System.Drawing.Point(1725, 220);
            this.LogUser.Name = "LogUser";
            this.LogUser.Size = new System.Drawing.Size(145, 22);
            this.LogUser.TabIndex = 67;
            this.LogUser.Text = "ログインユーザー";
            // 
            // ClockLabel
            // 
            this.ClockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(1610, 110);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(161, 50);
            this.ClockLabel.TabIndex = 68;
            this.ClockLabel.Text = "00 : 00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(1575, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 69;
            this.label6.Text = "ログインユーザー";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimeTo);
            this.panel1.Controls.Add(this.dateTimeFrom);
            this.panel1.Controls.Add(this.SearchAsDate);
            this.panel1.Controls.Add(this.checkHiddenToggle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboSearchCa);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.panel1.Location = new System.Drawing.Point(340, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 70);
            this.panel1.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1258, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "~";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeTo.CalendarFont = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimeTo.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold);
            this.dateTimeTo.Location = new System.Drawing.Point(1298, 20);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(225, 32);
            this.dateTimeTo.TabIndex = 13;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.GenerateFilter);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeFrom.CalendarFont = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimeFrom.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimeFrom.Location = new System.Drawing.Point(1023, 21);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(225, 32);
            this.dateTimeFrom.TabIndex = 12;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.GenerateFilter);
            // 
            // SearchAsDate
            // 
            this.SearchAsDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchAsDate.AutoSize = true;
            this.SearchAsDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchAsDate.Location = new System.Drawing.Point(823, 25);
            this.SearchAsDate.Name = "SearchAsDate";
            this.SearchAsDate.Size = new System.Drawing.Size(178, 26);
            this.SearchAsDate.TabIndex = 11;
            this.SearchAsDate.Text = "取引終了日で絞る";
            this.SearchAsDate.UseVisualStyleBackColor = true;
            this.SearchAsDate.CheckedChanged += new System.EventHandler(this.GenerateFilter);
            // 
            // checkHiddenToggle
            // 
            this.checkHiddenToggle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkHiddenToggle.AutoSize = true;
            this.checkHiddenToggle.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkHiddenToggle.Location = new System.Drawing.Point(623, 25);
            this.checkHiddenToggle.Name = "checkHiddenToggle";
            this.checkHiddenToggle.Size = new System.Drawing.Size(171, 26);
            this.checkHiddenToggle.TabIndex = 10;
            this.checkHiddenToggle.Text = "非表示に切り替え";
            this.checkHiddenToggle.UseVisualStyleBackColor = true;
            this.checkHiddenToggle.CheckedChanged += new System.EventHandler(this.GenerateFilter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "検索";
            // 
            // comboSearchCa
            // 
            this.comboSearchCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchCa.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboSearchCa.FormattingEnabled = true;
            this.comboSearchCa.Items.AddRange(new object[] {
            "選択なし",
            "受注番号",
            "営業所名",
            "社員名",
            "顧客名",
            "顧客担当者名"});
            this.comboSearchCa.Location = new System.Drawing.Point(83, 15);
            this.comboSearchCa.Name = "comboSearchCa";
            this.comboSearchCa.Size = new System.Drawing.Size(150, 39);
            this.comboSearchCa.TabIndex = 4;
            this.comboSearchCa.SelectedIndexChanged += new System.EventHandler(this.GenerateFilter);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxSearch.Location = new System.Drawing.Point(256, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(295, 39);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.GenerateFilter);
            // 
            // dataGridMain
            // 
            this.dataGridMain.AllowUserToAddRows = false;
            this.dataGridMain.AllowUserToDeleteRows = false;
            this.dataGridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMain.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMain.ColumnHeadersHeight = 25;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMain.GridColor = System.Drawing.Color.DarkOrchid;
            this.dataGridMain.Location = new System.Drawing.Point(15, 535);
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.RowHeadersVisible = false;
            this.dataGridMain.RowTemplate.Height = 25;
            this.dataGridMain.Size = new System.Drawing.Size(1875, 550);
            this.dataGridMain.TabIndex = 13;
            this.dataGridMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellClick);
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.Controls.Add(this.labelDisplayTotal);
            this.panelDetail.Controls.Add(this.label2);
            this.panelDetail.Controls.Add(this.dataGridDetail);
            this.panelDetail.Controls.Add(this.label19);
            this.panelDetail.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panelDetail.Location = new System.Drawing.Point(340, 85);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(851, 374);
            this.panelDetail.TabIndex = 71;
            // 
            // labelDisplayTotal
            // 
            this.labelDisplayTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDisplayTotal.AutoSize = true;
            this.labelDisplayTotal.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDisplayTotal.Location = new System.Drawing.Point(535, 330);
            this.labelDisplayTotal.Name = "labelDisplayTotal";
            this.labelDisplayTotal.Size = new System.Drawing.Size(49, 37);
            this.labelDisplayTotal.TabIndex = 2;
            this.labelDisplayTotal.Text = "¥0";
            this.labelDisplayTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(480, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "合計";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridDetail
            // 
            this.dataGridDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDetail.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDetail.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridDetail.GridColor = System.Drawing.Color.LightGray;
            this.dataGridDetail.Location = new System.Drawing.Point(16, 35);
            this.dataGridDetail.Name = "dataGridDetail";
            this.dataGridDetail.RowHeadersVisible = false;
            this.dataGridDetail.RowTemplate.Height = 25;
            this.dataGridDetail.Size = new System.Drawing.Size(819, 282);
            this.dataGridDetail.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(20, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 28);
            this.label19.TabIndex = 0;
            this.label19.Text = "詳細";
            // 
            // F_Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1100);
            this.Controls.Add(this.buttonBacc);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.dataGridMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogDate);
            this.Controls.Add(this.LogSo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LogPo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LogUser);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBoxHider);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonUnHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Shipment";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Shipment_Load);
            this.groupBoxDesc.ResumeLayout(false);
            this.groupBoxDesc.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxHider.ResumeLayout(false);
            this.panelHide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundPanel panelHide;
        private System.Windows.Forms.Button buttonHidCa;
        private System.Windows.Forms.Button buttonHidCo;
        private System.Windows.Forms.Button buttonCoSh;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Button buttonBacc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDesc;
        private System.Windows.Forms.Label labelOrID;
        private System.Windows.Forms.RichTextBox richTextDescHide;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.CheckBox checkBoxSh;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelClID;
        private System.Windows.Forms.Label labelEmID;
        private System.Windows.Forms.Label labelSoID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonUnHide;
        private System.Windows.Forms.RichTextBox richTextHideReason;
        private System.Windows.Forms.GroupBox groupBoxHider;
        private System.Windows.Forms.Label LogDate;
        private System.Windows.Forms.Label LogSo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LogPo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LogUser;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.CheckBox SearchAsDate;
        private System.Windows.Forms.CheckBox checkHiddenToggle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSearchCa;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridMain;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label labelDisplayTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridDetail;
        private System.Windows.Forms.Label label19;
    }
}