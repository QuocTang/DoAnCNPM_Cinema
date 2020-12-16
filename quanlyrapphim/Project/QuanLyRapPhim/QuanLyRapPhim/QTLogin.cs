using QuanLyRapPhim.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class QTLogin : Form
    {
        public QTLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void BTExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QTLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public static string connectionSTR = "Data Source=DESKTOP-0599NKT\\SQLEXPRESS;Initial Catalog=QuanLyRapPhim;Integrated Security=True; User ID = tangaiquoc123; Password = 123";
        public static string LoaiTaiKhoan = "-1";
        private void BTLogin_Click(object sender, EventArgs e)
        {
           // try
           // {
                //Kiểm tra thông tin tài khoản

                SqlConnection conn = new SqlConnection(connectionSTR);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string TenTaiKhoan = TBUserName.Text.Trim();
                string MatKhau = TBPassWord.Text.Trim();
                string query = "Select * from Account where UserName ='" + TenTaiKhoan + "' AND PassWord='" + MatKhau + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    LoaiTaiKhoan = ds.Tables[0].Rows[0]["Type"].ToString();
                    QTTableManager QTManager = new QTTableManager(LoaiTaiKhoan);
                    QTManager.Show();
                    this.Hide();
                }
                else
                {
                    //Không tìm thấy
                    //  LbError.Text = "Thông tin tài khoản hoặc mật khẩu chưa chính xác.";
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu chưa chính xác");
                }
           // }
           // catch (Exception ex)
           // {
              // LbError.Text = ex.Message;
            //}

          //  this.Hide();
          //  QTTableManager QT = new QTTableManager();
           // QT.ShowDialog();
          //  this.Show();
          
        }
    }
}
