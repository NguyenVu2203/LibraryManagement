namespace QL_ThuVien
{
    partial class frm_DangNhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_tenDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_DangNhap);
            this.panel1.Controls.Add(this.txt_MatKhau);
            this.panel1.Controls.Add(this.txt_tenDN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(130, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 369);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(144, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "Đăng nhập";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Thoat.Location = new System.Drawing.Point(277, 261);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(145, 43);
            this.btn_Thoat.TabIndex = 31;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DangNhap.Location = new System.Drawing.Point(30, 261);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(145, 43);
            this.btn_DangNhap.TabIndex = 30;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(214, 189);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(208, 27);
            this.txt_MatKhau.TabIndex = 29;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDN.Location = new System.Drawing.Point(214, 130);
            this.txt_tenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.Size = new System.Drawing.Size(208, 27);
            this.txt_tenDN.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên người dùng";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_ThuVien.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(715, 630);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_tenDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
