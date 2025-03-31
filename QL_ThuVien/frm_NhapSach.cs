using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QL_ThuVien
{
    public partial class frm_NhapSach : Form
    {
        Share lopDungChung = new Share();
        public frm_NhapSach()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_NhapSach_Click(object sender, EventArgs e)
        {

        }

        private void frm_NhapSach_Load(object sender, EventArgs e)
        {
            string sql = "Select * from SACH";
            cbo_TenSach.DataSource = lopDungChung.LoadDL(sql);
            cbo_TenSach.DisplayMember = "TenSach";
            cbo_TenSach.ValueMember = "TenSach";

            string sql1 = "SELECT * FROM NHAPSACH";
            dataGridView1.DataSource = lopDungChung.LoadDL(sql1);          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void date_NgayNhapSach_ValueChanged(object sender, EventArgs e)
        {      }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHAPSACH";
            dataGridView1.DataSource = lopDungChung.LoadDL(sql);
            MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_NhapSach_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy MaSach và SoLuongNhap từ các ô nhập
                string maSach = txt_MaSach.Text;
                int soLuongNhap = int.Parse(txt_SoLuongNhap.Text);

                // Lấy SoLuongTruocNhap từ bảng SACH
                string sqlGetSoLuongTruocNhap = $"SELECT SoLuong FROM SACH WHERE MaSach = N'{maSach}'";
                object soLuongTruocNhapObj = lopDungChung.LayGT(sqlGetSoLuongTruocNhap);
                if (soLuongTruocNhapObj == null)
                {
                    MessageBox.Show("Không tìm thấy sách trong bảng SACH", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int soLuongTruocNhap = Convert.ToInt32(soLuongTruocNhapObj);

                // Tính SoLuongSauNhap
                int soLuongSauNhap = soLuongTruocNhap + soLuongNhap;

                // Cập nhật SoLuong mới trong bảng SACH
                string sqlUpdateSoLuongSach = $"UPDATE SACH SET SoLuong = {soLuongSauNhap} WHERE MaSach = N'{maSach}'";
                lopDungChung.ThemXoaSua(sqlUpdateSoLuongSach);

                // Thêm bản ghi mới vào bảng NHAPSACH
                string maNhanVien = txt_MaNV.Text;
                string tenSach = cbo_TenSach.Text;
                string ngayNhap = date_NgayNhapSach.Value.ToString("yyyy-MM-dd");

                string sqlInsertNhapSach = $"INSERT INTO NHAPSACH (MaNhanVien, MaSach, TenSach, NgayNhap, SoLuongNhap, soluongTruocNhap, SoLuongSauNhap) " +
                                           $"VALUES (N'{maNhanVien}', N'{maSach}', N'{tenSach}', '{ngayNhap}', {soLuongNhap}, {soLuongTruocNhap}, {soLuongSauNhap})";
                lopDungChung.ThemXoaSua(sqlInsertNhapSach);

                // Cập nhật lại DataGridView
                string sqlLoadNhapSach = "SELECT * FROM NHAPSACH";
                dataGridView1.DataSource = lopDungChung.LoadDL(sqlLoadNhapSach);

                MessageBox.Show("Nhập sách thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_MaSach.Text = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
            cbo_TenSach.SelectedValue = dataGridView1.CurrentRow.Cells["TenSach"].Value.ToString();
            date_NgayNhapSach.Text = dataGridView1.CurrentRow.Cells["NgayNhap"].Value.ToString();
            txt_SoLuongNhap.Text = dataGridView1.CurrentRow.Cells["SoLuongNhap"].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbo_TenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tenSach = cbo_TenSach.Text;

                string sql = $"SELECT MaSach FROM SACH WHERE TenSach = N'{tenSach}'";
                object kq = lopDungChung.LayGT(sql);

                if (kq != null)               
                    txt_MaSach.Text = kq.ToString();               
                else
                    txt_MaSach.Text = ""; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_MaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;

            if (!string.IsNullOrEmpty(timKiem))
            {
                string sql = "SELECT * FROM NHAPSACH WHERE UPPER(MaSach) LIKE '%"
                    + timKiem.ToUpper() +
                    "%' OR TenSach LIKE '%"
                    + timKiem.ToUpper() +
                    "%' OR MaNhanVien LIKE '%"
                    + timKiem.ToUpper() + "%'";
                dataGridView1.DataSource = lopDungChung.LoadDL(sql);
            }
            else
                MessageBox.Show("Vui lòng nhập tên sách hoặc mã sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
