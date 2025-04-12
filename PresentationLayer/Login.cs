using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cnStr = "Data Source=.;Initial Catalog=FlightManagement;Integrated Security=True;Encrypt=False"; 

            string sql = "Select * from QUYDINH";

            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                try
                {
                    cn.Open(); // Mở kết nối

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Đổ dữ liệu vào DataTable

                    dgv.DataSource = dt; // Gán dữ liệu cho DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
