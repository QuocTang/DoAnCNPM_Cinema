using QuanLyRapPhim.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class QTAdmin : Form
    {
        public QTAdmin()
        {
            InitializeComponent();
            LoadAccountList();
            LoadPhimList();
            LoadDoanhThu();
          
        }
        void LoadAccountList()
        {
            string query = "SELECT UserName as [Tên đăng nhập], DisplayName as [Tên Hiển Thị],  PassWord as [Mật khẩu] from dbo.Account";
            DataProvider provider = new DataProvider();
            DTGVAccount.DataSource = provider.ExecuteQuery(query);
        }
      void LoadPhimList()
        {
            string query = "Select name as [Phim], theloai as [Thể loại], price as [Giá] from dbo.Phim1";
            DataProvider provider = new DataProvider();
            DTGVPhim.DataSource = provider.ExecuteQuery(query);
        }
        void LoadDoanhThu()
        {
            string query = "Select nameDT as [Tên phim], DT as [Doanh thu], BanDuoc as [Số vé bán được], SuatChieu as [Số suất chiếu] from dbo.DoanhThu";
            DataProvider provider = new DataProvider();
            DTGVBill.DataSource = provider.ExecuteQuery(query);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTSearchPhim_Click(object sender, EventArgs e)
        {

        }

        private void TCAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTAddPhim_Click(object sender, EventArgs e)
        {

        }

        private void BTDelete_Click(object sender, EventArgs e)
        {

        }

        private void BTEdit_Click(object sender, EventArgs e)
        {

        }

        private void DTGVPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBTenPhim_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QTAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
