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
    public partial class frm_Sach : Form
    {
        public frm_Sach()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Share lopDungChung = new Share();

        private void frm_Sach_Load(object sender, EventArgs e)
        {
            string sql = "Select * from DANHMUC";
            cbo_Loai.DataSource = lopDungChung.LoadDL(sql);
            cbo_Loai.DisplayMember = "DANHMUC";
            cbo_Loai.ValueMember = "TenDanhMuc";

            string sql1 = "SELECT * FROM SACH";
            dataGridView1.DataSource = lopDungChung.LoadDL(sql1);
        }    

        private void btn_Them_Click(object sender, EventArgs e)
        {        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSach.Text = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
            txt_TenSach.Text = dataGridView1.CurrentRow.Cells["TenSach"].Value.ToString();
            cbo_Loai.SelectedValue = dataGridView1.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            txt_TenTacGia.Text = dataGridView1.CurrentRow.Cells["TenTacGia"].Value.ToString();
            date_NgayXuatBan.Text = dataGridView1.CurrentRow.Cells["NgayXuatBan"].Value.ToString();
            txt_NhaXuatBan.Text = dataGridView1.CurrentRow.Cells["NhaXuatBan"].Value.ToString();
            txt_SoLuong.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells["GiaTien"].Value.ToString();
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {                 }

        private void btn_Tim_Click(object sender, EventArgs e)
        {                   }

        private void label2_Click(object sender, EventArgs e)
        {      }

        private void label1_Click(object sender, EventArgs e)
        {       }

        private void label3_Click(object sender, EventArgs e)
        {        }       

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;

            if (!string.IsNullOrEmpty(timKiem))
            {
                string sql = "SELECT * FROM SACH WHERE UPPER(TenSach) LIKE '%" 
                    + timKiem.ToUpper() + 
                    "%' OR MaSach LIKE '%" 
                    + timKiem + "%'";
                dataGridView1.DataSource = lopDungChung.LoadDL(sql);
            }
            else
                MessageBox.Show("Vui lòng nhập tên sách hoặc mã sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string checkSql = "SELECT COUNT(*) FROM SACH WHERE MaSach = '" + txt_MaSach.Text + "'";
            int count = Convert.ToInt32(lopDungChung.LayGT(checkSql));

            if (count > 0)
            {
                MessageBox.Show("Mã sách đã tồn tại, thêm vào danh sách thất bại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "Insert into SACH values ('" + txt_MaSach.Text + 
                "', N'" + txt_TenSach.Text + "', N'" 
                + cbo_Loai.SelectedValue + "', N'" 
                + txt_TenTacGia.Text + "',Convert(date,'" 
                + date_NgayXuatBan.Text + "',103), N'" 
                + txt_NhaXuatBan.Text + "','" 
                + txt_SoLuong.Text + "','" 
                + txt_Gia.Text + "')";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Đã thêm vào danh mục sách", "Thông Báo");
            else MessageBox.Show("Thêm vào danh mục sách thất bại", "Cảnh Báo");
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            cbo_Loai.SelectedIndex = 0;
            txt_TenTacGia.Text = "";
            date_NgayXuatBan.Text = "";
            txt_NhaXuatBan.Text = "";
            txt_SoLuong.Text = "";
            txt_Gia.Text = "";

            string sql = "SELECT * FROM SACH";
            dataGridView1.DataSource = lopDungChung.LoadDL(sql);
            MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SACH WHERE MaSach = '" + txt_MaSach.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq >= 1) MessageBox.Show("Xóa sách thành công");
            else
                MessageBox.Show("Xóa sách thất bại");

            //string sql = "DELETE FROM SACH WHERE MaSach='" + txt_MaSach.Text + "' OR TenSach='" + txt_TenSach.Text + "'";
            //int kq = lopDungChung.ThemXoaSua(sql);
            //if (kq >= 1) MessageBox.Show("Xóa sách thành công");
            //else
            //    MessageBox.Show("Vui lòng không để trống Mã Sách hoặc Tên Sách");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE SACH SET " +
                 "TenSach = '" + txt_TenSach.Text + "', " +
                 "MaDanhMuc = '" + cbo_Loai.SelectedValue + "', " +
                 "TenTacGia = '" + txt_TenTacGia.Text + "', " +
                 "NgayXuatBan = Convert(date,'" + date_NgayXuatBan.Text + "',103), " +
                 "NhaXuatBan = '" + txt_NhaXuatBan.Text + "', " +
                 "SoLuong = '" + txt_SoLuong.Text + "', " +
                 "GiaTien = '" + txt_Gia.Text + "' " +
                 "WHERE MaSach = '" + txt_MaSach.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Sửa thất bại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
