
namespace Project_Iris
{
    partial class F_EmployeeManagement
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
            this.buttonBacc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPosition = new System.Windows.Forms.Panel();
            this.buttonPosition = new System.Windows.Forms.Button();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPosition.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBacc
            // 
            this.buttonBacc.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonBacc.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBacc.FlatAppearance.BorderSize = 0;
            this.buttonBacc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonBacc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonBacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBacc.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBacc.Location = new System.Drawing.Point(1705, 0);
            this.buttonBacc.Name = "buttonBacc";
            this.buttonBacc.Size = new System.Drawing.Size(215, 55);
            this.buttonBacc.TabIndex = 8;
            this.buttonBacc.Text = "↩  戻る";
            this.buttonBacc.UseVisualStyleBackColor = false;
            this.buttonBacc.Click += new System.EventHandler(this.buttonBacc_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonBacc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 55);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 41);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "社員管理";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panelPosition, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEmployee, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 88);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panelPosition
            // 
            this.panelPosition.BackColor = System.Drawing.Color.Goldenrod;
            this.panelPosition.Controls.Add(this.buttonPosition);
            this.panelPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPosition.Location = new System.Drawing.Point(962, 3);
            this.panelPosition.Name = "panelPosition";
            this.panelPosition.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelPosition.Size = new System.Drawing.Size(955, 82);
            this.panelPosition.TabIndex = 1;
            // 
            // buttonPosition
            // 
            this.buttonPosition.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPosition.FlatAppearance.BorderSize = 0;
            this.buttonPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPosition.ForeColor = System.Drawing.Color.Thistle;
            this.buttonPosition.Location = new System.Drawing.Point(0, 0);
            this.buttonPosition.Name = "buttonPosition";
            this.buttonPosition.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonPosition.Size = new System.Drawing.Size(955, 77);
            this.buttonPosition.TabIndex = 0;
            this.buttonPosition.Text = "役職";
            this.buttonPosition.UseVisualStyleBackColor = false;
            this.buttonPosition.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.Color.Goldenrod;
            this.panelEmployee.Controls.Add(this.buttonEmployee);
            this.panelEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployee.Location = new System.Drawing.Point(3, 3);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.panelEmployee.Size = new System.Drawing.Size(953, 82);
            this.panelEmployee.TabIndex = 0;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEmployee.FlatAppearance.BorderSize = 0;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonEmployee.ForeColor = System.Drawing.Color.Thistle;
            this.buttonEmployee.Location = new System.Drawing.Point(0, 0);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.buttonEmployee.Size = new System.Drawing.Size(953, 68);
            this.buttonEmployee.TabIndex = 0;
            this.buttonEmployee.Text = "社員";
            this.buttonEmployee.UseVisualStyleBackColor = false;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 143);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(1920, 854);
            this.DisplayPanel.TabIndex = 11;
            this.DisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayPanel_Paint);
            // 
            // F_EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 997);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_EmployeeManagement";
            this.Text = "F_EmployeeManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_EmployeeManagement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelPosition.ResumeLayout(false);
            this.panelEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBacc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelPosition;
        private System.Windows.Forms.Button buttonPosition;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Label label2;
    }
}