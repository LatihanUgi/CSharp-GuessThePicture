using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace GuessThePicture
{
    public partial class Main : Form
    {
        int x = 0;
        int ceknyawa = 0;

        public Main(int pars)
        {
            InitializeComponent();
            this.x = pars;
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure to exit ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void back_Click(object sender, EventArgs e)
        {
            updatenyawa();
            KelasMain main = new KelasMain();
            main.Show();
            this.Hide();
        }

        private void SetImage()
        {
            string gambar = File.ReadAllLines("pertanyaan.txt").Skip(x).Take(x + 1).First();
            char[] delim = { '#' };
            string[] picture = gambar.Split(delim);
            Image img = Image.FromFile(picture[0]);
            pictureBox1.Image = img;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnjwb.Enabled = false;
            btnhps.Enabled = false;
            int jml = File.ReadAllLines("pertanyaan.txt").Count();
            FileStream fs = new FileStream("xxx.txt", FileMode.Open, FileAccess.Read); //file lives
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            ceknyawa = Convert.ToInt16(line);
            sr.Close();
            fs.Close();
            if (ceknyawa == 3)
            {
            }
            if (ceknyawa == 2)
            {
                live3.Visible = false;
            }
            if (ceknyawa == 1)
            {
                live3.Visible = false;
                live2.Visible = false;
            }

            SetImage();
        }

        public void updatenyawa()
        {
            FileStream fs = new FileStream("xxx.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            int nyawa = 0;
            while (line != null)
            {
                nyawa = ceknyawa;
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            int databaru = nyawa;
            updatedatanyawa(databaru);
        }
        public void updatedatanyawa(int databaru)
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

        private void btnjwb_Click(object sender, EventArgs e)
        {
            int jml = File.ReadAllLines("pertanyaan.txt").Count();
            string gambar = File.ReadAllLines("pertanyaan.txt").Skip(x).Take(x + 1).First();
            char[] delim = { '#' };
            string[] picture = gambar.Split(delim);
            string jawaban = jwb.Text;
            bool statusjawaban = cekJawaban(jawaban, picture); //cek apakah jawaban benar atau salah
            if (statusjawaban == true)
            {
                FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                int cek = Convert.ToInt16(line);
                while (line != null)
                {
                    line = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                if (x != jml - 1)
                {
                    MessageBox.Show("Your answer is correct");
                    if ((cek - 1) == x)
                    {
                        update();
                        x++;
                        SetImage();
                        KelasMain level = new KelasMain();
                        level.Show();
                        this.Close();
                    }
                    else 
                    {
                        KelasMain level = new KelasMain();
                        level.Show();
                        this.Close();
                    }
                    
                }
                else if (x == jml - 1)
                {
                    MessageBox.Show("Congratulation you won!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var msg = MessageBox.Show("You wanna try this again", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        updatebalik();
                        Menu menu = new Menu();
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        updatebalik();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Your Answer is correct");
                    KelasMain level = new KelasMain();
                    level.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Your answer is incorrect");
                jwb.Text = "";
                btnhps.Enabled = false;
                ceknyawa--; // cek nyawa 
                if (ceknyawa == 3)
                {
                }
                if (ceknyawa == 2)
                {
                    updatenyawa();
                    live3.Visible = false;
                }
                if (ceknyawa == 1)
                {
                    updatenyawa();
                    live3.Visible = false;
                    live2.Visible = false;
                }
                if (ceknyawa == 0)
                {
                    updatenyawabalik();
                    live3.Visible = false;
                    live2.Visible = false;
                    live1.Visible = false;
                    MessageBox.Show("Your live exhausted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var ulang = MessageBox.Show("You wanna try this game again ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ulang == DialogResult.Yes)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        public void updatebalik()
        {
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            int level = 0;
            while (line != null)
            {
                level = Convert.ToInt16(line) - Convert.ToInt16(line) + 1;
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            int databaru = level;
            updatedatabalik(databaru);
        }

        public void updatedatabalik(int databaru)
        {
            FileStream fs = new FileStream("temp.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(databaru);
            sw.Flush();
            sw.Close();
            fs.Close();

            File.Copy("temp.txt", "level.txt", true); //bisa overwrite = dapat mereplace isi yang ada di txt
            File.Delete("temp.txt");
        }

        public void update()
        {
            FileStream fs = new FileStream("level.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            int level = 0;
            while (line != null)
            {
                level = 1 + Convert.ToInt16(line);
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            int databaru = level;
            updatedata(databaru);
        }

        public void updatedata(int databaru)
        {
            FileStream fs = new FileStream("temp.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(databaru);

            sw.Flush();
            sw.Close();
            fs.Close();

            File.Copy("temp.txt", "level.txt", true); //bisa overwrite = dapat mereplace isi yang ada di txt
            File.Delete("temp.txt");
        }

        public bool cekJawaban(string jawaban, string[] picture)
        {
            bool status = false;
            if (jawaban == picture[1])
            {
                status = true;
                return status;
            }
            else
            {
                return status;
            }
        }

        private void btnhps_Click(object sender, EventArgs e)
        {
            jwb.Text = "";
            btnhps.Enabled = false;
            btnjwb.Enabled = false;
        }

        private void jwb_TextChanged(object sender, EventArgs e)
        {
            btnhps.Enabled = true;
            btnjwb.Enabled = true;
            if (jwb.Text == "")
            {
                btnjwb.Enabled = false;
                btnhps.Enabled = false;
            }
            else
            {
                btnjwb.Enabled = true;
                btnhps.Enabled = true;
            }
        }
    }
}
