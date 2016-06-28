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
    public partial class utama : Form
    {
        public utama()
        {
            InitializeComponent();
        }

        private void utama_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void mulai_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
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
    }
}
