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
    public class HoaDonDL
    {
        public HoaDonTO GetThongTinHoaDon(int maHD)
        {
            DataProvider provider = new DataProvider();
            SqlParameter[] param = { new SqlParameter("@maHD", maHD) };
            DataTable dt = provider.MyExecuteReader("sp_LayThongTinHoaDon", CommandType.StoredProcedure, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new HoaDonTO
            {
                maHD = Convert.ToInt32(row["maHD"]),
                ngayLapHD = Convert.ToDateTime(row["ngayLapHD"]),
                phuongThucTT = row["phuongThucTT"].ToString(),
                tongTien = Convert.ToDouble(row["tongTien"]),
                nguoiLapHD = row["nguoiLap"].ToString()
            };
        }

    }
}
