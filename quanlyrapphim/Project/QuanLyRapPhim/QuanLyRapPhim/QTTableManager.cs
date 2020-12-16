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
    public partial class QTTableManager : Form
    {
        public QTTableManager(string LoaiTaiKhoan)
        {
            InitializeComponent();
            if (LoaiTaiKhoan == "1")
            {
                //admin
                adminToolStripMenuItem.Enabled = true;
                thôngTinTàiKhoảnToolStripMenuItem.Enabled = true;
            }
            else
            {
                //user
                adminToolStripMenuItem.Enabled = false;
                thôngTinTàiKhoảnToolStripMenuItem.Enabled = true;
            }


            listItem = new List<Phim>()
            {
                new Phim(){name="Recon", price="75.000vnd"},
                new Phim(){name="Tom&Jerry", price="80.000vnd"},
                new Phim(){name="Soul", price="110.000vnd"},
                new Phim(){name="Wonder Woman", price="100.000vnd"},
                new Phim(){name="Freaky", price="95.000vnd"},
                new Phim(){name="Doreamon", price="90.000vnd"}

            };
            CBPhim.DataSource = listItem;
            CBPhim.DisplayMember = "name";

        }
      
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QTLogin QT = new QTLogin();
            QT.Show();
            this.Close();
            
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QTAccountProfile QT = new QTAccountProfile();
            QT.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QTAdmin QT = new QTAdmin();
            QT.ShowDialog();
        }

        private void LVBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<Phim> listItem;
        private void CBPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue !=null)
            {
                Phim phim = cb.SelectedValue as Phim;
                textBox1.Text = phim.price.ToString();
            }
        }

        private void BTAddPhim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt vé thành công");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTCheckOut_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void CBGhe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Phim
    {
        public string name { get; set; }
        public string price { get; set; }
    }
}
