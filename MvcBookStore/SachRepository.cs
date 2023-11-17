using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcBookStore
{
    public class SachRepository
    {
        private string connectionString;

        public SachRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int ThemSach(string tenSach, decimal giaBan, string moTa, DateTime ngayCapNhat, int soLuongTon)
        {
            int maSach = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_ThemSach", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Tensach", tenSach);
                    command.Parameters.AddWithValue("@Giaban", giaBan);
                    command.Parameters.AddWithValue("@Mota", moTa);
                    command.Parameters.AddWithValue("@Ngaycapnhat", ngayCapNhat);
                    command.Parameters.AddWithValue("@Soluongton", soLuongTon);

                    try
                    {
                        maSach = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                       
                    }
                }
            }

            return maSach;
        }
        public void XoaSach(int maSach)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_XoaSach", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaSach", maSach);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                      
                    }
                }
            }

        }
        public int SuaThongTinSach(string tenSach, decimal giaBan, string moTa, DateTime ngayCapNhat, int soLuongTon)
        {
            int maSach = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_SuaThongTinSach", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Tensach", tenSach);
                    command.Parameters.AddWithValue("@Giaban", giaBan);
                    command.Parameters.AddWithValue("@Mota", moTa);
                    command.Parameters.AddWithValue("@Ngaycapnhat", ngayCapNhat);
                    command.Parameters.AddWithValue("@Soluongton", soLuongTon);

                    try
                    {
                        maSach = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {

                    }
                }
            }

            return maSach;
        }


    }

}