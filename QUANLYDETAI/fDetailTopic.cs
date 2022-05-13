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
    public partial class fDetailTopic : Form
    {
        private string idTopic;
        private string userName;
        private string role;
        public fDetailTopic(string userName, string role, string idTopic)
        {
            this.idTopic = idTopic;
            this.userName = userName;
            this.role = role;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullData();
        }
        private void LoadFullData()
        {
            Topic topic = TopicDAO.Instance.getTopicbyID(idTopic);
            txtNameTopic.Text = topic.TenDT;
            txtStatus.Text = topic.TinhTrangDT;
            txtStartDay.Text = topic.NgayBD.Value.ToString("d");
            txtFinishDay.Text = topic.NgayKT==null?"Chưa cập nhật":topic.NgayKT.Value.ToString("d");

            cbParticipants.DataSource = StaffDAO.Instance.getFullStaffPart(idTopic);
            cbParticipants.DisplayMember = "tennv";

            Staff staff = StaffDAO.Instance.getGiaovien(topic.MaCN);
            txtManagerTopic.Text = staff.TenNV;

            txtNumOfReport.Text = TopicDAO.Instance.getNumOfReport(idTopic).ToString();

            if (topic.MaHDNT != string.Empty)
            {
                AcceptCommit acceptCommit = AcceptCommitDAO.Instance.GetAcceptCommitById(topic.MaHDNT);
                txtCouncilName.Text = acceptCommit.TenHDNT;
                txtAcceptance.Text = acceptCommit.NgayNT.Value.ToString("d");
            }

            ResultTopic resultTopic = ResultTopicDAO.Instance.GetResultTopicByIdTopic(idTopic);
            if (resultTopic != null)
            {
                txtContentResult.Text = resultTopic.Content;
                txtRewardForm.Text = resultTopic.rewardForm;
            }

            Theme theme = ThemeDAO.Instance.getThemeByIdTheme(topic.MaCD);
            txtTheme.Text = theme.TenCD;
            txtTopicLevel.Text = TopicLevelDAO.Instance.getTopicLevelbyID(topic.MaCapDT).TenCap;
            txtDecision.Text = topic.MaQD;
            if (topic.MaCT == string.Empty)
                txtRalate.Text = "";
            else
                txtRalate.Text = RelatedWorkDAO.Instance.GetRelatedWorkByid(topic.MaCT).TenCT;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetailReport_Click(object sender, EventArgs e)
        {
            fDetailReportProgress f = new fDetailReportProgress(idTopic);
            f.ShowDialog();
        }

        private void btnUpdateAcceptCommit_Click(object sender, EventArgs e)
        {
            if (role=="p6")
            {
                fEditAcceptCommit f = new fEditAcceptCommit(idTopic);
                f.CloseForm += F_CloseForm;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateResultTopic_Click(object sender, EventArgs e)
        {
            if (role=="p6")
            {
                fEditResultTopic f = new fEditResultTopic(idTopic);
                f.CloseForm += F_CloseForm;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void F_CloseForm(object sender, EventArgs e)
        {
            LoadFullData();
        }
    }
}
