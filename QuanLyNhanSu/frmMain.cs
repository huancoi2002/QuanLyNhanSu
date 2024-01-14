using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain(String LoaiTKhoan)
        {
            this.IsMdiContainer = true;
            InitializeComponent();
            if(LoaiTKhoan == "0")
            {
                mnuDanhMuc.Enabled = true;
                mnuQLHeThong.Enabled = true;
                mnuQLHoSo.Enabled = true;
            }
            else
            {
                mnuDanhMuc.Enabled = false;
                mnuQLHeThong.Enabled = false;
                mnuQLHoSo.Enabled = true;
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void chucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChucVu chucvu = new frmChucVu();
            chucvu.MdiParent=this;
            chucvu.Show();
          //  chucvu.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult traloi = MessageBox.Show("bạn có chắc muốn thoát không", "thông báo");
            if (traloi == DialogResult.OK)
            {
                frmLogin lgin = new frmLogin();
                lgin.Show();
                this.Close();
            }
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmPhongBan phongban = new frmPhongBan();
            phongban.MdiParent=this;
            phongban.Show();
        }

        private void duToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuAn duan = new frmDuAn();
            duan.MdiParent = this;
            duan.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan();
            tk.MdiParent = this;
            tk.Show();
        }

        private void quảnLýChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuQLHeThong_Click(object sender, EventArgs e)
        {

        }
        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien ();
            nv.MdiParent = this;
            nv.Show();
        }

        private void timToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiem timkiem = new frmTimkiem();
            timkiem.MdiParent = this;
            timkiem.Show();
        }

        private void bảngThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongke thongke = new frmThongke();
            thongke.MdiParent = this;
            thongke.Show();
        }
    }
}
