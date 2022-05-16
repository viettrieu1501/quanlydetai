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
        BindingSource source = new BindingSource();
        public fAccount()
        {
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
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AccountDAO.Instance.deleteAccount(txtUserName.Text);
                MessageBox.Show("Xóa thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                source.DataSource = AccountDAO.Instance.getFullAccount();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditAccount f = new fEditAccount(txtUserName.Text);
            f.CloseForm += F_CloseForm;
            f.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddAccount f = new fAddAccount();
            f.CloseForm += F_CloseForm;
            f.ShowDialog();
        }

        private void F_CloseForm(object sender, EventArgs e)
        {
            source.DataSource = AccountDAO.Instance.getFullAccount();
        }

    }
}
