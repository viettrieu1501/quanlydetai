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
    public partial class fEditTopic : Form
    {
        private string maDT;
        private string userName;
        private string maCN;
        private string maKhoa;
        private string role;
        public fEditTopic(string userName, string role, string maDT)
        {
            this.maDT = maDT;
            this.role = role;
            this.userName = userName;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadData();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadData()
        {
            Topic topic = TopicDAO.Instance.getTopicbyID(maDT);
            Staff staff = StaffDAO.Instance.getGiaovien(topic.MaCN);
            this.maCN = topic.MaCN;
            txtNameTopic.Text = topic.TenDT;
            dpkStart.Value = topic.NgayBD.Value;
            if(topic.NgayKT!=null) dpkFinish.Value = topic.NgayKT.Value;
            cbCapTopic.DataSource = TopicLevelDAO.Instance.getListCapDT();
            cbCapTopic.DisplayMember = "TenCap";
            cbChuDe.DataSource = ThemeDAO.Instance.getListCD();
            cbChuDe.DisplayMember = "TenCD";
            cbQDinh.DataSource = DecisionDAO.Instance.getListQuyetDinh();
            cbQDinh.DisplayMember = "MaQD";
            cbDetail.DataSource = RelatedWorkDAO.Instance.getListDetail();
            cbDetail.DisplayMember = "TenCT";
            cbParticipants.DataSource = StaffDAO.Instance.getListStaffByIdTopic(maDT);
            cbParticipants.DisplayMember = "tennv";
            txtManagerTopic.Text = staff.TenNV;
            txtManagerTopic.Tag = staff.MaNV;
            cbStatus.Text = topic.TinhTrangDT;
            if (topic.MaKhoa != string.Empty)
                cbDepartment.Text = DepartmentDAO.Instance.getDepartmentByID(topic.MaKhoa).TenKhoa;
            if(topic.MaBM!=string.Empty)
                cbSubject.Text = SubjectDAO.Instance.getBoMonByID(topic.MaBM).TenBM;
            if (TopicDAO.Instance.getNumOfReport(maDT) <=3)
            {
                dpkFinish.Enabled = false;
            }
            if (role == "p6")
                cbDepartment.DataSource = DepartmentDAO.Instance.getListDepartment();
            else
            {
                maKhoa = SubjectDAO.Instance.getBoMonByID(StaffDAO.Instance.getGiaovien(AccountDAO.Instance.getAccountbyUserName(userName).MaGV).MaBM).MaKhoa;
                cbSubject.DataSource = DepartmentDAO.Instance.getDepartmentByID(maKhoa);
            }
            cbDepartment.DisplayMember = "tenkhoa";
            if (topic.MaCT == string.Empty)
            {
                cbDetail.SelectedIndex = -1;
            }
            else
            {
                cbDetail.Text = RelatedWorkDAO.Instance.GetRelatedWorkByid(topic.MaCT).TenCT;
            }
        }
        private event EventHandler updateTopic;
        public event EventHandler UpdateTopic
        {
            add { updateTopic += value; }
            remove { updateTopic -= value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text!=string.Empty&&txtNameTopic.Text!=string.Empty&& txtManagerTopic.Text != string.Empty && cbCapTopic.Text != string.Empty  && cbQDinh.Text != string.Empty && cbDepartment.Text != string.Empty && cbChuDe.Text != string.Empty)
            {
                string maCN = txtManagerTopic.Tag as string;
                string maCD = (cbChuDe.SelectedItem as Theme).MaCD;
                string maCT = (cbDetail.SelectedItem as RelatedWork)==null? "NULL":(cbDetail.SelectedItem as RelatedWork).MaCT;
                string maQD = (cbQDinh.SelectedItem as Decision).MaQD;
                string maCapDT = (cbCapTopic.SelectedItem as TopicLevel).MaCap;
                string maBM = (cbSubject.SelectedItem as Subject)==null?"NULL": (cbSubject.SelectedItem as Subject).MaBM;
                string ngayKT = (dpkFinish.Enabled == true) ? dpkFinish.Value.ToString("d") : "NULL";
                if (TopicDAO.Instance.updateTopic(maDT, maCN, maCapDT, txtNameTopic.Text, dpkStart.Value.ToString("d"), ngayKT, cbStatus.Text, maKhoa, maBM, maCD, maQD, maCT))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateTopic(this, new EventArgs());
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

        private void btnEditParticipants_Click(object sender, EventArgs e)
        {
            fParticipants f = new fParticipants(maDT);
            f.CloseForm += F_CloseForm;
            f.ShowDialog();
        }

        private void F_CloseForm(object sender, EventArgs e)
        {
            cbParticipants.DataSource = StaffDAO.Instance.getListStaffByIdTopic(maDT);
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
