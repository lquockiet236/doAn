using QuanLiCuaHangDAO;
using QuanLiCuaHangDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangBUS
{
    public class SanPhamBUS
    {
        SanPhamDAO spDAO = new SanPhamDAO();
        public List<SanPhamDTO> DanhSachSanPham() { 
            return spDAO.GetSanPham();
        }
    }
}
