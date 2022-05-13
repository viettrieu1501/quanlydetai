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
    public partial class fEditStaff : Form
    {
        private string idStaff;
        public fEditStaff(string idStaff)
        {
            this.idStaff = idStaff;
            InitializeComponent();
            LoadData();
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void LoadData()
        {
            Staff gv = StaffDAO.Instance.getGiaovien(idStaff);
            txtName.Text = gv.TenNV;
            cbLevel.Text = gv.CapBac;
            txtSDT.Text = gv.SDT;
            txtEmail.Text = gv.Email;
            dpkBirthday.Value = gv.NgaySinh.Value;
            cbBoMon.DataSource = SubjectDAO.Instance.getListBoMon();
            cbBoMon.DisplayMember = "TenBM";
            if(gv.MaBM!=string.Empty)cbBoMon.Text = SubjectDAO.Instance.getBoMonByID(gv.MaBM).TenBM;
            cbSex.Text = gv.GioiTinh;
        }
        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtEmail.Text != string.Empty  && txtSDT.Text != string.Empty)
            {

                string maBM = (cbBoMon.SelectedItem as Subject).MaBM;
                if (StaffDAO.Instance.updateStaff(idStaff, txtName.Text, cbSex.Text, dpkBirthday.Value.ToString("d"),maBM,txtEmail.Text,txtSDT.Text))
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
    }
}
