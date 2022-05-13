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
    public partial class fStaff : Form
    {
        private string role;
        private string userName;
        private string id;
        private string nameObject;
        BindingSource source = new BindingSource();
        public fStaff(string userName, string role, string id="", string nameObject="")
        {
            this.id = id;
            this.nameObject = nameObject;
            this.userName = userName;
            this.role = role;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            dgvStaff.DataSource = source;
            LoadData();
            BindingData();
        }
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadData()
        {
            
            if (nameObject=="StaffOfSubject")
            {
                source.DataSource = StaffDAO.Instance.getStaffByIDSubject(id);
            }
            else if (nameObject == "StaffOfDepartment")
            {
                source.DataSource = StaffDAO.Instance.getStaffByIDDepartment(id);
            }
            else
            {
                source.DataSource = StaffDAO.Instance.getFullStaff();
            }
        }
        private void BindingData()
        {
            txtIDStaff.DataBindings.Add(new Binding("Text", source, "MaNV", true, DataSourceUpdateMode.Never));
            txtBoMon.DataBindings.Add(new Binding("Text", source, "TenBM", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", source, "Email", true, DataSourceUpdateMode.Never));
            txtLevel.DataBindings.Add(new Binding("Text", source, "CapBac", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", source, "TenNV", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", source, "SDT", true, DataSourceUpdateMode.Never));
            txtSex.DataBindings.Add(new Binding("Text", source, "GioiTinh", true, DataSourceUpdateMode.Never));
            dpkBirthday.DataBindings.Add(new Binding("Value", source, "NgaySinh", true, DataSourceUpdateMode.Never));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (role=="p6"||(role=="admin"&&StaffDAO.Instance.checkRoleToStaff(userName, txtIDStaff.Text)))
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    StaffDAO.Instance.deleteStaff(txtIDStaff.Text);
                    source.DataSource = StaffDAO.Instance.getFullStaff();
                    MessageBox.Show("Xóa thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (role == "p6" || (role == "admin" && StaffDAO.Instance.checkRoleToStaff(userName, txtIDStaff.Text)))
            {
                fEditStaff f = new fEditStaff(txtIDStaff.Text);
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
            if (role=="p6"||role=="admin")
            {
                fAddStaff f = new fAddStaff();
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
            LoadData();
        }

        private void btnTopicParti_Click(object sender, EventArgs e)
        {
            fTopic f = new fTopic(userName, role, txtIDStaff.Text, "TopicOfStaff");
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (nameObject == "StaffOfSubject")
            {
                source.DataSource = StaffDAO.Instance.getSearchStaffByIDSubject(id,txtSearch.Text);
            }
            else if (nameObject == "StaffOfDepartment")
            {
                source.DataSource = StaffDAO.Instance.getSearchStaffByIDDepartment(id, txtSearch.Text);
            }
            else
            {
                source.DataSource = StaffDAO.Instance.getSearchStaff(txtSearch.Text);
            }
        }
    }
}
