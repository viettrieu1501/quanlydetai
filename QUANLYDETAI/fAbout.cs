using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYDETAI
{
    public partial class fAbout : Form
    {
        public fAbout()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
