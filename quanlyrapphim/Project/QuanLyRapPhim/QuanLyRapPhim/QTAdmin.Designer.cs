namespace QuanLyRapPhim
{
    partial class QTAdmin
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
            this.TCAdmin = new System.Windows.Forms.TabControl();
            this.TCBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTViewBill = new System.Windows.Forms.Button();
            this.DTTP1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTGVBill = new System.Windows.Forms.DataGridView();
            this.TCPhim = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TBTenPhim = new System.Windows.Forms.TextBox();
            this.BTSearchPhim = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.NRPhim = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TBIdPhim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DTGVPhim = new System.Windows.Forms.DataGridView();
            this.TCAccount = new System.Windows.Forms.TabPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.DTGVAccount = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.BTViewAccount = new System.Windows.Forms.Button();
            this.BTEditAccount = new System.Windows.Forms.Button();
            this.BTDeleteAccount = new System.Windows.Forms.Button();
            this.BTAddAccount = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BTResetPassWord = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.CBAccountType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.TBDisplayName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TCAdmin.SuspendLayout();
            this.TCBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVBill)).BeginInit();
            this.TCPhim.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NRPhim)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVPhim)).BeginInit();
            this.TCAccount.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVAccount)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCAdmin
            // 
            this.TCAdmin.Controls.Add(this.TCBill);
            this.TCAdmin.Controls.Add(this.TCPhim);
            this.TCAdmin.Controls.Add(this.TCAccount);
            this.TCAdmin.Location = new System.Drawing.Point(12, 12);
            this.TCAdmin.Name = "TCAdmin";
            this.TCAdmin.SelectedIndex = 0;
            this.TCAdmin.Size = new System.Drawing.Size(651, 318);
            this.TCAdmin.TabIndex = 0;
            this.TCAdmin.SelectedIndexChanged += new System.EventHandler(this.TCAdmin_SelectedIndexChanged);
            // 
            // TCBill
            // 
            this.TCBill.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.BG;
            this.TCBill.Controls.Add(this.panel2);
            this.TCBill.Controls.Add(this.panel1);
            this.TCBill.Location = new System.Drawing.Point(4, 22);
            this.TCBill.Name = "TCBill";
            this.TCBill.Padding = new System.Windows.Forms.Padding(3);
            this.TCBill.Size = new System.Drawing.Size(643, 292);
            this.TCBill.TabIndex = 0;
            this.TCBill.Text = "Doanh Thu";
            this.TCBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.BTViewBill);
            this.panel2.Controls.Add(this.DTTP1);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 47);
            this.panel2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // BTViewBill
            // 
            this.BTViewBill.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTViewBill.ForeColor = System.Drawing.Color.Red;
            this.BTViewBill.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.BTViewBill.Location = new System.Drawing.Point(156, 3);
            this.BTViewBill.Name = "BTViewBill";
            this.BTViewBill.Size = new System.Drawing.Size(75, 23);
            this.BTViewBill.TabIndex = 2;
            this.BTViewBill.Text = "Thống kê";
            this.BTViewBill.UseVisualStyleBackColor = true;
            // 
            // DTTP1
            // 
            this.DTTP1.Location = new System.Drawing.Point(3, 3);
            this.DTTP1.Name = "DTTP1";
            this.DTTP1.Size = new System.Drawing.Size(147, 20);
            this.DTTP1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTGVBill);
            this.panel1.Location = new System.Drawing.Point(6, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 224);
            this.panel1.TabIndex = 0;
            // 
            // DTGVBill
            // 
            this.DTGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVBill.Location = new System.Drawing.Point(3, 3);
            this.DTGVBill.Name = "DTGVBill";
            this.DTGVBill.Size = new System.Drawing.Size(443, 219);
            this.DTGVBill.TabIndex = 0;
            // 
            // TCPhim
            // 
            this.TCPhim.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.BG;
            this.TCPhim.Controls.Add(this.panel6);
            this.TCPhim.Controls.Add(this.panel5);
            this.TCPhim.Controls.Add(this.panel4);
            this.TCPhim.Controls.Add(this.panel3);
            this.TCPhim.Location = new System.Drawing.Point(4, 22);
            this.TCPhim.Name = "TCPhim";
            this.TCPhim.Padding = new System.Windows.Forms.Padding(3);
            this.TCPhim.Size = new System.Drawing.Size(643, 292);
            this.TCPhim.TabIndex = 1;
            this.TCPhim.Text = "Phim";
            this.TCPhim.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TBTenPhim);
            this.panel6.Controls.Add(this.BTSearchPhim);
            this.panel6.Location = new System.Drawing.Point(336, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 44);
            this.panel6.TabIndex = 3;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // TBTenPhim
            // 
            this.TBTenPhim.Location = new System.Drawing.Point(10, 13);
            this.TBTenPhim.Name = "TBTenPhim";
            this.TBTenPhim.Size = new System.Drawing.Size(197, 20);
            this.TBTenPhim.TabIndex = 2;
            this.TBTenPhim.TextChanged += new System.EventHandler(this.TBTenPhim_TextChanged);
            // 
            // BTSearchPhim
            // 
            this.BTSearchPhim.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSearchPhim.ForeColor = System.Drawing.Color.Red;
            this.BTSearchPhim.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.BTSearchPhim.Location = new System.Drawing.Point(213, 3);
            this.BTSearchPhim.Name = "BTSearchPhim";
            this.BTSearchPhim.Size = new System.Drawing.Size(75, 38);
            this.BTSearchPhim.TabIndex = 1;
            this.BTSearchPhim.Text = "Tìm";
            this.BTSearchPhim.UseVisualStyleBackColor = true;
            this.BTSearchPhim.Click += new System.EventHandler(this.BTSearchPhim_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(3, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 44);
            this.panel5.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.button4.Location = new System.Drawing.Point(6, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 7;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.button3.Location = new System.Drawing.Point(87, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.button2.Location = new System.Drawing.Point(168, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.button1.Location = new System.Drawing.Point(249, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(336, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 172);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.NRPhim);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 129);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(289, 36);
            this.panel10.TabIndex = 4;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // NRPhim
            // 
            this.NRPhim.Location = new System.Drawing.Point(99, 5);
            this.NRPhim.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NRPhim.Name = "NRPhim";
            this.NRPhim.Size = new System.Drawing.Size(105, 20);
            this.NRPhim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.CBCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 87);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(289, 36);
            this.panel9.TabIndex = 3;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(99, 8);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(105, 21);
            this.CBCategory.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thể Loại:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.TBName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(289, 36);
            this.panel8.TabIndex = 2;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(99, 8);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(105, 20);
            this.TBName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phim:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TBIdPhim);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(289, 36);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // TBIdPhim
            // 
            this.TBIdPhim.Location = new System.Drawing.Point(99, 8);
            this.TBIdPhim.Name = "TBIdPhim";
            this.TBIdPhim.ReadOnly = true;
            this.TBIdPhim.Size = new System.Drawing.Size(105, 20);
            this.TBIdPhim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DTGVPhim);
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 236);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // DTGVPhim
            // 
            this.DTGVPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVPhim.Location = new System.Drawing.Point(3, 3);
            this.DTGVPhim.Name = "DTGVPhim";
            this.DTGVPhim.Size = new System.Drawing.Size(318, 230);
            this.DTGVPhim.TabIndex = 0;
            this.DTGVPhim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVPhim_CellContentClick);
            // 
            // TCAccount
            // 
            this.TCAccount.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.BG;
            this.TCAccount.Controls.Add(this.panel18);
            this.TCAccount.Controls.Add(this.panel17);
            this.TCAccount.Controls.Add(this.panel11);
            this.TCAccount.Location = new System.Drawing.Point(4, 22);
            this.TCAccount.Name = "TCAccount";
            this.TCAccount.Padding = new System.Windows.Forms.Padding(3);
            this.TCAccount.Size = new System.Drawing.Size(643, 292);
            this.TCAccount.TabIndex = 2;
            this.TCAccount.Text = "Tài khoản";
            this.TCAccount.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.DTGVAccount);
            this.panel18.Location = new System.Drawing.Point(3, 53);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(327, 236);
            this.panel18.TabIndex = 6;
            // 
            // DTGVAccount
            // 
            this.DTGVAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVAccount.Location = new System.Drawing.Point(3, 3);
            this.DTGVAccount.Name = "DTGVAccount";
            this.DTGVAccount.Size = new System.Drawing.Size(318, 228);
            this.DTGVAccount.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.BTViewAccount);
            this.panel17.Controls.Add(this.BTEditAccount);
            this.panel17.Controls.Add(this.BTDeleteAccount);
            this.panel17.Controls.Add(this.BTAddAccount);
            this.panel17.Location = new System.Drawing.Point(3, 6);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(327, 44);
            this.panel17.TabIndex = 5;
            // 
            // BTViewAccount
            // 
            this.BTViewAccount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTViewAccount.ForeColor = System.Drawing.Color.Red;
            this.BTViewAccount.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.BTViewAccount.Location = new System.Drawing.Point(246, 3);
            this.BTViewAccount.Name = "BTViewAccount";
            this.BTViewAccount.Size = new System.Drawing.Size(75, 38);
            this.BTViewAccount.TabIndex = 3;
            this.BTViewAccount.Text = "Xem";
            this.BTViewAccount.UseVisualStyleBackColor = true;
            // 
            // BTEditAccount
            // 
            this.BTEditAccount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEditAccount.ForeColor = System.Drawing.Color.Red;
            this.BTEditAccount.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.BTEditAccount.Location = new System.Drawing.Point(165, 3);
            this.BTEditAccount.Name = "BTEditAccount";
            this.BTEditAccount.Size = new System.Drawing.Size(75, 38);
            this.BTEditAccount.TabIndex = 2;
            this.BTEditAccount.Text = "Sửa";
            this.BTEditAccount.UseVisualStyleBackColor = true;
            // 
            // BTDeleteAccount
            // 
            this.BTDeleteAccount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDeleteAccount.ForeColor = System.Drawing.Color.Red;
            this.BTDeleteAccount.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.BTDeleteAccount.Location = new System.Drawing.Point(84, 3);
            this.BTDeleteAccount.Name = "BTDeleteAccount";
            this.BTDeleteAccount.Size = new System.Drawing.Size(75, 38);
            this.BTDeleteAccount.TabIndex = 1;
            this.BTDeleteAccount.Text = "Xóa";
            this.BTDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // BTAddAccount
            // 
            this.BTAddAccount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAddAccount.ForeColor = System.Drawing.Color.Red;
            this.BTAddAccount.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.BTAddAccount.Location = new System.Drawing.Point(3, 3);
            this.BTAddAccount.Name = "BTAddAccount";
            this.BTAddAccount.Size = new System.Drawing.Size(75, 38);
            this.BTAddAccount.TabIndex = 0;
            this.BTAddAccount.Text = "Thêm";
            this.BTAddAccount.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.BTResetPassWord);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(336, 53);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(309, 176);
            this.panel11.TabIndex = 2;
            // 
            // BTResetPassWord
            // 
            this.BTResetPassWord.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTResetPassWord.ForeColor = System.Drawing.Color.Red;
            this.BTResetPassWord.Image = global::QuanLyRapPhim.Properties.Resources.button2;
            this.BTResetPassWord.Location = new System.Drawing.Point(219, 129);
            this.BTResetPassWord.Name = "BTResetPassWord";
            this.BTResetPassWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTResetPassWord.Size = new System.Drawing.Size(75, 38);
            this.BTResetPassWord.TabIndex = 4;
            this.BTResetPassWord.Text = "Đặt lại mật khẩu";
            this.BTResetPassWord.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.CBAccountType);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Location = new System.Drawing.Point(3, 87);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(300, 36);
            this.panel13.TabIndex = 3;
            // 
            // CBAccountType
            // 
            this.CBAccountType.FormattingEnabled = true;
            this.CBAccountType.Location = new System.Drawing.Point(127, 8);
            this.CBAccountType.Name = "CBAccountType";
            this.CBAccountType.Size = new System.Drawing.Size(164, 21);
            this.CBAccountType.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại tài khoản:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.TBDisplayName);
            this.panel14.Controls.Add(this.label7);
            this.panel14.Location = new System.Drawing.Point(3, 45);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(300, 36);
            this.panel14.TabIndex = 2;
            // 
            // TBDisplayName
            // 
            this.TBDisplayName.Location = new System.Drawing.Point(127, 8);
            this.TBDisplayName.Name = "TBDisplayName";
            this.TBDisplayName.Size = new System.Drawing.Size(164, 20);
            this.TBDisplayName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên hiển thị:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.TBUserName);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Location = new System.Drawing.Point(3, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(300, 36);
            this.panel15.TabIndex = 1;
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(127, 8);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.ReadOnly = true;
            this.TBUserName.Size = new System.Drawing.Size(164, 20);
            this.TBUserName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên tài khoản:";
            // 
            // QTAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 330);
            this.Controls.Add(this.TCAdmin);
            this.Name = "QTAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.QTAdmin_Load);
            this.TCAdmin.ResumeLayout(false);
            this.TCBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVBill)).EndInit();
            this.TCPhim.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NRPhim)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVPhim)).EndInit();
            this.TCAccount.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVAccount)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCAdmin;
        private System.Windows.Forms.TabPage TCBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage TCPhim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DTGVBill;
        private System.Windows.Forms.DateTimePicker DTTP1;
        private System.Windows.Forms.Button BTViewBill;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DTGVPhim;
        private System.Windows.Forms.TextBox TBTenPhim;
        private System.Windows.Forms.Button BTSearchPhim;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TBIdPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown NRPhim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.TabPage TCAccount;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.DataGridView DTGVAccount;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button BTViewAccount;
        private System.Windows.Forms.Button BTEditAccount;
        private System.Windows.Forms.Button BTDeleteAccount;
        private System.Windows.Forms.Button BTAddAccount;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button BTResetPassWord;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox CBAccountType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox TBDisplayName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}