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
    public partial class fTopic : Form
    {
        private string userName;
        private string role;
        private string id="";
        private string nameObject="";
        private string year = "";
        BindingSource source = new BindingSource();
        
        public fTopic(string userName, string role, string id = "", string nameObject="", string year="")
        {
            this.userName = userName;
            this.role = role;
            this.id = id;
            this.year = year;
            this.nameObject = nameObject;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            dgvTopic.DataSource = source;
            LoadData();
            LoadBindingSource();
        }
        private void LoadData()
        {

            if (nameObject == "TopicOfStaff")
            {
                source.DataSource = TopicDAO.Instance.getTopicByidStaff(id);
            }
            else if (nameObject == "TopicOfDepartment")
            {
                source.DataSource = TopicDAO.Instance.getTopicOfDepartment(id);
            }
            else if (nameObject == "TopicOfSubject")
            {
                source.DataSource = TopicDAO.Instance.getTopicOfSubject(id);
            }
            else if (nameObject == "StatisticByStatus")
            {
                source.DataSource = TopicDAO.Instance.getTopicByStatus(id, year);
            }
            else
            {
                source.DataSource = TopicDAO.Instance.getFullTopic();
            }
        }

        private void LoadBindingSource()
        {
            txtIDTopic.DataBindings.Add(new Binding("Text", source, "MaDT", true, DataSourceUpdateMode.Never));
            txtNameTopic.DataBindings.Add(new Binding("Text", source, "TenDT", true, DataSourceUpdateMode.Never));
            txtCapDT.DataBindings.Add(new Binding("Text", source, "TenCap", true, DataSourceUpdateMode.Never));
            txtCNDT.DataBindings.Add(new Binding("Text", source, "TenNV", true, DataSourceUpdateMode.Never));
            txtStartDay.DataBindings.Add(new Binding("Text", source, "ngaybd", true, DataSourceUpdateMode.Never));
            txtFinishDay.DataBindings.Add(new Binding("Text", source, "ngaykt", true, DataSourceUpdateMode.Never));
            txtDepartment.DataBindings.Add(new Binding("Text", source, "tenkhoa", true, DataSourceUpdateMode.Never));
        }
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            Close();
        }
     
        private void btnReport_Click_1(object sender, EventArgs e)
        {
            if (role=="p6"||(role=="admin" && TopicDAO.Instance.checkRoleToTopic(txtIDTopic.Text, userName)))
            {
                if(TopicDAO.Instance.checkReportTopic(txtIDTopic.Text))
                {
                    fReportProgress f = new fReportProgress(txtIDTopic.Text, txtNameTopic.Text);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đã báo cáo tiến độ đủ 3 lần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (role=="p6"||role=="admin")
            {
                fAddTopic f = new fAddTopic(userName, role);
                f.CloseForm += F_CloseForm;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void F_CloseForm(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (role == "p6" || (role == "admin" && TopicDAO.Instance.checkRoleToTopic(txtIDTopic.Text, userName)))
            {
                if (MessageBox.Show("Bạn có muốn xóa đề tài không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (TopicDAO.Instance.deleteTopic(txtIDTopic.Text))
                    {
                        MessageBox.Show("Xóa thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        source.DataSource = TopicDAO.Instance.getFullTopic();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa đề tài này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (role == "p6" || (role == "admin" && TopicDAO.Instance.checkRoleToTopic(txtIDTopic.Text, userName)))
            {
                fEditTopic f = new fEditTopic(userName, role, txtIDTopic.Text);
                f.UpdateTopic += F_UpdateTopic;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void F_UpdateTopic(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            fDetailTopic f = new fDetailTopic(userName, role, txtIDTopic.Text);
            f.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (nameObject == "TopicOfStaff")
            {
                source.DataSource = TopicDAO.Instance.SearchTopicOfStaff(id, txtSearch.Text);
            }
            else if (nameObject == "TopicOfDepartment")
            {
                source.DataSource = TopicDAO.Instance.getSearchTopicOfDepart(txtSearch.Text, id);
            }
            else if (nameObject == "TopicOfSubject")
            {
                source.DataSource = TopicDAO.Instance.getSearchTopicOfDepart(txtSearch.Text, id);
            }
            else
            {
                source.DataSource = TopicDAO.Instance.SearchTopic(txtSearch.Text);
            }
        }
    }
}
