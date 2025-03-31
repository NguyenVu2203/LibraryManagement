namespace QL_ThuVien
{
    partial class frm_HoiVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoiVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLamThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DiaChii = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.date_NgayThe = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DienThoaii = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_GioiTinhh = new System.Windows.Forms.TextBox();
            this.date_NgaySinhh = new System.Windows.Forms.DateTimePicker();
            this.txt_HoTenDocGia = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 384);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(967, 294);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hội viên";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDocGia,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.CMND,
            this.SDT,
            this.NgayLamThe});
            this.dataGridView2.Location = new System.Drawing.Point(7, 27);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(960, 253);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.Name = "MaDocGia";
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên Độc Giả";
            this.TenDocGia.Name = "TenDocGia";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Điện Thoại";
            this.SDT.Name = "SDT";
            // 
            // NgayLamThe
            // 
            this.NgayLamThe.DataPropertyName = "NgayLamThe";
            this.NgayLamThe.HeaderText = "Ngày Làm Thẻ";
            this.NgayLamThe.Name = "NgayLamThe";
            // 
            // txt_DiaChii
            // 
            this.txt_DiaChii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChii.Location = new System.Drawing.Point(675, 84);
            this.txt_DiaChii.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChii.Multiline = true;
            this.txt_DiaChii.Name = "txt_DiaChii";
            this.txt_DiaChii.Size = new System.Drawing.Size(215, 33);
            this.txt_DiaChii.TabIndex = 107;
            this.txt_DiaChii.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txt_CCCD);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Controls.Add(this.txt_TimKiem);
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_CapNhat);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.date_NgayThe);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_DiaChii);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_DienThoaii);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_GioiTinhh);
            this.panel2.Controls.Add(this.date_NgaySinhh);
            this.panel2.Controls.Add(this.txt_HoTenDocGia);
            this.panel2.Controls.Add(this.txt_Ma);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(38, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 689);
            this.panel2.TabIndex = 145;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CCCD.Location = new System.Drawing.Point(675, 140);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(215, 24);
            this.txt_CCCD.TabIndex = 173;
            this.txt_CCCD.TextChanged += new System.EventHandler(this.txt_CMND_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 172;
            this.label1.Text = "CMND";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.BackgroundImage")));
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(863, 320);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(56, 28);
            this.btn_TimKiem.TabIndex = 169;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(649, 323);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(208, 25);
            this.txt_TimKiem.TabIndex = 168;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Luu.BackgroundImage")));
            this.btn_Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(59, 301);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Luu.Size = new System.Drawing.Size(109, 60);
            this.btn_Luu.TabIndex = 167;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(342, 301);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(109, 60);
            this.button3.TabIndex = 166;
            this.button3.Text = "Xóa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.BackgroundImage")));
            this.btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(488, 301);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_CapNhat.Size = new System.Drawing.Size(144, 60);
            this.btn_CapNhat.TabIndex = 165;
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
            this.button1.Location = new System.Drawing.Point(199, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(109, 60);
            this.button1.TabIndex = 164;
            this.button1.Text = "Sửa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.No;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(361, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(245, 35);
            this.label17.TabIndex = 145;
            this.label17.Text = "Quản Lý Hội Viên";
            // 
            // date_NgayThe
            // 
            this.date_NgayThe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_NgayThe.CustomFormat = "dd/MM/yyyy";
            this.date_NgayThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayThe.Location = new System.Drawing.Point(675, 236);
            this.date_NgayThe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_NgayThe.Name = "date_NgayThe";
            this.date_NgayThe.Size = new System.Drawing.Size(215, 24);
            this.date_NgayThe.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(518, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 114;
            this.label6.Text = "Ngày làm thẻ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 106;
            this.label7.Text = "Địa chỉ";
            // 
            // txt_DienThoaii
            // 
            this.txt_DienThoaii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DienThoaii.Location = new System.Drawing.Point(675, 190);
            this.txt_DienThoaii.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DienThoaii.Name = "txt_DienThoaii";
            this.txt_DienThoaii.Size = new System.Drawing.Size(215, 24);
            this.txt_DienThoaii.TabIndex = 105;
            this.txt_DienThoaii.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(518, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 104;
            this.label11.Text = "Điện thoại";
            // 
            // txt_GioiTinhh
            // 
            this.txt_GioiTinhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTinhh.Location = new System.Drawing.Point(230, 193);
            this.txt_GioiTinhh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GioiTinhh.Name = "txt_GioiTinhh";
            this.txt_GioiTinhh.Size = new System.Drawing.Size(215, 24);
            this.txt_GioiTinhh.TabIndex = 102;
            this.txt_GioiTinhh.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // date_NgaySinhh
            // 
            this.date_NgaySinhh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_NgaySinhh.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySinhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgaySinhh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinhh.Location = new System.Drawing.Point(230, 239);
            this.date_NgaySinhh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_NgaySinhh.Name = "date_NgaySinhh";
            this.date_NgaySinhh.Size = new System.Drawing.Size(215, 24);
            this.date_NgaySinhh.TabIndex = 101;
            this.date_NgaySinhh.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txt_HoTenDocGia
            // 
            this.txt_HoTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenDocGia.Location = new System.Drawing.Point(230, 143);
            this.txt_HoTenDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTenDocGia.Name = "txt_HoTenDocGia";
            this.txt_HoTenDocGia.Size = new System.Drawing.Size(215, 24);
            this.txt_HoTenDocGia.TabIndex = 100;
            this.txt_HoTenDocGia.TextChanged += new System.EventHandler(this.txt_HoTen_TextChanged);
            // 
            // txt_Ma
            // 
            this.txt_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.Location = new System.Drawing.Point(230, 93);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(215, 24);
            this.txt_Ma.TabIndex = 99;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(80, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 25);
            this.label13.TabIndex = 98;
            this.label13.Text = "Giới tính";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(83, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 97;
            this.label14.Text = "Ngày sinh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(79, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 25);
            this.label15.TabIndex = 96;
            this.label15.Text = "Mã độc giả ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(79, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 25);
            this.label16.TabIndex = 95;
            this.label16.Text = "Tên độc giả";
            // 
            // frm_HoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 719);
            this.Controls.Add(this.panel2);
            this.Name = "frm_HoiVien";
            this.Text = "QUẢN LÝ HỘI VIÊN";
            this.Load += new System.EventHandler(this.frm_HoiVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker date_NgayThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DiaChii;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DienThoaii;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_GioiTinhh;
        private System.Windows.Forms.DateTimePicker date_NgaySinhh;
        private System.Windows.Forms.TextBox txt_HoTenDocGia;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLamThe;
    }
}