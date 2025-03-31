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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Share lopDungChung = new Share();
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM NHANVIEN";
            dataGridView2.DataSource = lopDungChung.LoadDL(sql1);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNv.Text = dataGridView2.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_TenNv.Text = dataGridView2.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            txt_GioiTinh.Text = dataGridView2.CurrentRow.Cells["GioiTinh"].Value.ToString();
            date_NgaySinhh.Text = dataGridView2.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_DienThoaii.Text = dataGridView2.CurrentRow.Cells["SDT"].Value.ToString();
            txt_DiaChii.Text = dataGridView2.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_Emaill.Text = dataGridView2.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string checkSql = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNhanVien = '" + txt_MaNv.Text + "'";
            int count = Convert.ToInt32(lopDungChung.LayGT(checkSql));

            if (count > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, thêm vào danh sách nhân viên thất bại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "Insert into NHANVIEN values ('" + txt_MaNv.Text + "','" 
                + txt_TenNv.Text + "','" 
                + txt_GioiTinh.Text + "',Convert(date,'" + date_NgaySinhh.Text + "',103),'" 
                + txt_DienThoaii.Text + "','" 
                + txt_DiaChii.Text + "','" 
                + txt_Emaill.Text + "')";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Đã thêm vào danh sách nhân viên", "Thông Báo");
            else MessageBox.Show("Thêm vào danh sách nhân viên thất bại", "Cảnh Báo");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            txt_MaNv.Text = "";
            txt_TenNv.Text = "";
            txt_GioiTinh.Text = "";
            date_NgaySinhh.Text = "";
            txt_DienThoaii.Text = "";
            txt_DiaChii.Text = "";
            txt_Emaill.Text = "";

            string sql = "SELECT * FROM NHANVIEN";
            dataGridView2.DataSource = lopDungChung.LoadDL(sql);
            MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM NHANVIEN WHERE TenNhanVien='" + txt_TenNv.Text + "' OR MaNhanVien= '" + txt_MaNv.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa nhân viên thành công");
            else
                MessageBox.Show("Vui lòng không để trống MaNV hoặc Họ Tên");
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;

            if (!string.IsNullOrEmpty(timKiem))
            {
                string sql = "SELECT * FROM NHANVIEN WHERE UPPER(TenNhanVien) LIKE '%" + timKiem.ToUpper() + "%' OR MaNhanVien LIKE '%" + timKiem + "%'";
                dataGridView2.DataSource = lopDungChung.LoadDL(sql);
            }
            else
                MessageBox.Show("Vui lòng nhập Tên NV hoặc Mã NV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NHANVIEN SET " +
                 "TenNhanVien = '" + txt_TenNv.Text + "', " +
                 "GioiTinh = '" + txt_GioiTinh.Text + "', " +
                 "NgaySinh = Convert(date,'" + date_NgaySinhh.Text + "',103), " +
                 "SDT = '" + txt_DienThoaii.Text + "', " +
                 "DiaChi = '" + txt_DiaChii.Text + "', " +
                 "Email = '" + txt_Emaill.Text + "' " +
                 "WHERE MaNhanVien = '" + txt_MaNv.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Sửa thất bại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
