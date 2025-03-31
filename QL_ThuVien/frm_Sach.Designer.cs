namespace QL_ThuVien
{
    partial class frm_Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sach));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoaa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.date_NgayXuatBan = new System.Windows.Forms.DateTimePicker();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenTacGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Loai = new System.Windows.Forms.ComboBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.MaDanhMuc,
            this.TenTacGia,
            this.NgayXuatBan,
            this.NhaXuatBan,
            this.SoLuong,
            this.GiaTien});
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 268);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(936, 315);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(106, 36);
            this.btn_Tim.TabIndex = 83;
            this.btn_Tim.Text = "Tìm Kiếm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Crimson;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(453, 313);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(99, 36);
            this.btn_Xoa.TabIndex = 82;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(279, 313);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(99, 36);
            this.btn_Sua.TabIndex = 81;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(101, 313);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 36);
            this.btn_Them.TabIndex = 80;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_CapNhap
            // 
            this.btn_CapNhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CapNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhap.Location = new System.Drawing.Point(931, 193);
            this.btn_CapNhap.Name = "btn_CapNhap";
            this.btn_CapNhap.Size = new System.Drawing.Size(111, 40);
            this.btn_CapNhap.TabIndex = 142;
            this.btn_CapNhap.Text = "Cập Nhập";
            this.btn_CapNhap.UseVisualStyleBackColor = false;
            this.btn_CapNhap.Click += new System.EventHandler(this.btn_CapNhap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(375, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 35);
            this.label5.TabIndex = 144;
            this.label5.Text = "Quản Lý Sách";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Luu.BackgroundImage")));
            this.btn_Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(98, 301);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Luu.Size = new System.Drawing.Size(109, 60);
            this.btn_Luu.TabIndex = 142;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoaa
            // 
            this.btn_Xoaa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoaa.BackgroundImage")));
            this.btn_Xoaa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Xoaa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Xoaa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoaa.Image")));
            this.btn_Xoaa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoaa.Location = new System.Drawing.Point(381, 301);
            this.btn_Xoaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoaa.Name = "btn_Xoaa";
            this.btn_Xoaa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Xoaa.Size = new System.Drawing.Size(109, 60);
            this.btn_Xoaa.TabIndex = 141;
            this.btn_Xoaa.Text = "Xóa";
            this.btn_Xoaa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoaa.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.BackgroundImage")));
            this.btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(527, 301);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_CapNhat.Size = new System.Drawing.Size(144, 60);
            this.btn_CapNhat.TabIndex = 140;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(238, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(109, 60);
            this.button1.TabIndex = 139;
            this.button1.Text = "Sửa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.txt_SoLuong);
            this.panel1.Controls.Add(this.date_NgayXuatBan);
            this.panel1.Controls.Add(this.txt_Gia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_TenTacGia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_NhaXuatBan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbo_Loai);
            this.panel1.Controls.Add(this.txt_TenSach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_MaSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_Xoaa);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(25, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 688);
            this.panel1.TabIndex = 164;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.BackgroundImage")));
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(902, 320);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(56, 28);
            this.btn_TimKiem.TabIndex = 163;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(688, 323);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(208, 25);
            this.txt_TimKiem.TabIndex = 162;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoLuong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(688, 194);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(208, 25);
            this.txt_SoLuong.TabIndex = 161;
            // 
            // date_NgayXuatBan
            // 
            this.date_NgayXuatBan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgayXuatBan.Location = new System.Drawing.Point(688, 100);
            this.date_NgayXuatBan.Name = "date_NgayXuatBan";
            this.date_NgayXuatBan.Size = new System.Drawing.Size(208, 22);
            this.date_NgayXuatBan.TabIndex = 160;
            // 
            // txt_Gia
            // 
            this.txt_Gia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gia.Location = new System.Drawing.Point(688, 238);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(208, 25);
            this.txt_Gia.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 158;
            this.label6.Text = "Giá Tiền";
            // 
            // txt_TenTacGia
            // 
            this.txt_TenTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTacGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTacGia.Location = new System.Drawing.Point(224, 238);
            this.txt_TenTacGia.Name = "txt_TenTacGia";
            this.txt_TenTacGia.Size = new System.Drawing.Size(208, 25);
            this.txt_TenTacGia.TabIndex = 157;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 156;
            this.label7.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 155;
            this.label8.Text = "Tên Tác Giả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 154;
            this.label9.Text = "Ngày Xuất Bản";
            // 
            // txt_NhaXuatBan
            // 
            this.txt_NhaXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NhaXuatBan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhaXuatBan.Location = new System.Drawing.Point(688, 147);
            this.txt_NhaXuatBan.Name = "txt_NhaXuatBan";
            this.txt_NhaXuatBan.Size = new System.Drawing.Size(208, 25);
            this.txt_NhaXuatBan.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 152;
            this.label4.Text = "Nhà Xuất Bản";
            // 
            // cbo_Loai
            // 
            this.cbo_Loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Loai.FormattingEnabled = true;
            this.cbo_Loai.Location = new System.Drawing.Point(224, 191);
            this.cbo_Loai.Name = "cbo_Loai";
            this.cbo_Loai.Size = new System.Drawing.Size(208, 26);
            this.cbo_Loai.TabIndex = 151;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSach.Location = new System.Drawing.Point(224, 148);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(208, 25);
            this.txt_TenSach.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 149;
            this.label3.Text = "Thể Loại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 148;
            this.label1.Text = "Tên Sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSach.Location = new System.Drawing.Point(224, 97);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(208, 25);
            this.txt_MaSach.TabIndex = 147;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 146;
            this.label2.Text = "Mã Sách";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 383);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1036, 318);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục sách";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Thể Loại";
            this.MaDanhMuc.Name = "MaDanhMuc";
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            // 
            // NgayXuatBan
            // 
            this.NgayXuatBan.DataPropertyName = "NgayXuatBan";
            this.NgayXuatBan.HeaderText = "Ngày Xuất Bản";
            this.NgayXuatBan.Name = "NgayXuatBan";
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.NhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.NhaXuatBan.Name = "NhaXuatBan";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng Sách";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.Name = "GiaTien";
            // 
            // frm_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1096, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_CapNhap);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Name = "frm_Sach";
            this.Text = "QUẢN LÝ SÁCH";
            this.Load += new System.EventHandler(this.frm_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoaa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.DateTimePicker date_NgayXuatBan;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenTacGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NhaXuatBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Loai;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}