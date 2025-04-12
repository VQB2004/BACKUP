using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class MayBayBL
    {
        private MayBayDL maybayDL = new MayBayDL();

        // Lấy danh sách máy bay
        public DataTable GetMayBayList()
        {
            return maybayDL.GetMayBayList();
        }

        // Thêm máy bay
        public bool AddMayBay(string tenMB, string slGheH1, string slGhePT, int maLoaiMB)
        {
            // Kiểm tra dữ liệu đầu vào, tránh trường hợp nhập chuỗi trống hoặc chỉ toàn khoảng trắng
            if (string.IsNullOrWhiteSpace(tenMB) || string.IsNullOrWhiteSpace(slGheH1) || string.IsNullOrWhiteSpace(slGhePT) || string.IsNullOrWhiteSpace(maLoaiMB.ToString()))
            {
                return false; // Dữ liệu không hợp lệ, không thực hiện thêm vào database
            }

            // Gọi đến lớp dữ liệu (MayBayDL) để thêm máy bay
            return maybayDL.AddMayBay(tenMB.Trim(), slGheH1.Trim(), slGhePT.Trim(), maLoaiMB); // Xóa khoảng trắng dư thừa
        }


        // Xóa máy bay
        public bool DeleteSanBay(int id)
        {
            return maybayDL.DeleteMayBay(id);
        }
    }
}
