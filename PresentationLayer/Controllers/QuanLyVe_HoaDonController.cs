using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Controllers
{
    public partial class QuanLyVe_HoaDonController : UserControl
    {
        public QuanLyVe_HoaDonController()
        {
            InitializeComponent();
        }

        private void btnTimKiemVe_Click(object sender, EventArgs e)
        {
            int maVe;
            if (int.TryParse(txtMaVe.Text.Trim(), out maVe))
            {
                VeChuyenBayBL veBL = new VeChuyenBayBL();
                var v = veBL.GetThongTinVeChuyenBayBL(maVe);

                if (v != null)
                {
                    lbMaHD.Text = v.maHD.ToString();
                    lbChuyenBay.Text = v.maCB.ToString();
                    lbTenHanhKhach.Text = v.tenHK;
                    lbTenGhe.Text = v.tenGhe;
                    lbNgayGioDi.Text = v.ngayGioDi.ToString("dd/MM/yyyy hh:mm");
                    lbTrangThai.Text = v.trangThai;
                    lbTuyenBay.Text = v.tuyenBay;
                    lbGiaVe.Text = v.gia.ToString("N0") + " VNĐ";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vé với mã này!!");
                }
            }
            else if (txtMaVe.Text is null)
            {
                MessageBox.Show("Mời nhập mã vé để tìm kiếm!");
                txtMaVe.Focus();
            }
            else
            {
                MessageBox.Show("Mã vé không hợp lệ! Mời nhập lại.");
                txtMaVe.Focus();

            }
        }
    }
}
