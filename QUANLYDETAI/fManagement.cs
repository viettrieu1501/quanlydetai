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
    public partial class fManagement : Form
    {
        private string userName;
        private string role;
        public fManagement(string userName)
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            guna2DragControl1.SetDrag(panel1);
            lbNameApp.Text = lbNameApp.Text+" - " + userName;
            this.userName = userName;
            this.role = TypeAccountDAO.Instance.GetTypeAccountByID(AccountDAO.Instance.getAccountbyUserName(userName).MaType).Name;
            HideSubMenu();
            LoadFullData();
        }
        private void LoadFullData()
        {
            dgvNN.DataSource = TopicDAO.Instance.getListTopicNN();
            chart.DataSource = TopicDAO.Instance.getStatisticByLevel("2021");
        }
        private void HideSubMenu()
        {
            MenuManager.Visible = false;
            MenuSettings.Visible = false;
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (role=="p6"||role=="admin")
            {
                this.Hide();
                fAddTopic f = new fAddTopic(userName, role);
                f.CloseForm += F_CloseForm;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fStatistic f = new fStatistic(userName, role);
            f.ShowDialog();
            Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            if (MenuManager.Visible == true)
            {
                MenuManager.Visible = false;
            }
            else
                MenuManager.Visible = true;
        }

        private void btnStaffManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            fStaff f = new fStaff(userName, role);
            f.ShowDialog();
            Show();
        }

        private void btnOrganManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDepartment f = new fDepartment(userName, role);
            f.ShowDialog();
            Show();
        }

        private void btnSpecMana_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSubject f = new fSubject(userName, role);
            f.ShowDialog();
            Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (MenuSettings.Visible == true)
            {
                MenuSettings.Visible = false;
            }
            else
                MenuSettings.Visible = true;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChangePass f = new fChangePass(userName);
            f.ShowDialog();
            Show();
        }


        private event EventHandler logOut;
        public event EventHandler LogOut
        {
            add { logOut += value; }
            remove { logOut -= value; }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (logOut != null)
            {
                logOut(this, new EventArgs());
            }
            Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fProfile f = new fProfile(userName, role);
            f.ShowDialog();
            Show();
        }

        private void btnClosedWin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnNavigationPanel_Click(object sender, EventArgs e)
        {
            if (pMenu.Width == 49)
            {
                pMenu.Width = 174;
                this.Width = 1014;
            }
            else
            {
                pMenu.Width = 49;
                this.Width = 889;
            }
            HideSubMenu();
        }

        private void F_CloseForm(object sender, EventArgs e)
        {
            chart.DataSource = TopicDAO.Instance.getStatisticByLevel("2021");
        }

        private void tileTopic_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTopic f = new fTopic(userName, role);
            f.ShowDialog();
            this.Show();
        }


        private void btnIntroduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAbout f = new fAbout();
            f.ShowDialog();
            this.Show();
        }

        private void btnAccountMana_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAccount f = new fAccount(role);
            f.ShowDialog();
            this.Show();
        }

        private void F_Logout(object sender, EventArgs e)
        {
            Close();
        }
    }
}
