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
    public partial class FormClients_MUA : Form
    {
        public FormClients_MUA()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemAbout_MUA_Click(object sender, EventArgs e)
        {
            FormAbout_MUA formAbout = new FormAbout_MUA();
            formAbout.Show();
        }

        private void buttonDoneFormClients_MUA_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void comboBoxChooseWorkers_MUA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxChooseWorkers_MUA.SelectedItem == "Хирург")
            {
                MessageBox.Show("ХИРУРГ");
            }
            else if (comboBoxChooseWorkers_MUA.SelectedItem == "Дантист")
            {
                MessageBox.Show("ДАНТИСТ");
            }
            else if (comboBoxChooseWorkers_MUA.SelectedItem == "Вирусолог")
            {
                MessageBox.Show("ВИРУСОЛОГ");
            }
        }
    }
}
