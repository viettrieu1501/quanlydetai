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
    public partial class fSubject : Form
    {
        private string userName;
        private string role;
        private string idDepartment = "";
        BindingSource source = new BindingSource();
        public fSubject(string userName, string role, string idDepartment="")
        {
            this.userName = userName;
            this.role = role;
            this.idDepartment = idDepartment;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            dgvSubject.DataSource = source;
            LoadData();
            LoadBindingSource();
        }
        private void LoadBindingSource()
        {
            txtIDSubject.DataBindings.Add(new Binding("Text", source, "mabm", true, DataSourceUpdateMode.Never));
            txtNameSubject.DataBindings.Add(new Binding("Text", source, "TenBM", true, DataSourceUpdateMode.Never));
            txtManager.DataBindings.Add(new Binding("Text", source, "tenNV", true, DataSourceUpdateMode.Never));
            txtDepartment.DataBindings.Add(new Binding("Text", source, "tenKhoa", true, DataSourceUpdateMode.Never));
            txtPhoneNum.DataBindings.Add(new Binding("Text", source, "dienThoai", true, DataSourceUpdateMode.Never));
            txtRoom.DataBindings.Add(new Binding("Text", source, "Phong", true, DataSourceUpdateMode.Never));
        }
        private void LoadData()
        {
            if (idDepartment != string.Empty)
            {
                source.DataSource = SubjectDAO.Instance.getSubjectOfDepartment(idDepartment);
            }
            else
            {
                source.DataSource = SubjectDAO.Instance.getFullSubject();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (role=="p6")
            {
                if (MessageBox.Show("Bạn có muốn xóa bộ môn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SubjectDAO.Instance.deleteSubjectByID(txtIDSubject.Text);
                    MessageBox.Show("Xóa thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    source.DataSource = SubjectDAO.Instance.getFullSubject();
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
                fEditSpecialized f = new fEditSpecialized(txtIDSubject.Text);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (role=="p6")
            {
                fAddSubject f = new fAddSubject();
                f.CloseForm += F_CloseForm;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (idDepartment != string.Empty)
            {
                source.DataSource = SubjectDAO.Instance.getSearchSubjectOfDepart(idDepartment, txtSearch.Text);
            }
            else 
                source.DataSource = SubjectDAO.Instance.getSearchSubject(txtSearch.Text);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            fStaff f = new fStaff(userName, role, txtIDSubject.Text,"StaffOfSubject");
            f.ShowDialog();
            this.Show();
        }

        private void btnTopicOfSubject_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTopic f = new fTopic(userName, role, txtIDSubject.Text, "TopicOfSubject");
            f.ShowDialog();
            this.Show();
        }
    }
}
