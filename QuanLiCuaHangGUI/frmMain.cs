using QuanLiCuaHangDTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiCuaHangGUI
{
    public partial class frmMain : Form
    {
        public bool isDangNhap = false;
        public NhanVienDTO nvDangNhap = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuDonHang_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetTrangThai();
        }
        public void SetTrangThai()
        {
            if (isDangNhap)
            {
                mnuThongKe.Enabled = true;
                mnuSanPham.Enabled = true;
                mnuKhuyenMai.Enabled = true;
                mnuKhachHang.Enabled = true;
                mnuDonHang.Enabled = true;
                //btnDNDX.Image = QLCHSuaGUI.Properties.Resources.DangXuat;
                //btnDNDX.Text = "ĐĂNG XUẤT";
                //picNV.Image = Image.FromFile(nvDangNhap.HinhAnh);
                lblTenNV.Text = $"Xin chào, {nvDangNhap.HoTen}";
            }
            else
            {
                nvDangNhap = null;
                mnuThongKe.Enabled = false;
                mnuSanPham.Enabled = false;
                mnuKhuyenMai.Enabled = false;
                mnuKhachHang.Enabled = false;
                mnuDonHang.Enabled = false;
                //picNV.Image = null;
                //btnDNDX.Image = QLCHSuaGUI.Properties.Resources.DangNhap;
                //btnDangNhap.Text = "ĐĂNG NHẬP";
                lblTenNV.Text = "";
                frmDangNhap f = new frmDangNhap();
                MoFormChucNang(f);
            }
        }
        private void MoFormChucNang(Form f)
        {
            //Dong tat ca form con
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            // mo form chuc nang
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }


    }
}
