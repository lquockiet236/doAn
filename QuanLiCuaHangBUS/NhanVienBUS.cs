using QuanLiCuaHangDAO;
using QuanLiCuaHangDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangBUS
{
    public class NhanVienBUS
    {
        public NhanVienDTO DangNhap(string tk, string mk)
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.DangNhap(tk, mk);
        }
    }
}
