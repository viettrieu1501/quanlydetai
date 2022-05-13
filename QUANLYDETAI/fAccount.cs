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
    public partial class fAccount : Form
    {
        private string role;
        BindingSource source = new BindingSource();
        public fAccount(string role)
        {
            this.role = role;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullData();
        }
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadFullData()
        {
            dgvAccount.DataSource = source;
            source.DataSource = AccountDAO.Instance.getFullAccount();

            txtAccountType.DataBindings.Add(new Binding("Text", source, "name", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", source, "DisplayName", true, DataSourceUpdateMode.Never));
            txtUserName.DataBindings.Add(new Binding("Text", source, "username", true, DataSourceUpdateMode.Never));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (role=="p6")
            {
                if (MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    AccountDAO.Instance.deleteAccount(txtUserName.Text);
                    MessageBox.Show("Xóa thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    source.DataSource = AccountDAO.Instance.getFullAccount();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (role=="p6")
            {
                fEditAccount f = new fEditAccount(txtUserName.Text);
                f.CloseForm += F_CloseForm;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (role=="p6")
            {
                fAddAccount f = new fAddAccount();
                f.CloseForm += F_CloseForm;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void F_CloseForm(object sender, EventArgs e)
        {
            source.DataSource = AccountDAO.Instance.getFullAccount();
        }

    }
}
