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
    public partial class fProfile : Form
    {
        private string userName;
        private string idStaff;
        private string role;
        private Account acc;
        public fProfile(string userName, string role)
        {
            this.userName = userName;
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
            acc = AccountDAO.Instance.getAccountbyUserName(userName);
            TypeAccount typeAccount = TypeAccountDAO.Instance.GetTypeAccountByID(acc.MaType);
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
            txtAccountType.Text = typeAccount.Name;
            if(acc.MaGV!=string.Empty)
                LoadBaseInfo();
            else
                btnUpdateBase.Enabled = false;
        }
        private void LoadBaseInfo()
        {
            Staff gv= StaffDAO.Instance.getGiaovien(acc.MaGV);
            txtName.Text = gv.TenNV;
            txtSex.Text = gv.GioiTinh;
            dpkBirthday.Value = gv.NgaySinh.Value;
            txtLevel.Text = gv.CapBac;
            txtEmail.Text = gv.Email;
            txtPhoneNum.Text = gv.SDT;
            this.idStaff = acc.MaGV;
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            fEditAccount f = new fEditAccount(userName);
            f.CloseForm += F_CloseForm1;
            f.ShowDialog();
        }

        private void F_CloseForm1(object sender, EventArgs e)
        {
            acc = AccountDAO.Instance.getAccountbyUserName(userName);
            txtDisplayName.Text = acc.DisplayName;
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            fChangePass f = new fChangePass(userName);
            f.ShowDialog();
        }

        private void btnUpdateBase_Click(object sender, EventArgs e)
        {
            fEditStaff f = new fEditStaff(idStaff);
            f.CloseForm += F_CloseForm;
            f.ShowDialog();
        }

        private void F_CloseForm(object sender, EventArgs e)
        {
            LoadBaseInfo();
        }
    }
}
