using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangDAO
{
    public class DataProvider
    {
        static string strKetNoi = "Data Source=.;Initial Catalog=QuanLiCuaHang;Integrated Security=true;";
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strKetNoi);
            conn.Open();
            return conn;
        }
        public static SqlDataReader TruyVan(string truyVan, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(truyVan, conn);
                SqlDataReader sdr = com.ExecuteReader();
                return sdr;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi");
            }
        }
        public static SqlDataReader TruyVan(string truyVan, SqlParameter[] pars, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(truyVan, conn);
                com.Parameters.AddRange(pars);
                SqlDataReader sdr = com.ExecuteReader();
                return sdr;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi");
            }
        }
        public static bool ThucThi(string lenh, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(lenh, conn);
                int kq = com.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi");
            }
        }
        public static bool ThucThi(string lenh, SqlParameter[] pars, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(lenh, conn);
                com.Parameters.AddRange(pars);
                int kq = com.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi");
            }
        }

    }
}
