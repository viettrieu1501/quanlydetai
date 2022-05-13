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
    public partial class fSelectManager : Form
    {
        BindingSource source = new BindingSource();
        public fSelectManager()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullData();
        }
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadFullData()
        {
            dgvStaff.DataSource = source;
            source.DataSource = StaffDAO.Instance.getStaffToSelect();

            txtIDStaff.DataBindings.Add(new Binding("Text", source, "manv", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", source, "tennv", true, DataSourceUpdateMode.Never));
            txtSubject.DataBindings.Add(new Binding("Text", source, "tenbm", true, DataSourceUpdateMode.Never));
        }

        private event EventHandler<SelectEventArgs> selectManager;
        public event EventHandler<SelectEventArgs> SelectManager
        {
            add { selectManager += value; }
            remove { selectManager -= value; }
        }
        private void btnSelected_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn chọn nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (selectManager != null)
                {
                    selectManager(this, new SelectEventArgs(txtIDStaff.Text, txtName.Text));
                }
                Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             source.DataSource = StaffDAO.Instance.SearchStaffToSelect(txtSearch.Text);
        }
    }
    public class SelectEventArgs : EventArgs
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public SelectEventArgs(string id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
