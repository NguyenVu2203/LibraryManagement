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
    public partial class frm_Main : Form
    {
        private string idtaikhoan,taikhoan, matkhau,tendangnhap,iddangnhap;

        public frm_Main(string idtaikhoan, string taikhoan, string matkhau, string tendangnhap, string iddangnhap)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.tendangnhap = tendangnhap;
            this.iddangnhap = iddangnhap;
            txt_Username.Text = tendangnhap;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {               }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frm_NhanVien" || form.Name == "frm_HoiVien" ||
                    form.Name == "frm_PhieuMuon_Tra" || form.Name == "frm_QLTaiKhoan" || form.Name == "frm_NhapSach")
                {
                    form.Close();
                    break;
                }
            }
            if (Application.OpenForms["frm_Sach"] == null)
            {
                frm_Sach sach = new frm_Sach();
                sach.MdiParent = this;
                sach.Show();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frm_Sach" || form.Name == "frm_HoiVien" ||
                    form.Name == "frm_PhieuMuon_Tra" || form.Name == "frm_QLTaiKhoan" || form.Name == "frm_NhapSach")
                {
                    form.Close();
                    break;
                }
            }
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nv = new frm_NhanVien();
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void hộiViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frm_Sach" || form.Name == "frm_NhanVien" ||
                    form.Name == "frm_PhieuMuon_Tra" || form.Name == "frm_QLTaiKhoan" || form.Name == "frm_NhapSach")
                {
                    form.Close();
                    break;
                }
            }
            if (Application.OpenForms["frm_HoiVien"] == null)
            {
                frm_HoiVien hv = new frm_HoiVien();
                hv.MdiParent = this;
                hv.Show();
            }
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void phiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frm_Sach" || form.Name == "frm_NhanVien" ||
                    form.Name == "frm_HoiVien" || form.Name == "frm_QLTaiKhoan" || form.Name == "frm_NhapSach")
                {
                    form.Close();
                    break;
                }
            }
            if (Application.OpenForms["frm_PhieuMuon_Tra"] == null)
            {
                frm_PhieuMuon_Tra phieu = new frm_PhieuMuon_Tra();
                phieu.MdiParent = this;
                phieu.Show();
            }
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frm_Sach" || form.Name == "frm_NhanVien" ||
                    form.Name == "frm_HoiVien" || form.Name == "frm_PhieuMuon_Tra" || form.Name == "frm_QLTaiKhoan")
                {
                    form.Close();
                    break;
                }
            }
            if (Application.OpenForms["frm_NhapSach"] == null)
            {
                frm_NhapSach phanquyen = new frm_NhapSach();
                phanquyen.MdiParent = this;
                phanquyen.Show();
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iddangnhap.Trim().Equals("Admin"))
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frm_Sach" || form.Name == "frm_NhanVien" ||
                        form.Name == "frm_HoiVien" || form.Name == "frm_PhieuMuon_Tra" || form.Name == "frm_NhapSach")
                    {
                        form.Close();
                        break;
                    }
                }
                if (Application.OpenForms["frm_QLTaiKhoan"] == null)
                {
                    frm_QLTaiKhoan taikhoan = new frm_QLTaiKhoan();
                    taikhoan.MdiParent = this;
                    taikhoan.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập vào Quản lý tài khoản! (chỉ có admin mới có quyền truy cập)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
