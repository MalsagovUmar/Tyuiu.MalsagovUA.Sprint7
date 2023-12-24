using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V6
{
    public partial class FormWorker : Form
    {
        public FormWorker()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemAbout_MUA_Click(object sender, EventArgs e)
        {
            FormAbout_MUA formAbout = new FormAbout_MUA();
            formAbout.Show();
        }
    }
}
