
using System;

namespace Project_Iris
{
    partial class U_Warehousing
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDisplayTotal = new System.Windows.Forms.Label();
            this.labelIDView = new System.Windows.Forms.Label();
            this.buttonPrClear = new System.Windows.Forms.Button();
            this.buttonAddPr = new System.Windows.Forms.Button();
            this.dataGridDetail = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.SearchAsDate = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboSearchCa = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.checkHiddenToggle = new System.Windows.Forms.CheckBox();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.groupBoxHider = new System.Windows.Forms.GroupBox();
            this.panelHide = new System.Windows.Forms.Panel();
            this.buttonHidCo = new System.Windows.Forms.Button();
            this.buttonHidCa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUnHide = new System.Windows.Forms.Button();
            this.panelHideConfirm = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.richTextHideReason = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.groupBoxDesc = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkWaShelfFlag = new System.Windows.Forms.CheckBox();
            this.richTextDescHide = new System.Windows.Forms.RichTextBox();
            this.checkWaHide = new System.Windows.Forms.CheckBox();
            this.labelWaQuantity = new System.Windows.Forms.Label();
            this.labelWaDate = new System.Windows.Forms.Label();
            this.buttonCoWa = new System.Windows.Forms.Button();
            this.labelEmName = new System.Windows.Forms.Label();
            this.labelHaID = new System.Windows.Forms.Label();
            this.labelWaID = new System.Windows.Forms.Label();
            this.dataGridmain = new System.Windows.Forms.DataGridView();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.groupBoxHider.SuspendLayout();
            this.panelHide.SuspendLayout();
            this.panelHideConfirm.SuspendLayout();
            this.groupBoxDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.labelDisplayTotal);
            this.panel3.Controls.Add(this.labelIDView);
            this.panel3.Controls.Add(this.buttonPrClear);
            this.panel3.Controls.Add(this.buttonAddPr);
            this.panel3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.panel3.ForeColor = System.Drawing.Color.LightYellow;
            this.panel3.Location = new System.Drawing.Point(160, 499);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1322, 587);
            this.panel3.TabIndex = 61;
            // 
            // labelDisplayTotal
            // 
            this.labelDisplayTotal.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDisplayTotal.ForeColor = System.Drawing.Color.Black;
            this.labelDisplayTotal.Location = new System.Drawing.Point(421, 34);
            this.labelDisplayTotal.Name = "labelDisplayTotal";
            this.labelDisplayTotal.Size = new System.Drawing.Size(76, 31);
            this.labelDisplayTotal.TabIndex = 54;
            this.labelDisplayTotal.Text = "\\";
            // 
            // labelIDView
            // 
            this.labelIDView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDView.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelIDView.Location = new System.Drawing.Point(338, 38);
            this.labelIDView.Name = "labelIDView";
            this.labelIDView.Size = new System.Drawing.Size(129, 27);
            this.labelIDView.TabIndex = 53;
            this.labelIDView.Text = "番号：";
            // 
            // buttonPrClear
            // 
            this.buttonPrClear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonPrClear.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 16F);
            this.buttonPrClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonPrClear.Location = new System.Drawing.Point(201, 14);
            this.buttonPrClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrClear.Name = "buttonPrClear";
            this.buttonPrClear.Size = new System.Drawing.Size(131, 51);
            this.buttonPrClear.TabIndex = 18;
            this.buttonPrClear.Text = "クリア";
            this.buttonPrClear.UseVisualStyleBackColor = false;
            // 
            // buttonAddPr
            // 
            this.buttonAddPr.BackColor = System.Drawing.Color.Aqua;
            this.buttonAddPr.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 16F);
            this.buttonAddPr.ForeColor = System.Drawing.Color.Navy;
            this.buttonAddPr.Location = new System.Drawing.Point(48, 14);
            this.buttonAddPr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPr.Name = "buttonAddPr";
            this.buttonAddPr.Size = new System.Drawing.Size(131, 51);
            this.buttonAddPr.TabIndex = 18;
            this.buttonAddPr.Text = "確定";
            this.buttonAddPr.UseVisualStyleBackColor = false;
            // 
            // dataGridDetail
            // 
            this.dataGridDetail.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetail.Location = new System.Drawing.Point(339, -2);
            this.dataGridDetail.Name = "dataGridDetail";
            this.dataGridDetail.RowTemplate.Height = 21;
            this.dataGridDetail.Size = new System.Drawing.Size(357, 407);
            this.dataGridDetail.TabIndex = 73;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelSearch.Controls.Add(this.SearchAsDate);
            this.panelSearch.Controls.Add(this.label8);
            this.panelSearch.Controls.Add(this.comboSearchCa);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.dateTimeFrom);
            this.panelSearch.Controls.Add(this.label9);
            this.panelSearch.Controls.Add(this.checkHiddenToggle);
            this.panelSearch.Controls.Add(this.dateTimeTo);
            this.panelSearch.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9F);
            this.panelSearch.Location = new System.Drawing.Point(862, 342);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(620, 150);
            this.panelSearch.TabIndex = 72;
            // 
            // SearchAsDate
            // 
            this.SearchAsDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchAsDate.AutoSize = true;
            this.SearchAsDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchAsDate.Location = new System.Drawing.Point(72, 118);
            this.SearchAsDate.Name = "SearchAsDate";
            this.SearchAsDate.Size = new System.Drawing.Size(178, 26);
            this.SearchAsDate.TabIndex = 48;
            this.SearchAsDate.Text = "入庫年月日で絞る";
            this.SearchAsDate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 28);
            this.label8.TabIndex = 41;
            this.label8.Text = "検索";
            // 
            // comboSearchCa
            // 
            this.comboSearchCa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboSearchCa.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 15F);
            this.comboSearchCa.FormattingEnabled = true;
            this.comboSearchCa.IntegralHeight = false;
            this.comboSearchCa.ItemHeight = 25;
            this.comboSearchCa.Location = new System.Drawing.Point(75, 59);
            this.comboSearchCa.Margin = new System.Windows.Forms.Padding(4);
            this.comboSearchCa.Name = "comboSearchCa";
            this.comboSearchCa.Size = new System.Drawing.Size(226, 31);
            this.comboSearchCa.TabIndex = 42;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 15.75F);
            this.textBoxSearch.Location = new System.Drawing.Point(308, 57);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.MaximumSize = new System.Drawing.Size(1000, 100);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(100, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(208, 32);
            this.textBoxSearch.TabIndex = 45;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F);
            this.dateTimeFrom.Location = new System.Drawing.Point(257, 118);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(155, 26);
            this.dateTimeFrom.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(419, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 30);
            this.label9.TabIndex = 46;
            this.label9.Text = "～";
            // 
            // checkHiddenToggle
            // 
            this.checkHiddenToggle.AutoSize = true;
            this.checkHiddenToggle.Enabled = false;
            this.checkHiddenToggle.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F);
            this.checkHiddenToggle.Location = new System.Drawing.Point(75, 21);
            this.checkHiddenToggle.Name = "checkHiddenToggle";
            this.checkHiddenToggle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkHiddenToggle.Size = new System.Drawing.Size(122, 22);
            this.checkHiddenToggle.TabIndex = 44;
            this.checkHiddenToggle.Text = "非表示に切替";
            this.checkHiddenToggle.UseVisualStyleBackColor = true;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F);
            this.dateTimeTo.Location = new System.Drawing.Point(457, 118);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(155, 26);
            this.dateTimeTo.TabIndex = 47;
            // 
            // groupBoxHider
            // 
            this.groupBoxHider.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBoxHider.Controls.Add(this.panelHide);
            this.groupBoxHider.Controls.Add(this.panelHideConfirm);
            this.groupBoxHider.Controls.Add(this.richTextHideReason);
            this.groupBoxHider.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.groupBoxHider.Location = new System.Drawing.Point(342, 67);
            this.groupBoxHider.Name = "groupBoxHider";
            this.groupBoxHider.Size = new System.Drawing.Size(315, 281);
            this.groupBoxHider.TabIndex = 71;
            this.groupBoxHider.TabStop = false;
            this.groupBoxHider.Text = "非表示化理由";
            // 
            // panelHide
            // 
            this.panelHide.Controls.Add(this.buttonHidCo);
            this.panelHide.Controls.Add(this.buttonHidCa);
            this.panelHide.Controls.Add(this.button1);
            this.panelHide.Controls.Add(this.buttonUnHide);
            this.panelHide.Location = new System.Drawing.Point(5, 210);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(310, 54);
            this.panelHide.TabIndex = 59;
            // 
            // buttonHidCo
            // 
            this.buttonHidCo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonHidCo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F);
            this.buttonHidCo.ForeColor = System.Drawing.Color.Navy;
            this.buttonHidCo.Location = new System.Drawing.Point(6, 4);
            this.buttonHidCo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHidCo.Name = "buttonHidCo";
            this.buttonHidCo.Size = new System.Drawing.Size(148, 48);
            this.buttonHidCo.TabIndex = 2;
            this.buttonHidCo.Text = "確定";
            this.buttonHidCo.UseVisualStyleBackColor = false;
            // 
            // buttonHidCa
            // 
            this.buttonHidCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHidCa.BackColor = System.Drawing.Color.LightCoral;
            this.buttonHidCa.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F);
            this.buttonHidCa.ForeColor = System.Drawing.Color.Navy;
            this.buttonHidCa.Location = new System.Drawing.Point(157, 5);
            this.buttonHidCa.Name = "buttonHidCa";
            this.buttonHidCa.Size = new System.Drawing.Size(150, 47);
            this.buttonHidCa.TabIndex = 2;
            this.buttonHidCa.Text = "キャンセル";
            this.buttonHidCa.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(6, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 48);
            this.button1.TabIndex = 55;
            this.button1.Text = "表示";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonUnHide
            // 
            this.buttonUnHide.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonUnHide.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11F);
            this.buttonUnHide.ForeColor = System.Drawing.Color.Navy;
            this.buttonUnHide.Location = new System.Drawing.Point(6, 4);
            this.buttonUnHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnHide.Name = "buttonUnHide";
            this.buttonUnHide.Size = new System.Drawing.Size(148, 48);
            this.buttonUnHide.TabIndex = 56;
            this.buttonUnHide.Text = "非表示";
            this.buttonUnHide.UseVisualStyleBackColor = false;
            // 
            // panelHideConfirm
            // 
            this.panelHideConfirm.Controls.Add(this.label21);
            this.panelHideConfirm.Controls.Add(this.buttonYes);
            this.panelHideConfirm.Controls.Add(this.buttonNo);
            this.panelHideConfirm.Location = new System.Drawing.Point(5, 75);
            this.panelHideConfirm.Name = "panelHideConfirm";
            this.panelHideConfirm.Size = new System.Drawing.Size(310, 52);
            this.panelHideConfirm.TabIndex = 58;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 10.25F);
            this.label21.Location = new System.Drawing.Point(3, 2);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(287, 16);
            this.label21.TabIndex = 5;
            this.label21.Text = "本当に非表示化しますか？(巻き戻しできません)";
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.Turquoise;
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 11.25F);
            this.buttonYes.Location = new System.Drawing.Point(0, 23);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(150, 27);
            this.buttonYes.TabIndex = 37;
            this.buttonYes.Text = "はい";
            this.buttonYes.UseVisualStyleBackColor = false;
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
            this.buttonNo.Location = new System.Drawing.Point(160, 23);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(150, 27);
            this.buttonNo.TabIndex = 37;
            this.buttonNo.Text = "いいえ";
            this.buttonNo.UseVisualStyleBackColor = false;
            // 
            // richTextHideReason
            // 
            this.richTextHideReason.BackColor = System.Drawing.Color.White;
            this.richTextHideReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextHideReason.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextHideReason.Location = new System.Drawing.Point(5, 27);
            this.richTextHideReason.Name = "richTextHideReason";
            this.richTextHideReason.Size = new System.Drawing.Size(310, 177);
            this.richTextHideReason.TabIndex = 2;
            this.richTextHideReason.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(1132, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 66;
            this.label2.Text = "ログイン日時";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1177, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "営業所";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(1192, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 69;
            this.label7.Text = "権限";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(1097, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 70;
            this.label6.Text = "ログインユーザー";
            // 
            // ClockLabel
            // 
            this.ClockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(1092, 111);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(161, 50);
            this.ClockLabel.TabIndex = 64;
            this.ClockLabel.Text = "00 : 00";
            // 
            // groupBoxDesc
            // 
            this.groupBoxDesc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBoxDesc.Controls.Add(this.panel1);
            this.groupBoxDesc.Controls.Add(this.groupBoxHider);
            this.groupBoxDesc.Controls.Add(this.checkWaShelfFlag);
            this.groupBoxDesc.Controls.Add(this.richTextDescHide);
            this.groupBoxDesc.Controls.Add(this.checkWaHide);
            this.groupBoxDesc.Controls.Add(this.labelWaQuantity);
            this.groupBoxDesc.Controls.Add(this.labelWaDate);
            this.groupBoxDesc.Controls.Add(this.buttonCoWa);
            this.groupBoxDesc.Controls.Add(this.labelEmName);
            this.groupBoxDesc.Controls.Add(this.labelHaID);
            this.groupBoxDesc.Controls.Add(this.labelWaID);
            this.groupBoxDesc.Controls.Add(this.dataGridDetail);
            this.groupBoxDesc.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 14F);
            this.groupBoxDesc.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxDesc.Location = new System.Drawing.Point(160, 83);
            this.groupBoxDesc.Name = "groupBoxDesc";
            this.groupBoxDesc.Size = new System.Drawing.Size(696, 408);
            this.groupBoxDesc.TabIndex = 62;
            this.groupBoxDesc.TabStop = false;
            this.groupBoxDesc.Text = "入庫状況";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(702, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 411);
            this.panel1.TabIndex = 72;
            // 
            // checkWaShelfFlag
            // 
            this.checkWaShelfFlag.AutoSize = true;
            this.checkWaShelfFlag.Enabled = false;
            this.checkWaShelfFlag.Location = new System.Drawing.Point(205, 230);
            this.checkWaShelfFlag.Name = "checkWaShelfFlag";
            this.checkWaShelfFlag.Size = new System.Drawing.Size(124, 26);
            this.checkWaShelfFlag.TabIndex = 17;
            this.checkWaShelfFlag.Text = "未発注状態";
            this.checkWaShelfFlag.UseVisualStyleBackColor = true;
            // 
            // richTextDescHide
            // 
            this.richTextDescHide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextDescHide.Enabled = false;
            this.richTextDescHide.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F);
            this.richTextDescHide.Location = new System.Drawing.Point(18, 265);
            this.richTextDescHide.Name = "richTextDescHide";
            this.richTextDescHide.Size = new System.Drawing.Size(285, 65);
            this.richTextDescHide.TabIndex = 2;
            this.richTextDescHide.Text = "";
            // 
            // checkWaHide
            // 
            this.checkWaHide.AutoSize = true;
            this.checkWaHide.Enabled = false;
            this.checkWaHide.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 16F);
            this.checkWaHide.Location = new System.Drawing.Point(18, 230);
            this.checkWaHide.Name = "checkWaHide";
            this.checkWaHide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkWaHide.Size = new System.Drawing.Size(97, 29);
            this.checkWaHide.TabIndex = 1;
            this.checkWaHide.Text = "非表示";
            this.checkWaHide.UseVisualStyleBackColor = true;
            // 
            // labelWaQuantity
            // 
            this.labelWaQuantity.Enabled = false;
            this.labelWaQuantity.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelWaQuantity.Location = new System.Drawing.Point(31, 195);
            this.labelWaQuantity.Name = "labelWaQuantity";
            this.labelWaQuantity.Size = new System.Drawing.Size(34, 26);
            this.labelWaQuantity.TabIndex = 0;
            this.labelWaQuantity.Text = "--";
            // 
            // labelWaDate
            // 
            this.labelWaDate.Enabled = false;
            this.labelWaDate.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelWaDate.Location = new System.Drawing.Point(31, 160);
            this.labelWaDate.Name = "labelWaDate";
            this.labelWaDate.Size = new System.Drawing.Size(34, 26);
            this.labelWaDate.TabIndex = 0;
            this.labelWaDate.Text = "--";
            // 
            // buttonCoWa
            // 
            this.buttonCoWa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonCoWa.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 16F);
            this.buttonCoWa.ForeColor = System.Drawing.Color.Navy;
            this.buttonCoWa.Location = new System.Drawing.Point(18, 336);
            this.buttonCoWa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCoWa.Name = "buttonCoWa";
            this.buttonCoWa.Size = new System.Drawing.Size(285, 51);
            this.buttonCoWa.TabIndex = 16;
            this.buttonCoWa.Text = "入庫確定";
            this.buttonCoWa.UseVisualStyleBackColor = false;
            // 
            // labelEmName
            // 
            this.labelEmName.Enabled = false;
            this.labelEmName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelEmName.Location = new System.Drawing.Point(31, 117);
            this.labelEmName.Name = "labelEmName";
            this.labelEmName.Size = new System.Drawing.Size(34, 26);
            this.labelEmName.TabIndex = 0;
            this.labelEmName.Text = "--";
            // 
            // labelHaID
            // 
            this.labelHaID.Enabled = false;
            this.labelHaID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelHaID.Location = new System.Drawing.Point(31, 67);
            this.labelHaID.Name = "labelHaID";
            this.labelHaID.Size = new System.Drawing.Size(34, 26);
            this.labelHaID.TabIndex = 0;
            this.labelHaID.Text = "--";
            // 
            // labelWaID
            // 
            this.labelWaID.Enabled = false;
            this.labelWaID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F);
            this.labelWaID.Location = new System.Drawing.Point(30, 27);
            this.labelWaID.Name = "labelWaID";
            this.labelWaID.Size = new System.Drawing.Size(34, 26);
            this.labelWaID.TabIndex = 0;
            this.labelWaID.Text = "--";
            // 
            // dataGridmain
            // 
            this.dataGridmain.AllowUserToAddRows = false;
            this.dataGridmain.AllowUserToDeleteRows = false;
            this.dataGridmain.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridmain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridmain.ColumnHeadersHeight = 25;
            this.dataGridmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridmain.Location = new System.Drawing.Point(160, 498);
            this.dataGridmain.Name = "dataGridmain";
            this.dataGridmain.RowTemplate.Height = 21;
            this.dataGridmain.Size = new System.Drawing.Size(1322, 588);
            this.dataGridmain.TabIndex = 65;
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            // 
            // U_Warehousing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.groupBoxDesc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridmain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "U_Warehousing";
            this.Size = new System.Drawing.Size(1600, 930);
            this.Load += new System.EventHandler(this.U_Warehousing_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.groupBoxHider.ResumeLayout(false);
            this.panelHide.ResumeLayout(false);
            this.panelHideConfirm.ResumeLayout(false);
            this.panelHideConfirm.PerformLayout();
            this.groupBoxDesc.ResumeLayout(false);
            this.groupBoxDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelIDView;
        private System.Windows.Forms.Button buttonPrClear;
        private System.Windows.Forms.Button buttonAddPr;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.CheckBox SearchAsDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboSearchCa;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkHiddenToggle;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.GroupBox groupBoxHider;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.Button buttonHidCo;
        private System.Windows.Forms.Button buttonHidCa;
        private System.Windows.Forms.Panel panelHideConfirm;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.RichTextBox richTextHideReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.GroupBox groupBoxDesc;
        private System.Windows.Forms.CheckBox checkWaShelfFlag;
        private System.Windows.Forms.RichTextBox richTextDescHide;
        private System.Windows.Forms.CheckBox checkWaHide;
        private System.Windows.Forms.Label labelWaQuantity;
        private System.Windows.Forms.Label labelWaDate;
        private System.Windows.Forms.Label labelEmName;
        private System.Windows.Forms.Label labelHaID;
        private System.Windows.Forms.Label labelWaID;
        private System.Windows.Forms.DataGridView dataGridmain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCoWa;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.DataGridView dataGridDetail;
        private System.Windows.Forms.Label labelDisplayTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUnHide;
    }
}
