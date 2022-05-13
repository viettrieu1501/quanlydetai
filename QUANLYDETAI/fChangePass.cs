using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYDETAI.DTO;
using QUANLYDETAI.DAO;

namespace QUANLYDETAI
{
    public partial class fChangePass : Form
    {
        private string userName;
        public fChangePass(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtPassOld.Text!=string.Empty&& txtPassNew.Text != string.Empty && txtRePass.Text != string.Empty )
            {
                if (AccountDAO.MD5Hash(AccountDAO.Base64Encode(txtPassOld.Text)) == AccountDAO.Instance.getAccountbyUserName(userName).Password)
                {
                    if (txtPassNew.Text == txtRePass.Text)
                    {
                        AccountDAO.Instance.changePass(userName, txtPassNew.Text);
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
