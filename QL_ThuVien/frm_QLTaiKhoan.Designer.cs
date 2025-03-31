namespace QL_ThuVien
{
    partial class frm_QLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoaa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_phanquyen = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.btn_Xoaa);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.txt_TaiKhoan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbo_phanquyen);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_MatKhau);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Ten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.btn_NhapSach);
            this.panel1.Location = new System.Drawing.Point(20, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 623);
            this.panel1.TabIndex = 170;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Xoaa
            // 
            this.btn_Xoaa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoaa.BackgroundImage")));
            this.btn_Xoaa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Xoaa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Xoaa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoaa.Image")));
            this.btn_Xoaa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoaa.Location = new System.Drawing.Point(209, 241);
            this.btn_Xoaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoaa.Name = "btn_Xoaa";
            this.btn_Xoaa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Xoaa.Size = new System.Drawing.Size(109, 60);
            this.btn_Xoaa.TabIndex = 185;
            this.btn_Xoaa.Text = "Xóa";
            this.btn_Xoaa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoaa.Click += new System.EventHandler(this.btn_Xoaa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.BackgroundImage")));
            this.btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(353, 241);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_CapNhat.Size = new System.Drawing.Size(144, 60);
            this.btn_CapNhat.TabIndex = 184;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(209, 131);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(208, 28);
            this.txt_TaiKhoan.TabIndex = 183;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 31);
            this.label3.TabIndex = 182;
            this.label3.Text = "Tài Khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(303, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 41);
            this.label5.TabIndex = 181;
            this.label5.Text = "Quản Lý Tài Khoản";
            // 
            // cbo_phanquyen
            // 
            this.cbo_phanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phanquyen.FormattingEnabled = true;
            this.cbo_phanquyen.Location = new System.Drawing.Point(650, 178);
            this.cbo_phanquyen.Name = "cbo_phanquyen";
            this.cbo_phanquyen.Size = new System.Drawing.Size(208, 30);
            this.cbo_phanquyen.TabIndex = 180;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(14, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(813, 327);
            this.groupBox1.TabIndex = 179;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Tài Khoản";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 275);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(209, 178);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(208, 28);
            this.txt_MatKhau.TabIndex = 178;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 31);
            this.label7.TabIndex = 176;
            this.label7.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 174;
            this.label1.Text = "Phân Quyền";
            // 
            // txt_Ten
            // 
            this.txt_Ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ten.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(650, 131);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(208, 28);
            this.txt_Ten.TabIndex = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 172;
            this.label2.Text = "Tên";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.BackgroundImage")));
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(757, 260);
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
            this.txt_TimKiem.Location = new System.Drawing.Point(527, 263);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(235, 28);
            this.txt_TimKiem.TabIndex = 170;
            // 
            // btn_NhapSach
            // 
            this.btn_NhapSach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NhapSach.BackgroundImage")));
            this.btn_NhapSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_NhapSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_NhapSach.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapSach.Image")));
            this.btn_NhapSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapSach.Location = new System.Drawing.Point(82, 241);
            this.btn_NhapSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NhapSach.Name = "btn_NhapSach";
            this.btn_NhapSach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_NhapSach.Size = new System.Drawing.Size(95, 60);
            this.btn_NhapSach.TabIndex = 169;
            this.btn_NhapSach.Text = "Tạo";
            this.btn_NhapSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapSach.Click += new System.EventHandler(this.btn_NhapSach_Click);
            // 
            // frm_QLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 645);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_QLTaiKhoan";
            this.Text = "QUẢN LÝ TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frm_QLTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_phanquyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_NhapSach;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoaa;
    }
}