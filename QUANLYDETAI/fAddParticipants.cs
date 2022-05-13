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
    public partial class fAddParticipants : Form
    {
        BindingSource source = new BindingSource();
        public fAddParticipants()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullData();
        }
        private void LoadFullData()
        {
            dgvStaff.DataSource = source;
            source.DataSource = StaffDAO.Instance.getFullStaffToParti();

            txtIDStaff.DataBindings.Add(new Binding("Text", source, "manv", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", source, "tennv", true, DataSourceUpdateMode.Never));

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

        List<Participants> list = new List<Participants>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDStaff.Text != string.Empty && txtName.Text != string.Empty && cbRole.Text != string.Empty && numPoint.Text != string.Empty)
            {
                dgvStaff.Rows.RemoveAt(dgvStaff.CurrentRow.Index);
                list.Add(new Participants(txtIDStaff.Text, txtName.Text, "", cbRole.Text, (int)numPoint.Value));
                MessageBox.Show("Thêm thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public List<Participants> getListParticipants()
        {
            return list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
