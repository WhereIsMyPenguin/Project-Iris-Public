
namespace Project_Iris
{
    partial class F_ProductManagement
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
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.buttonBacc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelClassify = new System.Windows.Forms.Panel();
            this.buttonClassify = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelClassify.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 150);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(1920, 930);
            this.DisplayPanel.TabIndex = 14;
            // 
            // buttonBacc
            // 
            this.buttonBacc.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonBacc.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBacc.FlatAppearance.BorderSize = 0;
            this.buttonBacc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonBacc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonBacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBacc.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBacc.Location = new System.Drawing.Point(1705, 0);
            this.buttonBacc.Name = "buttonBacc";
            this.buttonBacc.Size = new System.Drawing.Size(215, 56);
            this.buttonBacc.TabIndex = 8;
            this.buttonBacc.Text = "↩  戻る";
            this.buttonBacc.UseVisualStyleBackColor = false;
            this.buttonBacc.Click += new System.EventHandler(this.buttonBacc_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonBacc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 56);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 41);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "商品管理";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SlateBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panelClassify, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelProduct, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 95);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panelClassify
            // 
            this.panelClassify.BackColor = System.Drawing.Color.Goldenrod;
            this.panelClassify.Controls.Add(this.buttonClassify);
            this.panelClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClassify.Location = new System.Drawing.Point(962, 3);
            this.panelClassify.Name = "panelClassify";
            this.panelClassify.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelClassify.Size = new System.Drawing.Size(955, 89);
            this.panelClassify.TabIndex = 1;
            // 
            // buttonClassify
            // 
            this.buttonClassify.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClassify.FlatAppearance.BorderSize = 0;
            this.buttonClassify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassify.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClassify.ForeColor = System.Drawing.Color.Thistle;
            this.buttonClassify.Location = new System.Drawing.Point(0, 0);
            this.buttonClassify.Name = "buttonClassify";
            this.buttonClassify.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonClassify.Size = new System.Drawing.Size(955, 84);
            this.buttonClassify.TabIndex = 0;
            this.buttonClassify.Text = "分類";
            this.buttonClassify.UseVisualStyleBackColor = false;
            this.buttonClassify.Click += new System.EventHandler(this.buttonClassify_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.Goldenrod;
            this.panelProduct.Controls.Add(this.buttonProduct);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct.Location = new System.Drawing.Point(3, 3);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panelProduct.Size = new System.Drawing.Size(953, 89);
            this.panelProduct.TabIndex = 0;
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProduct.FlatAppearance.BorderSize = 0;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonProduct.ForeColor = System.Drawing.Color.Thistle;
            this.buttonProduct.Location = new System.Drawing.Point(0, 0);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.buttonProduct.Size = new System.Drawing.Size(953, 74);
            this.buttonProduct.TabIndex = 0;
            this.buttonProduct.Text = "商品";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // F_ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DisplayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ProductManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_ProductManagement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelClassify.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Button buttonBacc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelClassify;
        private System.Windows.Forms.Button buttonClassify;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Button buttonProduct;
    }
}