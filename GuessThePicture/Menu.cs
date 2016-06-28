using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessThePicture
{
    public partial class Menu : Form
    {
        int nyawa = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            KelasMain main = new KelasMain();
            main.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure to exit ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure to exit ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            Menuhelp mh = new Menuhelp();
            mh.Show();
            this.Hide();
        }
    }
}
