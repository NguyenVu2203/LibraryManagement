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
    public partial class frm_HoiVien : Form
    {
        public frm_HoiVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        Share lopDungChung = new Share();
        private void frm_HoiVien_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM HOIVIEN";
            dataGridView2.DataSource = lopDungChung.LoadDL(sql1);
        }

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_HoTenDocGia.Text = "";
            txt_GioiTinhh.Text = "";
            date_NgaySinhh.Text = "";
            txt_DienThoaii.Text = "";
            txt_DiaChii.Text = "";
            txt_CCCD.Text = "";
            date_NgayThe.Text = "";

            string sql = "SELECT * FROM HOIVIEN";
            dataGridView2.DataSource = lopDungChung.LoadDL(sql);
            MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Ma.Text = dataGridView2.CurrentRow.Cells["MaDocGia"].Value.ToString();
            txt_HoTenDocGia.Text = dataGridView2.CurrentRow.Cells["TenDocGia"].Value.ToString();
            txt_GioiTinhh.Text = dataGridView2.CurrentRow.Cells["GioiTinh"].Value.ToString();
            date_NgaySinhh.Text = dataGridView2.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_DienThoaii.Text = dataGridView2.CurrentRow.Cells["SDT"].Value.ToString();
            txt_DiaChii.Text = dataGridView2.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_CCCD.Text = dataGridView2.CurrentRow.Cells["CMND"].Value.ToString();
            date_NgayThe.Text = dataGridView2.CurrentRow.Cells["NgayLamThe"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {       }

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {       }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            string checkSql = "SELECT COUNT(*) FROM HOIVIEN WHERE MaDocGia = '" + txt_Ma.Text + "'";
            int count = Convert.ToInt32(lopDungChung.LayGT(checkSql));

            if (count > 0)
            {
                MessageBox.Show("Mã độc giả đã tồn tại, thêm vào danh sách hội viên thất bại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string sql = "Insert into HOIVIEN values ('" + txt_Ma.Text + "','"
                + txt_HoTenDocGia.Text + "','"
                + txt_GioiTinhh.Text + "',Convert(date,'" + date_NgaySinhh.Text + "',103),'"
                + txt_DienThoaii.Text + "','"
                + txt_DiaChii.Text + "','"
                + txt_CCCD.Text + "',Convert(date,'" + date_NgayThe.Text + "',103)"
                + ")";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Đã thêm vào danh sách hội viên", "Thông Báo");
            else MessageBox.Show("Thêm vào danh sách hội viên thất bại", "Cảnh Báo");

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM HOIVIEN WHERE TenDocGia='" + txt_HoTenDocGia.Text + "' OR MaDocGia= '" + txt_Ma.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa hội viên thành công");
            else
                MessageBox.Show("Vui lòng không để trống Mã độc giả hoặc Tên độc giả");
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;

            if (!string.IsNullOrEmpty(timKiem))
            {
                string sql = "SELECT * FROM HOIVIEN WHERE UPPER(TenDocGia) LIKE '%" + timKiem.ToUpper() + "%' OR MaDocGia LIKE '%" + timKiem + "%'";
                dataGridView2.DataSource = lopDungChung.LoadDL(sql);
            }
            else
                MessageBox.Show("Vui lòng nhập Tên độc giả hoặc Mã độc giả", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "UPDATE HOIVIEN SET " +
                 "TenDocGia = '" + txt_HoTenDocGia.Text + "', " +
                 "GioiTinh = '" + txt_GioiTinhh.Text + "', " +
                 "NgaySinh = Convert(date,'" + date_NgaySinhh.Text + "',103), " +
                 "SDT = '" + txt_DienThoaii.Text + "', " +
                 "DiaChi = '" + txt_DiaChii.Text + "', " +
                 "CMND = '" + txt_CCCD.Text + "', " +
                 "NgayLamThe = Convert(date,'" + date_NgayThe.Text + "',103) " +
                 "WHERE MaDocGia = '" + txt_Ma.Text + "'";

            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Sửa thất bại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);        

        }
    }
}
