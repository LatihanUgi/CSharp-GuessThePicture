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
    public partial class Menuhelp : Form
    {
        public Menuhelp()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.ForeColor = Color.Cyan;
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure to exit ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
