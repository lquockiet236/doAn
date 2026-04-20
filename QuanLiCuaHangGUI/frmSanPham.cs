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
using QuanLiCuaHangBUS;

namespace QuanLiCuaHangGUI
{
    public partial class frmSanPham: Form
    {
        SanPhamBUS spBUS = new SanPhamBUS();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
           LoadDSSP();

        }
        private void LoadDSSP()
        {
            try
            {
                // Gọi hàm từ BUS lấy danh sách
                List<SanPhamDTO> lstSanPham = spBUS.DanhSachSanPham();

                // Đổ dữ liệu vào DataGridView (giả sử tên dgv của bạn là dgvSanPham)
                dgvSP.DataSource = lstSanPham;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
