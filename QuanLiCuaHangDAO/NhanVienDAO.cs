using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangDTO;

namespace QuanLiCuaHangDAO
{
    public class NhanVienDAO
    {
        public NhanVienDTO DangNhap(string username, string password)
        {
            try
            {
                NhanVienDTO nv = null;
                SqlConnection conn = DataProvider.TaoKetNoi();
                string str = "Select * From NV Where maNV=@mnv AND matKhau=@mk";
                SqlParameter[] pas = new SqlParameter[2];
                pas[0] = new SqlParameter("mnv", username);
                pas[1] = new SqlParameter("mk", password);
                SqlDataReader sdr = DataProvider.TruyVan(str, pas, conn);
                if (sdr.Read())
                {
                    nv = new NhanVienDTO();
                    nv.maNV = sdr["maNV"].ToString();
                    nv.HoTen = sdr["HoTen"].ToString();
                    //nv.gioiTinh = sdr["gioiTinh"];
                    //nv.HinhAnh = sdr["HinhAnh"].ToString();
                    nv.ngaySinh = DateTime.Parse(sdr["ngaySinh"].ToString());
                    nv.matKhau = sdr["matKhau"].ToString();
                }
                sdr.Close();
                conn.Close();
                return nv;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
