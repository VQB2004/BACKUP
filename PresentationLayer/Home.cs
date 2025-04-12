using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Controllers;
namespace PresentationLayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void LoadController(UserControl us)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(us);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            LoadController(new HomeController());
        }

       

        private void btnQLVeHoaDon_Click(object sender, EventArgs e)
        {
            LoadController(new QuanLyVe_HoaDonController());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadController(new HomeController());
        }

        private void btnChuyenBay_Click(object sender, EventArgs e)
        {
            LoadController(new ChuyenBayController());
        }

        private void btnTuyenBay_Click(object sender, EventArgs e)
        {
            LoadController(new TuyenBayController());
        }

        private void btnMayBay_Click(object sender, EventArgs e)
        {
            LoadController(new MayBayController());
        }

        private void btnSanBay_Click(object sender, EventArgs e)
        {
            LoadController(new SanBayController());
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadController(new TaiKhoanNDController());
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            LoadController(new QuyDinhController());
        }

        private void btnThongKeBaoCao_Click(object sender, EventArgs e)
        {
            LoadController(new ThongKeBaoCaoController());
        }
    }
}
