using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class QuyDinhBL
    {
        private QuyDinhDL quyDinh = new QuyDinhDL();

        public List<QuyDinh> GetQuyDinhList()
        {
            return quyDinh.GetQuyDinhList();
        }
    }
}
