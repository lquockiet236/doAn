using QuanLiCuaHangBUS;
using QuanLiCuaHangDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangGUI
{
    public partial class frmDangNhap: Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập");
                return;
            }
            NhanVienDTO nvDN = nvBUS.DangNhap(txtMaNV.Text, txtMK.Text);
            if (nvDN == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                txtMaNV.Focus();
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmMain f = (frmMain)this.MdiParent;
                f.isDangNhap = true;
                f.nvDangNhap = nvDN;
                f.SetTrangThai();
                this.Close();
            }
        }
    }
}
