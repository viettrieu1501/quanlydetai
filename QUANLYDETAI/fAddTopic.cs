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
    public partial class fAddTopic : Form
    {
        private string userName;
        private string role;
        private string maKhoa;
        public fAddTopic(string userName, string role)
        {
            this.userName = userName;
            this.role = role;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullData();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtNameTopic.Text != string.Empty && txtManagerTopic.Text != string.Empty && cbQDinh.Text != string.Empty && cbChuDe.Text != string.Empty&& cbDepartment.Text!=string.Empty&& (cbParticipants.DataSource as List<Participants>)!=null)
            {
                string maBM = (cbSubject.SelectedItem as Subject)==null?"NULL": (cbSubject.SelectedItem as Subject).MaBM;
                string maCN = txtManagerTopic.Tag.ToString();
                string maCD = (cbChuDe.SelectedItem as Theme).MaCD;
                string maCT=(cbRelatedWork.SelectedItem==null)?"NULL":(cbRelatedWork.SelectedItem as RelatedWork).MaCT;
                string maQD = (cbQDinh.SelectedItem as Decision).MaQD;
                string maCapDT = (cbCapTopic.SelectedItem as TopicLevel).MaCap;
                string makhoa = (cbDepartment.SelectedItem as Department).MaKhoa;
                if (TopicDAO.Instance.insertTopic(makhoa, maBM, txtNameTopic.Text, maCN, maCapDT, dpkStart.Value, maCD, maQD, maCT, (cbParticipants.DataSource as List<Participants>)))
                {
                    txtNameTopic.Text = string.Empty;
                    txtManagerTopic.Text = string.Empty;
                    cbParticipants.DataSource = null;
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
        private void LoadFullData()
        {
            cbCapTopic.DataSource = TopicLevelDAO.Instance.getListCapDT();
            cbCapTopic.DisplayMember = "TenCap";
            cbChuDe.DataSource = ThemeDAO.Instance.getListCD();
            cbChuDe.DisplayMember = "TenCD";
            cbQDinh.DataSource = DecisionDAO.Instance.getListQuyetDinh();
            cbQDinh.DisplayMember = "MaQD";
            cbRelatedWork.DataSource = RelatedWorkDAO.Instance.getListDetail();
            cbRelatedWork.DisplayMember = "TenCT";
            cbRelatedWork.SelectedIndex = -1;
            if (role == "p6")
                cbDepartment.DataSource = DepartmentDAO.Instance.getListDepartment();
            else
            {
                maKhoa = SubjectDAO.Instance.getBoMonByID(StaffDAO.Instance.getGiaovien(AccountDAO.Instance.getAccountbyUserName(userName).MaGV).MaBM).MaKhoa;
                cbSubject.DataSource = DepartmentDAO.Instance.getDepartmentByID(maKhoa);
            }
            cbDepartment.DisplayMember = "tenkhoa";
        }
        private void btnEditParticipants_Click(object sender, EventArgs e)
        {
            fAddParticipants f = new fAddParticipants();
            f.CloseForm += F_CloseForm;
            f.ShowDialog();
        }

        private void F_CloseForm(object sender, EventArgs e)
        {
            cbParticipants.DataSource = (sender as fAddParticipants).getListParticipants();
            cbParticipants.DisplayMember = "NameStaff";
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

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKhoa = (cbDepartment.SelectedItem as Department).MaKhoa;
            cbSubject.DataSource = SubjectDAO.Instance.getListBoMonOfDepartment(maKhoa);
            cbSubject.DisplayMember = "tenbm";
            cbSubject.SelectedIndex = -1;
        }
    }
}
