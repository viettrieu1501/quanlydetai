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
    public partial class fEditDepartment : Form
    {
        private string idDepartment;
        public fEditDepartment(string idDepartment)
        {
            this.idDepartment = idDepartment;
            InitializeComponent();
            LoadFullData();
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void LoadFullData()
        {
            Department department = DepartmentDAO.Instance.getDepartmentByID(idDepartment);
            txtNameDepartment.Text = department.TenKhoa;
            numYear.Text = department.NamTL.ToString();
            txtPhoneNum.Text = department.DienThoai;
            txtRoom.Text = department.Phong;
            if(department.TruongKhoa!=string.Empty) txtManagerDepartment.Text= StaffDAO.Instance.getGiaovien(department.TruongKhoa).TenNV;
            numYear.Maximum = System.DateTime.Now.Year;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNameDepartment.Text != string.Empty && numYear.Text != string.Empty && txtPhoneNum.Text != string.Empty && txtRoom.Text != string.Empty)
            {
                string maTP = txtManagerDepartment.Tag.ToString();
                if (DepartmentDAO.Instance.updateDepartment(idDepartment, txtNameDepartment.Text, numYear.Text, maTP, txtRoom.Text, txtPhoneNum.Text))
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
            txtManagerDepartment.Text = e.Name;
            txtManagerDepartment.Tag = e.ID;
        }
    }
}
