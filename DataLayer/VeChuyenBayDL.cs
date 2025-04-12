using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class VeChuyenBayDL
    {
        private DataProvider provider = new DataProvider();

        public VeChuyenBayTO GetThongTinVeChuyenBayDL(int maVe)
        {
            string sql = "sp_TraCuuThongTinVe";
            SqlParameter[] param = {
                new SqlParameter("@maVe", maVe)
            };
            DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure, param);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new VeChuyenBayTO
                {
                    maVe = Convert.ToInt32(row["maVe"]),
                    tenHK = row["tenHK"].ToString(),
                    maHD = Convert.ToInt32(row["maHD"]),
                    ngayLapHD = Convert.ToDateTime(row["ngayLapHD"]),
                    maCB = Convert.ToInt32(row["maCB"]),
                    ngayGioDi = Convert.ToDateTime(row["ngayGioDi"]),
                    tuyenBay = row["tuyenBay"].ToString(),
                    tenGhe = row["tenGhe"].ToString(),
                    hangGhe = row["hangGhe"].ToString(),
                    gia = Convert.ToDouble(row["gia"]),
                    trangThai = row["trangThai"].ToString()

                };
            }

            return null;
        }
    
    }
}
