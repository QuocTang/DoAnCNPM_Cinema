namespace QuanLyRapPhim
{
    partial class QTLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTLogin = new System.Windows.Forms.Button();
            this.BTExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.bgframe;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 90);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.bgframe;
            this.panel3.Controls.Add(this.TBPassWord);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 36);
            this.panel3.TabIndex = 1;
            // 
            // TBPassWord
            // 
            this.TBPassWord.Location = new System.Drawing.Point(134, 8);
            this.TBPassWord.Name = "TBPassWord";
            this.TBPassWord.Size = new System.Drawing.Size(243, 20);
            this.TBPassWord.TabIndex = 2;
            this.TBPassWord.UseSystemPasswordChar = true;
            this.TBPassWord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = global::QuanLyRapPhim.Properties.Resources.BG;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.bgframe;
            this.panel2.Controls.Add(this.TBUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 36);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(134, 8);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(243, 20);
            this.TBUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = global::QuanLyRapPhim.Properties.Resources.BG;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTLogin
            // 
            this.BTLogin.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.ddd;
            this.BTLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTLogin.Location = new System.Drawing.Point(225, 223);
            this.BTLogin.Name = "BTLogin";
            this.BTLogin.Size = new System.Drawing.Size(75, 23);
            this.BTLogin.TabIndex = 3;
            this.BTLogin.Text = "Đăng Nhập";
            this.BTLogin.UseVisualStyleBackColor = true;
            this.BTLogin.Click += new System.EventHandler(this.BTLogin_Click);
            // 
            // BTExit
            // 
            this.BTExit.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.ddd;
            this.BTExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTExit.Location = new System.Drawing.Point(317, 223);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(75, 23);
            this.BTExit.TabIndex = 4;
            this.BTExit.Text = "Thoát";
            this.BTExit.UseVisualStyleBackColor = true;
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::QuanLyRapPhim.Properties.Resources.BGLogin;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // QTLogin
            // 
            this.AcceptButton = this.BTLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.bgframe;
            this.CancelButton = this.BTExit;
            this.ClientSize = new System.Drawing.Size(434, 248);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTExit);
            this.Controls.Add(this.BTLogin);
            this.Controls.Add(this.panel1);
            this.Name = "QTLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QTLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TBPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Button BTLogin;
        private System.Windows.Forms.Button BTExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

