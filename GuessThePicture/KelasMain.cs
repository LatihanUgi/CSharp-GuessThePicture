using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GuessThePicture
{
    public partial class KelasMain : Form
    {
        int x = 0;

        public KelasMain()
        {
            InitializeComponent();
        }

        private void gembok7_Click(object sender, EventArgs e)
        {

        }

        private void keluar_Click(object sender, EventArgs e)
        {
            updatenyawabalik(); 
            var msg = MessageBox.Show("Are you sure to exit ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            updatenyawabalik(); 
            Menu back = new Menu();
            back.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            updatenyawabalik(); 
            var msg = MessageBox.Show("Are you sure to exit ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void level1_Click(object sender, EventArgs e)
        {
            Main main = new Main(x);
            main.Show();
            this.Hide();
        }

        private void SetImage()
        {
            string gambar = File.ReadAllLines("pertanyaan.txt").Skip(x).Take(x + 1).First();
            char[] delim = { '#' };
            string[] picture = gambar.Split(delim);
            Image img = Image.FromFile(picture[0]);
        }

        private void level2_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "2")
                {
                    x = x + 1;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 1;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level3_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "3")
                {
                    x = x + 2;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 2;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level4_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "4")
                {
                    x = x + 3;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 3;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level5_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "5")
                {
                    x = x + 4;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 4;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level6_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "6")
                {
                    x = x + 5;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x +5;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void gembok6_Click(object sender, EventArgs e)
        {

        }

        private void level7_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "7")
                {
                    x = x + 6;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 6;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level8_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "8")
                {
                    x = x + 7;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 7;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level9_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "9")
                {
                    x = x + 8;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 8;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level10_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "10")
                {
                    x = x + 9;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 9;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level11_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "11")
                {
                    x = x + 10;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 10;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level12_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "12")
                {
                    x = x + 11;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 11;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void gembok12_Click(object sender, EventArgs e)
        {

        }

        private void level13_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "13")
                {
                    x = x + 12;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 12;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level14_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "14")
                {
                    x = x + 13;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 13;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void level15_Click(object sender, EventArgs e)
        {
            SetImage();
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line == "15")
                {
                    x = x + 14;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                else
                {
                    x = x + 14;
                    SetImage();
                    Main level2 = new Main(x);
                    level2.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void KelasMain_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (Convert.ToInt16(line) == 2)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                }
                if (Convert.ToInt16(line) == 3)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                }
                if (Convert.ToInt16(line) == 4)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                }
                if (Convert.ToInt16(line) == 5)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                }
                if (Convert.ToInt16(line) == 6)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                }
                if (Convert.ToInt16(line) == 7)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                }
                if (Convert.ToInt16(line) == 8)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                    gembok7.Visible = false;
                }
                if (Convert.ToInt16(line) == 9)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                    gembok7.Visible = false;
                    gembok8.Visible = false;
                }
                if (Convert.ToInt16(line) == 10)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                    gembok7.Visible = false;
                    gembok8.Visible = false;
                    gembok9.Visible = false;
                }
                if (Convert.ToInt16(line) == 11)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                    gembok7.Visible = false;
                    gembok8.Visible = false;
                    gembok9.Visible = false;
                    gembok10.Visible = false;
                }
                if (Convert.ToInt16(line) == 12)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                    gembok7.Visible = false;
                    gembok8.Visible = false;
                    gembok9.Visible = false;
                    gembok10.Visible = false;
                    gembok11.Visible = false;
                }
                if (Convert.ToInt16(line) == 13)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                    gembok7.Visible = false;
                    gembok8.Visible = false;
                    gembok9.Visible = false;
                    gembok10.Visible = false;
                    gembok11.Visible = false;
                    gembok12.Visible = false;
                }
                if (Convert.ToInt16(line) == 14)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                    gembok7.Visible = false;
                    gembok8.Visible = false;
                    gembok9.Visible = false;
                    gembok10.Visible = false;
                    gembok11.Visible = false;
                    gembok12.Visible = false;
                    gembok13.Visible = false;
                }
                if (Convert.ToInt16(line) == 15)
                {
                    back.Enabled = false;
                    gembok1.Visible = false;
                    gembok2.Visible = false;
                    gembok3.Visible = false;
                    gembok4.Visible = false;
                    gembok5.Visible = false;
                    gembok6.Visible = false;
                    gembok7.Visible = false;
                    gembok8.Visible = false;
                    gembok9.Visible = false;
                    gembok10.Visible = false;
                    gembok11.Visible = false;
                    gembok12.Visible = false;
                    gembok13.Visible = false;
                    gembok14.Visible = false;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        public void updatenyawabalik()
        {
            FileStream fs = new FileStream("xxx.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            int nyawa = 0;
            while (line != null)
            {
                nyawa = 3;
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            int databaru = nyawa;
            updatedatanyawabalik(databaru);
        }
        public void updatedatanyawabalik(int databaru)
        {
            FileStream fs = new FileStream("tempnyawa.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(databaru);
            sw.Flush();
            sw.Close();
            fs.Close();

            File.Copy("tempnyawa.txt", "xxx.txt", true); //bisa overwrite = dapat mereplace isi yang ada di txt
            File.Delete("tempnyawa.txt");
        }
    }
}
