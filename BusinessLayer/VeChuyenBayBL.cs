using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class VeChuyenBayBL
    {
        private VeChuyenBayDL veCBDL = new VeChuyenBayDL();

        public VeChuyenBayTO GetThongTinVeChuyenBayBL(int maVe)
        {
            return veCBDL.GetThongTinVeChuyenBayDL(maVe);
        }
    }
}
