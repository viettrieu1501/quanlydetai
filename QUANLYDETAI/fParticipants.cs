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
    public partial class fParticipants : Form
    {
        BindingSource source1 = new BindingSource();
        BindingSource source2 = new BindingSource();
        private string idTopic;
        public fParticipants(string idTopic="")
        {
            this.idTopic = idTopic;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullData();
        }
        private void LoadFullData()
        {
            dgvStaff1.DataSource = source1;
            source1.DataSource = StaffDAO.Instance.getFullStaffNotPart(idTopic);
            dgvStaff2.DataSource = source2;
            source2.DataSource = StaffDAO.Instance.getFullStaffPart(idTopic);

            txtIDStaff1.DataBindings.Add(new Binding("Text", source1, "manv", true, DataSourceUpdateMode.Never));
            txtName1.DataBindings.Add(new Binding("Text", source1, "tennv", true, DataSourceUpdateMode.Never));

            txtIdStaff2.DataBindings.Add(new Binding("Text", source2, "manv", true, DataSourceUpdateMode.Never));
            txtName2.DataBindings.Add(new Binding("Text", source2, "tennv", true, DataSourceUpdateMode.Never));
            cbRole2.DataBindings.Add(new Binding("Text", source2, "vaitro", true, DataSourceUpdateMode.Never));
            txtParticipationPoints2.DataBindings.Add(new Binding("Text", source2, "diem_tg", true, DataSourceUpdateMode.Never));
        }
        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            closeForm(this, new EventArgs());
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            StaffDAO.Instance.deleteStaffParti(txtIdStaff2.Text, idTopic);
            MessageBox.Show("Xóa thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            source2.DataSource = StaffDAO.Instance.getFullStaffPart(idTopic);
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            source1.DataSource = StaffDAO.Instance.getSearchStaff(txtSearch1.Text);
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            source2.DataSource = StaffDAO.Instance.getSearchStaff(txtSearch2.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDStaff1.Text != string.Empty && txtName1.Text != string.Empty && cbRole.Text != string.Empty && numPoint.Text != string.Empty)
            {
                StaffDAO.Instance.insertStaffParti(txtIDStaff1.Text, idTopic, cbRole.Text, numPoint.Text);
                source1.DataSource = StaffDAO.Instance.getFullStaffNotPart(idTopic);
                source2.DataSource = StaffDAO.Instance.getSearchStaff(txtSearch2.Text);
                MessageBox.Show("Thêm thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
