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
    public partial class fEditAccount : Form
    {
        private string userName;
        public fEditAccount(string userName)
        {
            this.userName = userName;
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
            Account acc = AccountDAO.Instance.getAccountbyUserName(userName);
            txtAccountType.Text = TypeAccountDAO.Instance.GetTypeAccountByID(acc.MaType).Name;
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
            if (acc.MaGV != string.Empty)
            {
                Staff staff = StaffDAO.Instance.getGiaovien(acc.MaGV);
                txtName.Text = staff.TenNV;
                txtName.Tag = acc.MaGV;
            }
        }
        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            if(txtDisplayName.Text!=string.Empty&&txtName.Text!=string.Empty)
            {
                if (AccountDAO.Instance.updateAccount(userName, txtDisplayName.Text,txtName.Tag.ToString()))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    closeForm(this, new EventArgs());
                    Close();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            fSelectManager f = new fSelectManager();
            f.SelectManager += F_SelectManager;
            f.ShowDialog();
        }

        private void F_SelectManager(object sender, SelectEventArgs e)
        {
            txtName.Text = e.Name;
            txtName.Tag = e.ID;
        }
    }
}
