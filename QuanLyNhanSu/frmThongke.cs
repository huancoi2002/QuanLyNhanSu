using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFB4;


namespace QuanLyNhanSu
{
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
        }
  
        TruyXuatCSDL truyxuat = new TruyXuatCSDL();
        private void frmThongke_Load(object sender, EventArgs e)
        {
            string sql1 = "Select COUNT(*) from tblNhanVien";
            string sql2 = "Select COUNT(*) from tblPhongBan";
            string sql3 = "Select COUNT(*) from tblDuAn";
            string sql4 = "Select COUNT(*) from tblTaiKhoan";
           


            int a = Convert.ToInt32(truyxuat.executeScalar(sql1));
            int b = Convert.ToInt32(truyxuat.executeScalar(sql2));
            int c = Convert.ToInt32(truyxuat.executeScalar(sql3));
            int d = Convert.ToInt32(truyxuat.executeScalar(sql4));
           


            lblSoluongnv.Text += a;
            lblSoluongphongban.Text += b;
            lblSoluongduan.Text += c;
            lblSoluongtk.Text += d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("bạn có chắc muốn thoát không", "thông báo");
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
