using System;

namespace Project_Iris
{
    partial class F_Hattyu
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelWarehousing = new System.Windows.Forms.Panel();
            this.buttonWarehousing = new System.Windows.Forms.Button();
            this.panelHattyu = new System.Windows.Forms.Panel();
            this.buttonHattyu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBacc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelWarehousing.SuspendLayout();
            this.panelHattyu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 142);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(1920, 938);
            this.DisplayPanel.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panelWarehousing, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelHattyu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 88);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panelWarehousing
            // 
            this.panelWarehousing.BackColor = System.Drawing.Color.Goldenrod;
            this.panelWarehousing.Controls.Add(this.buttonWarehousing);
            this.panelWarehousing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWarehousing.Location = new System.Drawing.Point(962, 3);
            this.panelWarehousing.Name = "panelWarehousing";
            this.panelWarehousing.Size = new System.Drawing.Size(955, 82);
            this.panelWarehousing.TabIndex = 1;
            // 
            // buttonWarehousing
            // 
            this.buttonWarehousing.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonWarehousing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWarehousing.FlatAppearance.BorderSize = 0;
            this.buttonWarehousing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWarehousing.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonWarehousing.ForeColor = System.Drawing.Color.Thistle;
            this.buttonWarehousing.Location = new System.Drawing.Point(0, 0);
            this.buttonWarehousing.Name = "buttonWarehousing";
            this.buttonWarehousing.Size = new System.Drawing.Size(955, 82);
            this.buttonWarehousing.TabIndex = 0;
            this.buttonWarehousing.Text = "入庫";
            this.buttonWarehousing.UseVisualStyleBackColor = false;
            this.buttonWarehousing.Click += new System.EventHandler(this.buttonWarehousing_Click);
            // 
            // panelHattyu
            // 
            this.panelHattyu.BackColor = System.Drawing.Color.Goldenrod;
            this.panelHattyu.Controls.Add(this.buttonHattyu);
            this.panelHattyu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHattyu.Location = new System.Drawing.Point(3, 3);
            this.panelHattyu.Name = "panelHattyu";
            this.panelHattyu.Size = new System.Drawing.Size(953, 82);
            this.panelHattyu.TabIndex = 0;
            // 
            // buttonHattyu
            // 
            this.buttonHattyu.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonHattyu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHattyu.FlatAppearance.BorderSize = 0;
            this.buttonHattyu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHattyu.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonHattyu.ForeColor = System.Drawing.Color.Thistle;
            this.buttonHattyu.Location = new System.Drawing.Point(0, 0);
            this.buttonHattyu.Name = "buttonHattyu";
            this.buttonHattyu.Size = new System.Drawing.Size(953, 82);
            this.buttonHattyu.TabIndex = 0;
            this.buttonHattyu.Text = "発注";
            this.buttonHattyu.UseVisualStyleBackColor = false;
            this.buttonHattyu.Click += new System.EventHandler(this.buttonHattyu_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Controls.Add(this.buttonBacc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1920, 54);
            this.panel3.TabIndex = 12;
            // 
            // buttonBacc
            // 
            this.buttonBacc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBacc.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonBacc.FlatAppearance.BorderSize = 0;
            this.buttonBacc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonBacc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonBacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBacc.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBacc.Location = new System.Drawing.Point(1705, 0);
            this.buttonBacc.Name = "buttonBacc";
            this.buttonBacc.Size = new System.Drawing.Size(215, 51);
            this.buttonBacc.TabIndex = 8;
            this.buttonBacc.Text = "↩  戻る";
            this.buttonBacc.UseVisualStyleBackColor = false;
            this.buttonBacc.Click += new System.EventHandler(this.buttonBacc_Click);
            // 
            // F_Hattyu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_Hattyu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Hattyu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelWarehousing.ResumeLayout(false);
            this.panelHattyu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelWarehousing;
        private System.Windows.Forms.Button buttonWarehousing;
        private System.Windows.Forms.Panel panelHattyu;
        private System.Windows.Forms.Button buttonHattyu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBacc;

    }
}

