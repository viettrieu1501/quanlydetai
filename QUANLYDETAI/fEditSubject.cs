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
    public partial class fEditSpecialized : Form
    {
        private string idSubject;
        public fEditSpecialized(string idSubject)
        {
            this.idSubject = idSubject;
            InitializeComponent();
            LoadFullData();
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadFullData()
        {
            Subject subject = SubjectDAO.Instance.getBoMonByID(idSubject);
            txtNameSubject.Text = subject.TenBM;
            txtPhoneNum.Text = subject.DienThoai;
            txtRoom.Text = subject.Phong;
            txtManagerSubject.Tag = subject.TruongBM;
            cbDepartment.DataSource = DepartmentDAO.Instance.getListDepartment();
            cbDepartment.DisplayMember = "TenKhoa";
            if (subject.TruongBM != string.Empty)
            {
                Staff staff = StaffDAO.Instance.getGiaovien(subject.TruongBM);
                txtManagerSubject.Text = staff.TenNV;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtManagerSubject.Text!=string.Empty&& txtNameSubject.Text != string.Empty && txtPhoneNum.Text != string.Empty && txtRoom.Text != string.Empty)
            {
                string idManager = txtManagerSubject.Tag.ToString();
                string idDepartment = (cbDepartment.SelectedItem as Department).MaKhoa;
                if (SubjectDAO.Instance.updateSubject(idSubject, txtNameSubject.Text, txtRoom.Text, txtPhoneNum.Text, idManager, idDepartment))
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
        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }

        private void txtManagerTopic_Enter(object sender, EventArgs e)
        {
            fSelectManager f = new fSelectManager();
            f.SelectManager += F_SelectManager;
            f.ShowDialog();
        }

        private void F_SelectManager(object sender, SelectEventArgs e)
        {
            txtManagerSubject.Text = e.Name;
            txtManagerSubject.Tag = e.ID;
        }
    }
}
