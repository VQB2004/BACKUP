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
    public partial class TaiKhoanNDController : UserControl
    {
        public TaiKhoanNDController()
        {
            InitializeComponent();
        }

        private void TaiKhoanNDController_Load(object sender, EventArgs e)
        {
            NguoiDungBL nguoidungBL = new NguoiDungBL();
            //Load danh sách tài khoản khách hàng
            DataTable dt_user = new DataTable();
            dt_user = nguoidungBL.GetNguoiDungList(3);
            dgvTKKH.AutoGenerateColumns = false;
            dgvTKKH.DataSource = dt_user;

            //Load danh sách tài khoản nhân viên
            DataTable dt_empl = new DataTable();
            dt_empl = nguoidungBL.GetNguoiDungList(2);
            dgvTKNV.AutoGenerateColumns = false;
            dgvTKNV.DataSource = dt_empl;
            
            //Load danh sách tài khoản admin
            DataTable dt_admin = new DataTable();
            dt_admin = nguoidungBL.GetNguoiDungList(1);
            dgvTKQTV.AutoGenerateColumns = false;
            dgvTKQTV.DataSource = dt_admin;
        }
    }
}
