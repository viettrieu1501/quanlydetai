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
using QUANLYDETAI.DTO;

namespace QUANLYDETAI
{
    public partial class fAddAccount : Form
    {
        public fAddAccount()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }
        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text!=string.Empty&& txtManagerTopic.Text!=string.Empty&& txtRePassword.Text != string.Empty && txtPassword.Text != string.Empty && txtDisplayName.Text != string.Empty )
            {
                  if (txtPassword.Text==txtRePassword.Text)
                  {
                       if(AccountDAO.Instance.insertAccount(txtUserName.Text, txtDisplayName.Text, txtManagerTopic.Tag.ToString(), txtPassword.Text))
                       {
                            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            closeForm(this, new EventArgs());
                            Close();
                       } 
                       else
                            MessageBox.Show("UserName đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                  else
                  {
                       MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtManagerTopic_Enter(object sender, EventArgs e)
        {
            fSelectManager f = new fSelectManager();
            f.SelectManager += F_SelectManager;
            f.ShowDialog();
        }

        private void F_SelectManager(object sender, SelectEventArgs e)
        {
            txtManagerTopic.Text = e.Name;
            txtManagerTopic.Tag = e.ID;
        }
    }
}
