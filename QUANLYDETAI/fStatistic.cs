using QUANLYDETAI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QUANLYDETAI
{
    public partial class fStatistic : Form
    {
        private string userName;
        private string role;
        BindingSource source = new BindingSource();
        public fStatistic(string userName, string role)
        {
            this.userName = userName;
            this.role = role;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            LoadFullData();
            DrawChart();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tslExport_Click(object sender, EventArgs e)
        {
            if (cbSelection.SelectedIndex == 0)
            {
                saveFile.FileName = "Thống kê theo kết quả đề tài năm "+ numYear.Value.ToString();
            }
            else if (cbSelection.SelectedIndex == 1)
            {
                saveFile.FileName = "Thống kê theo khoa đề tài năm " + numYear.Value.ToString();
            }
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                bool check;
                try
                {
                    switch (saveFile.FilterIndex)
                    {
                        case 2:
                            check = ExportToExcel.Instance.Export(dgvResult, saveFile.FileName, ModeExportToExcel.XLSX);
                            break;
                        case 3:
                            check = ExportToExcel.Instance.Export(dgvResult, saveFile.FileName, ModeExportToExcel.PDF);
                            break;
                        default:
                            check = ExportToExcel.Instance.Export(dgvResult, saveFile.FileName, ModeExportToExcel.XLS);
                            break;
                    }
                    if (check)
                        MessageBox.Show("Xuất thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi xuất thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Lỗi (Cần cài đặt Office)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadFullData()
        {
            dgvResult.DataSource = source;
            bindingReport.BindingSource = source;
            source.DataSource = TopicDAO.Instance.getStatisticByResult(numYear.Value.ToString());
            cbSelection.SelectedIndex = 0;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (cbSelection.SelectedIndex == 0)
            {
                source.DataSource = TopicDAO.Instance.getStatisticByResult(numYear.Value.ToString());
            }
            else if (cbSelection.SelectedIndex == 1)
            {
                source.DataSource = TopicDAO.Instance.getStatisticByDepartment(numYear.Value.ToString());
            }
            else if (cbSelection.SelectedIndex == 2)
            {
                source.DataSource = TopicDAO.Instance.getStatisticBySubject(numYear.Value.ToString());
            }
            else if (cbSelection.SelectedIndex == 3)
            {
                source.DataSource = TopicDAO.Instance.getStatisticByLevel(numYear.Value.ToString());
            }
            else if (cbSelection.SelectedIndex == 4)
            {
                source.DataSource = TopicDAO.Instance.getStatisticByStatus(numYear.Value.ToString());
            }
            DrawChart();
        }
        private void DrawChart()
        {
            chartReport.DataSource = source;
            chartReport.DataBind();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            string detail = dgvResult.Rows[dgvResult.CurrentRow.Index].Cells[0].Value.ToString();
            if (cbSelection.SelectedIndex == 4)
            {
                fTopic f = new fTopic(userName, role, detail, "StatisticByStatic", numYear.Value.ToString());
                f.ShowDialog();
            }
        }
    }
}
