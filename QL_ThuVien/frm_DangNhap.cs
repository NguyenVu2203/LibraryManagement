using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QL_ThuVien
{
    public partial class frm_DangNhap : Form
    {
        private string phanquyen;
        public frm_DangNhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền mặc định của form
            this.Load += new EventHandler(frm_DangNhap_Load); // Gán sự kiện Load cho form
        }
     
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            // Thiết lập vùng cho form
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90); // Góc trên bên trái
            path.AddArc(this.Width - 20, 0, 20, 20, 270, 90); // Góc trên bên phải
            path.AddArc(this.Width - 20, this.Height - 20, 20, 20, 0, 90); // Góc dưới bên phải
            path.AddArc(0, this.Height - 20, 20, 20, 90, 90); // Góc dưới bên trái
            path.CloseFigure();
            this.Region = new Region(path); // Thiết lập vùng hình học cho form

            // Bo góc cho nút Đăng Nhập
            MakeRoundButton(btn_DangNhap);
            // Bo góc cho nút Thoát
            MakeRoundButton(btn_Thoat);
            // Bo góc cho panel
            MakeRoundPanel(panel1);
            panel1.BackColor = Color.FromArgb(180, 255, 255, 255); // Làm mờ panel bằng cách sử dụng độ trong suốt

        }
        private void MakeRoundButton(Button button)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90); // Góc trên bên trái
            path.AddArc(button.Width - 20, 0, 20, 20, 270, 90); // Góc trên bên phải
            path.AddArc(button.Width - 20, button.Height - 20, 20, 20, 0, 90); // Góc dưới bên phải
            path.AddArc(0, button.Height - 20, 20, 20, 90, 90); // Góc dưới bên trái
            path.CloseFigure();
            button.Region = new Region(path); // Thiết lập vùng hình học cho nút
        }

        private void MakeRoundPanel(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90); // Góc trên bên trái
            path.AddArc(panel.Width - 20, 0, 20, 20, 270, 90); // Góc trên bên phải
            path.AddArc(panel.Width - 20, panel.Height - 20, 20, 20, 0, 90); // Góc dưới bên phải
            path.AddArc(0, panel.Height - 20, 20, 20, 90, 90); // Góc dưới bên trái
            path.CloseFigure();
            panel.Region = new Region(path); // Thiết lập vùng hình học cho panel
        }

        Share lopDungChung = new Share();
        private int soLanSai = 0;

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from TAIKHOAN where TaiKhoan = '" + txt_tenDN.Text + "' and MatKhau = '" + txt_MatKhau.Text + "'";
            dt = lopDungChung.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_Main main = new frm_Main(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());
                main.Show();
                this.Hide();
            }
            else
            {
                soLanSai++;
                MessageBox.Show("Đăng nhập thất bại, sai tên hoặc mật khẩu! (Sai lần " + soLanSai + ")", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (soLanSai > 3)
                {
                    MessageBox.Show("Bạn đã nhập sai quá nhiều lần. Vui lòng thử lại sau!", "Thông báo");
                    Application.Exit();
                }
            }

        }
        
        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}