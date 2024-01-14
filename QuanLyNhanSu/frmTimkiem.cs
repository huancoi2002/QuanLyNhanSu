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
using System.Collections;
namespace QuanLyNhanSu
{
    public partial class frmTimkiem : Form
    {
        public frmTimkiem()
        {
            InitializeComponent();
        }
        
        private void frmTimkiem_Load(object sender, EventArgs e)
        {
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttimkiem.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy nhập thông tin tìm kiếm ", "thông báo");
                }
                else
                {
                    string sql = "select * from tblNhanVien where Ho_Ten like N'%" + txttimkiem.Text + "%'";
                    dgvMain.DataSource = TruyXuatCSDL.Laybang(sql);
                }
            }catch(Exception ex )
            {
                MessageBox.Show(ex.ToString(),"thông báo");
            }
              
            
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
