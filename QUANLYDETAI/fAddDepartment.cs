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
    public partial class fAddDepartment : Form
    {
        public fAddDepartment()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            numYear.Maximum = System.DateTime.Now.Year;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameDepartment.Text != string.Empty && numYear.Text != string.Empty && txtPhoneNum.Text != string.Empty && txtRoom.Text != string.Empty)
            {
                string maTP = txtManagerTopic.Tag.ToString();
                if (DepartmentDAO.Instance.insertDepartment(txtNameDepartment.Text, numYear.Text, maTP, txtRoom.Text, txtPhoneNum.Text))
                {
                    MessageBox.Show("Thêm khoa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void txtManagerTopic_Enter(object sender, EventArgs e)
        {
            fSelectManager f = new fSelectManager();
            f.SelectManager += F_SelectManager;
            f.ShowDialog();
        }

        private void F_SelectManager(object sender, SelectEventArgs e)
        {
            txtManagerTopic.Text = e.Name;
            txtManagerTopic.Tag = e.ID;
        }
        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }
    }
}
