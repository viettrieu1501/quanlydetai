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
    public partial class fEditAcceptCommit : Form
    {
        private string idTopic;
        public fEditAcceptCommit(string idTopic)
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
                Topic topic = TopicDAO.Instance.getTopicbyID(idTopic);
                txtNameTopic.Text = topic.TenDT;
                cbAcceptCommit.DataSource = AcceptCommitDAO.Instance.getListHDNT();
                cbAcceptCommit.DisplayMember = "TenHDNT";
                dpkAccecpt.Value = (cbAcceptCommit.SelectedItem as AcceptCommit).NgayNT.Value;
            }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            string idAcceptForm = (cbAcceptCommit.SelectedItem as AcceptCommit).MaHDNT;
            if (TopicDAO.Instance.UpdateAcceptCommitOfTopic(idTopic, idAcceptForm))
            {
                MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeForm(this, new EventArgs());
                Close();
            }
        }
    }
}
