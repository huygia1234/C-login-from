using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__login_from
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text =="admin" && txtPass.Text =="234")
            {
                this.Close();
                FrmMain FrmMain = new FrmMain();
            this.Hide();
            FrmMain.ShowDialog();
            this.Close();  
            }
            else 
            {
                MessageBox.Show("Sai tên đăng nhập mật khẩu","lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
