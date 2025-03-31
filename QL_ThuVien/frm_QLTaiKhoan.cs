using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien
{
    public partial class frm_QLTaiKhoan : Form
    {
        Share lopDungChung = new Share();
        public frm_QLTaiKhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NhapSach_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TAIKHOAN values ('" + txt_TaiKhoan.Text +
                "','" + txt_MatKhau.Text + "',N'"
                + txt_Ten.Text + "',N'"
                + cbo_phanquyen.SelectedValue + "')";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Đã tạo tài khoản thành công", "Thông Báo");
            else MessageBox.Show("Tạo tài khoản thất bại", "Cảnh Báo");
        }

        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            string sql = "Select * from PHANQUYEN";
            cbo_phanquyen.DataSource = lopDungChung.LoadDL(sql);
            cbo_phanquyen.DisplayMember = "LoaiDangNhap";
            cbo_phanquyen.ValueMember = "Id_LoaiDangNhap";

            string sql1 = "SELECT * FROM TAIKHOAN";
            dataGridView1.DataSource = lopDungChung.LoadDL(sql1);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TaiKhoan.Text = dataGridView1.CurrentRow.Cells["TaiKhoan"].Value.ToString();
            txt_MatKhau.Text = dataGridView1.CurrentRow.Cells["MatKhau"].Value.ToString();
            txt_Ten.Text = dataGridView1.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            cbo_phanquyen.SelectedValue = dataGridView1.CurrentRow.Cells["Id_LoaiDangNhap"].Value.ToString();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TAIKHOAN";
            dataGridView1.DataSource = lopDungChung.LoadDL(sql);
            MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Xoaa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM TAIKHOAN WHERE TaiKhoan = '" + txt_TaiKhoan.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq >= 1) MessageBox.Show("Xóa sách thành công");
            else
                MessageBox.Show("Xóa sách thất bại");
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;

            if (!string.IsNullOrEmpty(timKiem))
            {
                string sql = "SELECT * FROM TAIKHOAN WHERE UPPER(TenDangNhap) LIKE '%"
                    + timKiem.ToUpper() +
                    "%' OR TaiKhoan LIKE '%"
                    + timKiem + "%'";
                dataGridView1.DataSource = lopDungChung.LoadDL(sql);
            }
            else
                MessageBox.Show("Vui lòng nhập tên sách hoặc mã sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
