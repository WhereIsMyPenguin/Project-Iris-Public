namespace Project_Iris
{
    partial class F_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkOpenRegister = new System.Windows.Forms.LinkLabel();
            this.roundPanel1 = new Project_Iris.RoundPanel();
            this.roundPanel4 = new Project_Iris.RoundPanel();
            this.roundPanel3 = new Project_Iris.RoundPanel();
            this.defaultExt = new Project_Iris.DefaultRound();
            this.defaultLogin = new Project_Iris.DefaultRound();
            this.roundPanel2 = new Project_Iris.RoundPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "ログインフォーム";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(179, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "社員ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(179, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "パスワード";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBox1.Location = new System.Drawing.Point(10, 7);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 32);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaShell;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBox2.Location = new System.Drawing.Point(10, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 32);
            this.textBox2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_Iris.Properties.Resources.Password;
            this.pictureBox2.Location = new System.Drawing.Point(55, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Iris.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(55, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkOpenRegister
            // 
            this.linkOpenRegister.AutoSize = true;
            this.linkOpenRegister.Font = new System.Drawing.Font("Meiryo", 12F);
            this.linkOpenRegister.LinkColor = System.Drawing.Color.Gold;
            this.linkOpenRegister.Location = new System.Drawing.Point(195, 165);
            this.linkOpenRegister.Name = "linkOpenRegister";
            this.linkOpenRegister.Size = new System.Drawing.Size(272, 24);
            this.linkOpenRegister.TabIndex = 3;
            this.linkOpenRegister.TabStop = true;
            this.linkOpenRegister.Text = "! データベースが作られていません !";
            this.linkOpenRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // roundPanel1
            // 
            this.roundPanel1.Angle = 45F;
            this.roundPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.roundPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundPanel1.BorderCurve = 30;
            this.roundPanel1.BorderSize = 0;
            this.roundPanel1.Controls.Add(this.roundPanel4);
            this.roundPanel1.Controls.Add(this.roundPanel3);
            this.roundPanel1.Controls.Add(this.label3);
            this.roundPanel1.Controls.Add(this.defaultExt);
            this.roundPanel1.Controls.Add(this.defaultLogin);
            this.roundPanel1.Controls.Add(this.pictureBox1);
            this.roundPanel1.Controls.Add(this.linkOpenRegister);
            this.roundPanel1.Controls.Add(this.pictureBox2);
            this.roundPanel1.Controls.Add(this.label2);
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundPanel1.Location = new System.Drawing.Point(0, 135);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(503, 489);
            this.roundPanel1.TabIndex = 8;
            // 
            // roundPanel4
            // 
            this.roundPanel4.Angle = 45F;
            this.roundPanel4.BackColor = System.Drawing.Color.SeaShell;
            this.roundPanel4.BorderColor = System.Drawing.Color.Black;
            this.roundPanel4.BorderCurve = 20;
            this.roundPanel4.BorderSize = 0;
            this.roundPanel4.Controls.Add(this.textBox1);
            this.roundPanel4.Location = new System.Drawing.Point(185, 235);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.roundPanel4.Size = new System.Drawing.Size(295, 40);
            this.roundPanel4.TabIndex = 10;
            // 
            // roundPanel3
            // 
            this.roundPanel3.Angle = 45F;
            this.roundPanel3.BackColor = System.Drawing.Color.SeaShell;
            this.roundPanel3.BorderColor = System.Drawing.Color.Black;
            this.roundPanel3.BorderCurve = 20;
            this.roundPanel3.BorderSize = 0;
            this.roundPanel3.Controls.Add(this.textBox2);
            this.roundPanel3.Location = new System.Drawing.Point(180, 80);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.roundPanel3.Size = new System.Drawing.Size(295, 40);
            this.roundPanel3.TabIndex = 9;
            // 
            // defaultExt
            // 
            this.defaultExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultExt.BackColor = System.Drawing.Color.SeaShell;
            this.defaultExt.BackgroundColor = System.Drawing.Color.SeaShell;
            this.defaultExt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.defaultExt.BorderCurve = 30;
            this.defaultExt.BorderSize = 0;
            this.defaultExt.FlatAppearance.BorderSize = 0;
            this.defaultExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultExt.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.defaultExt.ForeColor = System.Drawing.Color.Crimson;
            this.defaultExt.Location = new System.Drawing.Point(15, 415);
            this.defaultExt.Name = "defaultExt";
            this.defaultExt.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.defaultExt.Size = new System.Drawing.Size(475, 60);
            this.defaultExt.TabIndex = 5;
            this.defaultExt.Text = "閉じる";
            this.defaultExt.TextColor = System.Drawing.Color.Crimson;
            this.defaultExt.UseVisualStyleBackColor = false;
            this.defaultExt.Click += new System.EventHandler(this.button2_Click);
            // 
            // defaultLogin
            // 
            this.defaultLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultLogin.BackColor = System.Drawing.Color.SeaShell;
            this.defaultLogin.BackgroundColor = System.Drawing.Color.SeaShell;
            this.defaultLogin.BorderColor = System.Drawing.Color.DarkOrchid;
            this.defaultLogin.BorderCurve = 30;
            this.defaultLogin.BorderSize = 0;
            this.defaultLogin.FlatAppearance.BorderSize = 0;
            this.defaultLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultLogin.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.defaultLogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.defaultLogin.Location = new System.Drawing.Point(15, 340);
            this.defaultLogin.Name = "defaultLogin";
            this.defaultLogin.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.defaultLogin.Size = new System.Drawing.Size(475, 60);
            this.defaultLogin.TabIndex = 4;
            this.defaultLogin.Text = "ログイン";
            this.defaultLogin.TextColor = System.Drawing.Color.DarkBlue;
            this.defaultLogin.UseVisualStyleBackColor = false;
            this.defaultLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundPanel2
            // 
            this.roundPanel2.Angle = 45F;
            this.roundPanel2.BackColor = System.Drawing.Color.SeaShell;
            this.roundPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundPanel2.BorderCurve = 30;
            this.roundPanel2.BorderSize = 0;
            this.roundPanel2.Controls.Add(this.label1);
            this.roundPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundPanel2.Location = new System.Drawing.Point(0, 0);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(503, 135);
            this.roundPanel2.TabIndex = 9;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(503, 624);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "販売管理システムログイン画面";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.F_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel4.ResumeLayout(false);
            this.roundPanel4.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkOpenRegister;
        private RoundPanel roundPanel1;
        private DefaultRound defaultExt;
        private DefaultRound defaultLogin;
        private RoundPanel roundPanel2;
        private RoundPanel roundPanel4;
        private RoundPanel roundPanel3;
    }
}

