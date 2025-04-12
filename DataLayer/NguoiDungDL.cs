using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class NguoiDungDL
    {
        private DataProvider provider = new DataProvider();

        //Lấy danh sách người dùng
        public DataTable GetNguoiDungList(int ChucNangId)
        {
            string sql = "SELECT * FROM NguoiDung WHERE ChucNangId = @ChucNangId";
            SqlParameter[] param = { new SqlParameter("@ChucNangId", ChucNangId) };
            return provider.MyExecuteReader(sql, CommandType.Text,param);
        }

        //Kiểm tra tên đăng nhập đã tồn tại hay chưa
        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            string sql = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters = { new SqlParameter("@TenDangNhap", tenDangNhap) };

            int count = Convert.ToInt32(provider.MyExecuteScalar(sql, CommandType.Text, parameters));
            return count > 0;
        }

        //Thêm người dùng mới
        public bool AddNguoiDung(string hoTenND, string tenDangNhap, int ChucNangId,
            string soDT, string matKhau, string linkAnh)
        {
            string sql = "INSERT INTO NguoiDung (hoTenND, tenDangNhap, ChucNangId, soDT, matKhau, linkAnh) " +
                "VALUES(@hoTenND, @tenDangNhap, @ChucNangId, @soDT, @matKhau, @linkAnh)";
            SqlParameter[] param = { new SqlParameter("@hoTenND", hoTenND),
                                     new SqlParameter("@tenDangNhap",tenDangNhap),
                                     new SqlParameter("@ChucNangId",ChucNangId),
                                     new SqlParameter("@soDT", soDT),
                                     new SqlParameter("@matKhau", matKhau),
                                     new SqlParameter("@linkAnh", linkAnh)
            };
            
            return provider.MyExecuteNonQuery(sql,CommandType.Text,param) > 0;
        }

        //Xóa người dùng
        public bool DeleteNguoiDung (int maND)
        {
            string sql = "DELETE FROM NguoiDung WHERE maND = @maND";
            SqlParameter[] param = { new SqlParameter("@maND",maND)};
            return provider.MyExecuteNonQuery(sql,CommandType.Text,param) > 0;
        }
    }
}
