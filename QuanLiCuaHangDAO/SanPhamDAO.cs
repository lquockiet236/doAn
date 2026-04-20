using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangDTO;
namespace QuanLiCuaHangDAO
{
    public class SanPhamDAO
    {
        public List<SanPhamDTO>GetSanPham()
        {
            try
            {
                List<SanPhamDTO> lsResult = new List<SanPhamDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlDataReader sdr = DataProvider.TruyVan("Select * from SanPham", conn);
                while (sdr.Read())
                {
                    SanPhamDTO s = new SanPhamDTO();
                    s.maSP = sdr["maSP"].ToString();
                    s.tenSP = sdr["tenSP"].ToString();
                    s.giaBan = decimal.Parse(sdr["giaBan"].ToString());
                    s.maLoai = sdr["maLoai"].ToString();
                    s.maThuongHieu = sdr["maThuongHieu"].ToString();
                    s.hinhAnh = sdr["hinhAnh"].ToString();
                    lsResult.Add(s);
                }
                return lsResult;
            }
            catch(Exception ex)
            {
                return new List<SanPhamDTO>();
            }
        }
    }
}
