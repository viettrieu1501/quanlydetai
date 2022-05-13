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
    public partial class fReportProgress : Form
    {
        private string idTopic;
        private string nameTopic;
        public fReportProgress(string idTopic, string nameTopic)
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            this.idTopic = idTopic;
            this.nameTopic = nameTopic;
            LoadData();
        }
        private void LoadData()
        {
            ReportProgress reportProgress = ReportProgressDAO.Instance.GetReportProgressByID(idTopic);
            txtNameTopic.Text = nameTopic;
            if (reportProgress != null)
            {
                nudHT.Minimum = (int)reportProgress.HT;
                nudHT.Value = (int)reportProgress.HT;
            }
        }

        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtContent.Text!=string.Empty&&txtKNHT.Text!=string.Empty&&txtKNTT.Text!=string.Empty)
            {
                ReportProgressDAO.Instance.insertProgress(idTopic, txtContent.Text, txtKNHT.Text, txtKNTT.Text, dpkReport.Value.ToString("d"), (float)nudHT.Value);
                MessageBox.Show("Đã báo cáo xong tiến độ đề tài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
