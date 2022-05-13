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
    public partial class fEditResultTopic : Form
    {
        private string idTopic;
        public fEditResultTopic(string idTopic)
        {
            this.idTopic = idTopic;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadData();
        }
        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LoadData()
        {
            if (idTopic != string.Empty)
            {
                ResultTopic resultTopic = ResultTopicDAO.Instance.GetResultTopicByIdTopic(idTopic);
                Topic topic = TopicDAO.Instance.getTopicbyID(idTopic);
                cbContent.Text = resultTopic.Content;
                txtNameTopic.Text = topic.TenDT;
                cbRewardForm.Text = resultTopic.rewardForm;
                dpkProtection.Value = resultTopic.ProtecDay.Value;
                numPoint.Value = (int)resultTopic.Point;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ResultTopicDAO.Instance.UpdateResultTopic(idTopic, dpkProtection.Value.ToString("d"), cbContent.Text, cbRewardForm.Text, numPoint.Value.ToString()))
            {
                MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeForm(this, new EventArgs());
                Close();
            }
        }
    }
}
