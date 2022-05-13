using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYDETAI.DTO;
using QUANLYDETAI.DAO;

namespace QUANLYDETAI
{
    public partial class fDetailReportProgress : Form
    {
        private string idTopic;
        BindingSource source = new BindingSource();
        public fDetailReportProgress(string idTopic)
        {
            this.idTopic = idTopic;
            InitializeComponent();
            LoadFullData();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadFullData()
        {
            dgvReportProgress.DataSource = source;
            source.DataSource = ReportProgressDAO.Instance.getFullReportByid(idTopic);

            txtIDBCTD.DataBindings.Add(new Binding("Text", source, "mabctd", true, DataSourceUpdateMode.Never));
            txtContent.DataBindings.Add(new Binding("Text", source, "nd", true, DataSourceUpdateMode.Never));
            dpkReport.DataBindings.Add(new Binding("Value", source, "ngaybc", true, DataSourceUpdateMode.Never));
            txtComplete.DataBindings.Add(new Binding("Text", source, "HT(%)", true, DataSourceUpdateMode.Never));
            txtNextPlan.DataBindings.Add(new Binding("Text", source, "kh_tt", true, DataSourceUpdateMode.Never));
            txtAblityComplete.DataBindings.Add(new Binding("Text", source, "knht", true, DataSourceUpdateMode.Never));
            txtNumReport.DataBindings.Add(new Binding("Text", source, "lan_bc", true, DataSourceUpdateMode.Never));
        }
    }
}
