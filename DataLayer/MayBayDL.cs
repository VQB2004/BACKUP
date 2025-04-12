using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MayBayDL
    {
        private DataProvider provider = new DataProvider();
        //Lấy danh sách máy bay
        public DataTable GetMayBayList()
        {
            string sql = "SELECT * FROM MayBay";
            return provider.MyExecuteReader(sql, CommandType.Text);
        }

        // Thêm máy bay mới
        public bool AddMayBay(string tenMB, string slGheH1, string slGhePT, int maLoaiMB)
        {
            string sql = "INSERT INTO MayBay (tenMB, slGheH1, slGhePT, maLoaiMB) VALUES (@TenMB, @slGheH1, @slGhePT, @maLoaiMB)";
            SqlParameter[] param = {
                new SqlParameter("@TenMB", tenMB),
                new SqlParameter("@slGheH1", slGheH1),
                new SqlParameter("@slGhePT", slGhePT),
                new SqlParameter("@maLoaiMB", maLoaiMB)
            };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        // Xóa máy bay
        public bool DeleteMayBay(int maMB)
        {
            string sql = "DELETE FROM MayBay WHERE maMB = @ID";
            SqlParameter[] param = { new SqlParameter("@ID", maMB) };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }
    }
}
