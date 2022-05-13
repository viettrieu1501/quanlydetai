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
    public partial class fAddStaff : Form
    {
        public fAddStaff()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullData();
        }
        private void LoadFullData()
        {
            cbBoMon.DataSource = SubjectDAO.Instance.getListBoMon();
            cbBoMon.DisplayMember = "TenBM";
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtEmail.Text != string.Empty && cbLevel.Text != string.Empty && txtSDT.Text != string.Empty)
            {
                string maBM = (cbBoMon.SelectedItem as Subject).MaBM;
                if (StaffDAO.Instance.insertStaff(cbLevel.Text, txtName.Text, cbSex.Text, dpkBirthday.Value.ToString("d"), maBM, txtEmail.Text, txtSDT.Text))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
