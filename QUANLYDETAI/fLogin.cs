using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYDETAI.DAO;

namespace QUANLYDETAI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            guna2DragControl1.SetDrag(panel1);
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.Login(txtUserName.Text,txtPassword.Text))
            {
                this.Hide();
                fManagement f = new fManagement(txtUserName.Text);
                f.LogOut += F_LogOut;
                f.ShowDialog();
                txtPassword.Text = string.Empty;
                txtUserName.Text = string.Empty;
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.\nVui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void F_LogOut(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
