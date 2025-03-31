namespace QL_ThuVien
{
    partial class frm_NhapSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhapSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_TenSach = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_SoLuongNhap = new System.Windows.Forms.TextBox();
            this.date_NgayNhapSach = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_NhapSach = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_MaNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbo_TenSach);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_SoLuongNhap);
            this.panel1.Controls.Add(this.date_NgayNhapSach);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_MaSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.btn_NhapSach);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 647);
            this.panel1.TabIndex = 169;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(668, 127);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(208, 25);
            this.txt_MaNV.TabIndex = 187;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 186;
            this.label3.Text = "Mã Nhân Viên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.BackgroundImage")));
            this.btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(616, 185);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_CapNhat.Size = new System.Drawing.Size(144, 60);
            this.btn_CapNhat.TabIndex = 185;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(370, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 35);
            this.label5.TabIndex = 181;
            this.label5.Text = "Nhập Sách";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbo_TenSach
            // 
            this.cbo_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TenSach.FormattingEnabled = true;
            this.cbo_TenSach.Location = new System.Drawing.Point(215, 129);
            this.cbo_TenSach.Name = "cbo_TenSach";
            this.cbo_TenSach.Size = new System.Drawing.Size(208, 26);
            this.cbo_TenSach.TabIndex = 180;
            this.cbo_TenSach.SelectedIndexChanged += new System.EventHandler(this.cbo_TenSach_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(876, 327);
            this.groupBox1.TabIndex = 179;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 275);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_SoLuongNhap
            // 
            this.txt_SoLuongNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoLuongNhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongNhap.Location = new System.Drawing.Point(255, 185);
            this.txt_SoLuongNhap.Name = "txt_SoLuongNhap";
            this.txt_SoLuongNhap.Size = new System.Drawing.Size(168, 25);
            this.txt_SoLuongNhap.TabIndex = 178;
            // 
            // date_NgayNhapSach
            // 
            this.date_NgayNhapSach.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayNhapSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayNhapSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgayNhapSach.Location = new System.Drawing.Point(668, 83);
            this.date_NgayNhapSach.Name = "date_NgayNhapSach";
            this.date_NgayNhapSach.Size = new System.Drawing.Size(208, 24);
            this.date_NgayNhapSach.TabIndex = 177;
            this.date_NgayNhapSach.ValueChanged += new System.EventHandler(this.date_NgayNhapSach_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 176;
            this.label7.Text = "Số Lượng Nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 175;
            this.label9.Text = "Ngày Nhập Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 174;
            this.label1.Text = "Tên Sách";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSach.Location = new System.Drawing.Point(215, 82);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(208, 25);
            this.txt_MaSach.TabIndex = 173;
            this.txt_MaSach.TextChanged += new System.EventHandler(this.txt_MaSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 172;
            this.label2.Text = "Mã Sách";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.BackgroundImage")));
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(755, 265);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(56, 28);
            this.btn_TimKiem.TabIndex = 171;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(525, 268);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(235, 24);
            this.txt_TimKiem.TabIndex = 170;
            // 
            // btn_NhapSach
            // 
            this.btn_NhapSach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NhapSach.BackgroundImage")));
            this.btn_NhapSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_NhapSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_NhapSach.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapSach.Image")));
            this.btn_NhapSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapSach.Location = new System.Drawing.Point(236, 246);
            this.btn_NhapSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NhapSach.Name = "btn_NhapSach";
            this.btn_NhapSach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_NhapSach.Size = new System.Drawing.Size(150, 60);
            this.btn_NhapSach.TabIndex = 169;
            this.btn_NhapSach.Text = "Nhập Sách";
            this.btn_NhapSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapSach.Click += new System.EventHandler(this.btn_NhapSach_Click_1);
            // 
            // frm_NhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 673);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_NhapSach";
            this.Text = "NHẬP SÁCH";
            this.Load += new System.EventHandler(this.frm_NhapSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_TenSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_SoLuongNhap;
        private System.Windows.Forms.DateTimePicker date_NgayNhapSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_NhapSach;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label3;
    }
}