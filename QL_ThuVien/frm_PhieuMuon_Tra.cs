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
    public partial class frm_PhieuMuon_Tra : Form
    {
        public frm_PhieuMuon_Tra()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Share lopDungChung = new Share();
        private void frm_PhieuMuon_Tra_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM PHIEUMUON_TRA";
            dataGridView1.DataSource = lopDungChung.LoadDL(sql1);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Muon_Click(object sender, EventArgs e)
        {
                // 1. Nhập đầu vào
            string maPhieu = txt_MP.Text.Trim();
            string maDocGia = txt_MaDG.Text.Trim();
            string maSach = txt_nameSach.Text.Trim();
            string maNhanVien = txt_MaNV.Text.Trim();
            int soLuongMuon;

            if (string.IsNullOrEmpty(maPhieu) || string.IsNullOrEmpty(maDocGia) || string.IsNullOrEmpty(maSach) || string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!int.TryParse(txt_SoLuongMuon.Text, out soLuongMuon))
            {
                MessageBox.Show("Số lượng mượn phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Kiểm tra tính hợp lệ
            string sqlCheckAvailability = "SELECT SoLuong FROM SACH WHERE MaSach = '" + maSach + "'";
            object availableQuantityResult = lopDungChung.LayGT(sqlCheckAvailability);

            if (availableQuantityResult == null)
            {
                MessageBox.Show("Không tìm thấy sách có mã: " + maSach, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int availableQuantity = Convert.ToInt32(availableQuantityResult);

            if (availableQuantity < soLuongMuon)
            {
                MessageBox.Show("Số lượng sách mượn vượt quá số lượng sách khả dụng! Chỉ còn " + availableQuantity + " quyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Cập nhập danh sách bên bảng Sách
            int newQuantity = availableQuantity - soLuongMuon;
            string sqlUpdateQuantity = "UPDATE SACH SET SoLuong = " + newQuantity + " WHERE MaSach = '" + maSach + "'";
            lopDungChung.LoadDL(sqlUpdateQuantity);

            // 4. Thêm vào danh sách mượn
            string ngayMuon = DateTime.Now.ToString("yyyy-MM-dd"); // Get current date
            string sqlInsertLoan = "INSERT INTO PHIEUMUON_TRA (MaPhieu, MaDocGia, MaSach, SoLuong, TrangThai, NgayMuon, NgayTraDuKien, MaNhanVien, NgayTra) VALUES ('" +
                maPhieu + "', '" + maDocGia + "', '" + maSach + "', " + soLuongMuon + ", 'Chua Tra', '" + ngayMuon + "', DATEADD(day, 30, '" + ngayMuon + "'), '" + maNhanVien + "', NULL)";
            lopDungChung.LoadDL(sqlInsertLoan);

            // 5. Cập lên datagridvew
            string sqlReloadData = "SELECT * FROM PHIEUMUON_TRA";
            dataGridView1.DataSource = lopDungChung.LoadDL(sqlReloadData);

            txt_MaDG.Text = "";
            txt_nameSach.Text = "";
            txt_SoLuongMuon.Text = "";
            txt_TinhTrang.Text = "";
            date_Muon.Text = "";  
            date_NgayTraDuKien.Text = ""; 

            MessageBox.Show("Đã thêm phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Tra_Click(object sender, EventArgs e)
        {
            // 1. Nhập đầu vào
            string maPhieu = txt_MP.Text.Trim();
            string ngayTra = DateTime.Now.ToString("yyyy-MM-dd"); 
            int soLuongMuon = int.Parse(txt_SoLuongMuon.Text); 

            // 2. Tạo Trạng Thái và Ngày trả tự động
            string sqlUpdateLoan = "UPDATE PHIEUMUON_TRA SET TrangThai = 'Da Tra', NgayTra = '" + ngayTra + "' WHERE MaPhieu = '" + maPhieu + "'";
            lopDungChung.LoadDL(sqlUpdateLoan); 

            // 3. Update số lượng trong bảng SACH
            string sqlGetAvailableQuantity = "SELECT SoLuong FROM SACH WHERE MaSach = (SELECT MaSach FROM PHIEUMUON_TRA WHERE MaPhieu = '" + maPhieu + "')";
            object availableQuantityResult = lopDungChung.LayGT(sqlGetAvailableQuantity);

            if (availableQuantityResult != null)
            {
                int availableQuantity = Convert.ToInt32(availableQuantityResult);
                int newQuantity = availableQuantity + soLuongMuon;

                string sqlUpdateQuantity = "UPDATE SACH SET SoLuong = " + newQuantity + " WHERE MaSach = (SELECT MaSach FROM PHIEUMUON_TRA WHERE MaPhieu = '" + maPhieu + "')";
                lopDungChung.LoadDL(sqlUpdateQuantity); 
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách cho mượn này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Cập nhật lên datagirdview
            string sqlReloadData = "SELECT * FROM PHIEUMUON_TRA";
            dataGridView1.DataSource = lopDungChung.LoadDL(sqlReloadData);

            // 5. Xoá các text box
            txt_MP.Text = "";
            txt_MaDG.Text = "";
            txt_nameSach.Text = "";
            txt_SoLuongMuon.Text = "";
            txt_TinhTrang.Text = "";
            date_Muon.Text = "";
            date_NgayTraDuKien.Text = "";
            txt_MaNV.Text = "";
            date_NgayTra.Text = ngayTra;

            MessageBox.Show("Đã trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_GiaHan_Click(object sender, EventArgs e)
        {
            string maPhieu = txt_MP.Text.Trim();

            // Kiểm tra nếu MaPhieu rỗng
            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayTraDuKien = date_NgayTraDuKien.Value;
            DateTime ngayTraMoi = ngayTraDuKien.AddDays(10);

            // Chuyển đổi ngày về chuỗi đúng định dạng SQL
            string ngayTraMoiFormatted = ngayTraMoi.ToString("yyyy-MM-dd");

            // Tạo câu lệnh SQL với chuỗi kết hợp đúng cách
            string sql = "UPDATE PHIEUMUON_TRA SET NgayTraDuKien = '" + ngayTraMoiFormatted + "' WHERE MaPhieu = '" + maPhieu + "'";

            // Thực hiện câu lệnh SQL
            int kq = lopDungChung.ThemXoaSua(sql);

            if (kq > 0)
            {
                MessageBox.Show("Gia hạn thành công. Ngày trả dự kiến đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Cập nhật lại ngày trả dự kiến trong giao diện
                date_NgayTraDuKien.Value = ngayTraMoi;
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu mượn với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MP.Text = dataGridView1.CurrentRow.Cells["MaPhieu"].Value.ToString();
            txt_MaDG.Text = dataGridView1.CurrentRow.Cells["MaDocGia"].Value.ToString();
            txt_nameSach.Text = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
            txt_SoLuongMuon.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_TinhTrang.Text = dataGridView1.CurrentRow.Cells["TrangThai"].Value.ToString();
            date_Muon.Text = dataGridView1.CurrentRow.Cells["NgayMuon"].Value.ToString();
            date_NgayTraDuKien.Text = dataGridView1.CurrentRow.Cells["NgayTraDuKien"].Value.ToString();
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            date_NgayTra.Text = dataGridView1.CurrentRow.Cells["NgayTra"].Value.ToString();
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {            
            string maSach = txt_MaSach.Text.Trim();
            string tenSach = txt_TenSach.Text;
            string sql = "SELECT SoLuong FROM SACH WHERE MaSach = '" + maSach + "' OR TenSach = N'" + tenSach + "'";

            object kq = lopDungChung.LayGT(sql);
            if (kq != null)
            {
                txt_SoLuong.Text = kq.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã: " + maSach + " hoặc tên sách: " + tenSach);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(timKiem))
            {
                string sql = "SELECT * FROM PHIEUMUON_TRA WHERE MaPhieu LIKE '%" + timKiem + "%'";
                dataGridView1.DataSource = lopDungChung.LoadDL(sql);
            }
            else
                MessageBox.Show("Vui lòng nhập tên sách hoặc mã sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PHIEUMUON_TRA";
            dataGridView1.DataSource = lopDungChung.LoadDL(sql);
            MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
