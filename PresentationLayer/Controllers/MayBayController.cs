using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer.Controllers
{
    public partial class MayBayController : UserControl
    {
        public MayBayController()
        {
            InitializeComponent();
        }

        private void MayBayController_Load(object sender, EventArgs e)
        {
            MayBayBL mayBayBL = new MayBayBL();
            DataTable dt = new DataTable();
            dt = mayBayBL.GetMayBayList();
            dgvDSMayBay.AutoGenerateColumns = false;
            dgvDSMayBay.DataSource = dt;
        }
    }
}
