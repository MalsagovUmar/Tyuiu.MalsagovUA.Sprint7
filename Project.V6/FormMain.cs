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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonWorkerFormMain_MUA_Click(object sender, EventArgs e)
        {
            FormWorker formWorker = new FormWorker();
            this.Hide();
            formWorker.ShowDialog();
        }

        private void ToolStripMenuItemAbout_MUA_Click(object sender, EventArgs e)
        {
            FormAbout_MUA formAbout = new FormAbout_MUA();
            formAbout.Show();
        }

        private void buttonClientFormMain_MUA_Click(object sender, EventArgs e)
        {
            FormClients_MUA formClients = new FormClients_MUA();
            this.Hide();
            formClients.Show();
        }
    }
}
