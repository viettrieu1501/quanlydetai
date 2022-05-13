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
    public partial class fDepartment : Form
    {
        private string userName;
        private string role;
        BindingSource source = new BindingSource();
        public fDepartment(string userName, string role)
        {
            this.userName = userName;
            this.role = role;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullDepartment();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadFullDepartment()
        {
            dgvDepartment.DataSource = source;
            source.DataSource = DepartmentDAO.Instance.getFullDepartment();

            txtIDDepartment.DataBindings.Add(new Binding("Text", source, "MaKhoa", true, DataSourceUpdateMode.Never));
            txtDepartmentName.DataBindings.Add(new Binding("Text", source, "TenKhoa", true, DataSourceUpdateMode.Never));
            txtManager.DataBindings.Add(new Binding("Text", source, "TenNV", true, DataSourceUpdateMode.Never));
            txtRoom.DataBindings.Add(new Binding("Text", source, "Phong", true, DataSourceUpdateMode.Never));
            txtPhoneNum.DataBindings.Add(new Binding("Text", source, "dienThoai", true, DataSourceUpdateMode.Never));
            txtFoundedYear.DataBindings.Add(new Binding("Text", source, "namtl", true, DataSourceUpdateMode.Never));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (role=="p6")
            {
                if (MessageBox.Show("Bạn có muốn xóa khoa này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DepartmentDAO.Instance.deleteDepartmentByID(txtIDDepartment.Text);
                    MessageBox.Show("Xóa thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    source.DataSource = DepartmentDAO.Instance.getFullDepartment();
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
                fEditDepartment f = new fEditDepartment(txtIDDepartment.Text);
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
            source.DataSource = DepartmentDAO.Instance.getFullDepartment();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (role=="p6")
            {
                fAddDepartment f = new fAddDepartment();
                f.FormClosed += F_CloseForm;
                f.ShowDialog();
                source.DataSource = DepartmentDAO.Instance.getFullDepartment();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubjectOfDepart_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSubject f = new fSubject(userName, role, txtIDDepartment.Text);
            f.ShowDialog();
            this.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            source.DataSource = DepartmentDAO.Instance.getSearchDepartment(txtSearch.Text);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            fStaff f = new fStaff(userName, role,  txtIDDepartment.Text, "StaffOfDepartment");
            f.ShowDialog();
            this.Show();
        }

        private void btnTopicOfDepart_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTopic f = new fTopic(userName, role, txtIDDepartment.Text, "TopicOfDepartment");
            f.ShowDialog();
            this.Show();
        }
    }
}
