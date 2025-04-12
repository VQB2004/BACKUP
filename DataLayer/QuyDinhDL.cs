using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class QuyDinhDL
    {
        private QuyDinh quyDinh = new QuyDinh();

        public List<QuyDinh> GetQuyDinhList()
        {
            var context = new FlightManagementContext();
            return context.QuyDinhs.ToList();
        }
    }
}
