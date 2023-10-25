using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SoundPlayer player = new SoundPlayer();
        int gameSpeed = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            timerOyun.Enabled = true;
        }
        int konumY = 175;
        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            karakter.Top += 4;
            konumY = karakter.Top;

            engelAlt.Left -= gameSpeed;
            engelAlt1.Left -= gameSpeed;
            engelUst.Left -= gameSpeed;
            engelUst1.Left -= gameSpeed;
            puan.Left -= gameSpeed;
            puan1.Left -= gameSpeed;
            puanRe.Left -= gameSpeed;
            puanRe1.Left -= gameSpeed;
            yol.Left -= gameSpeed;
            yol1.Left -= gameSpeed;
            if (yol.Left <= -872)
            {
                yol.Left = 855;
            }
            if (yol1.Left <= -872)
            {
                yol1.Left = 855;
            }
            if (engelAlt.Left <= -55)
            {
                engelAlt.Left = 618;
                puan.Left = 618;
                puanRe.Left = 706;
                engelAlt.Top = random(300, 465);

                engelUst.Left = 618;
                engelUst.Top = random(-171, -15);
            }
            if (engelAlt1.Left <= -55)
            {
                engelAlt1.Left = 618;
                puan1.Left = 618;
                puanRe1.Left = 706;
                engelAlt1.Top = random(300, 465);

                engelUst1.Left = 618;
                engelUst1.Top = random(-171, -15);
            }

            if (karakter.Bounds.IntersectsWith(puanRe.Bounds) || karakter.Bounds.IntersectsWith(puanRe1.Bounds))
            {

                timerPuan.Enabled = true;
            }
            if (karakter.Bounds.IntersectsWith(ustEngel.Bounds) || karakter.Bounds.IntersectsWith(yol.Bounds) || karakter.Bounds.IntersectsWith(yol1.Bounds) || karakter.Bounds.IntersectsWith(engelAlt.Bounds) || karakter.Bounds.IntersectsWith(engelAlt1.Bounds) || karakter.Bounds.IntersectsWith(engelUst.Bounds) || karakter.Bounds.IntersectsWith(engelUst.Bounds))
            {

                timerOyun.Enabled = false;
                gameOverImage.Visible = true;
                startButonImage.Visible = true;
                deadSound();
            }

        }

        int random(int altLimit, int ustLimit)
        {
            
            Random rnd = new Random();
            int rand = rnd.Next(altLimit, ustLimit);
            return rand;
        }
        void zipla()
        {
            timerZipla.Enabled = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timerOyun.Enabled)
            {
                if (e.KeyCode == Keys.Space)
                {
                    zipla();
                }
            }
        }
        int ziplama = 7;
        private void timerZipla_Tick(object sender, EventArgs e)
        {

            ziplama--;
            if (ziplama > 0)
            {
                karakter.Top -= 16;
            }
            else
            {
                ziplama = 7;
                timerZipla.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timerOyun.Enabled = true;
        }

        private void startImage_Click(object sender, EventArgs e)
        {
            timerOyun.Enabled = true;
            startImage.Visible = false;
        }


        private void startButonImage_Click(object sender, EventArgs e)
        {
            score = 0;
            label1.Text = "0";
            karakter.Location = new Point(173, 112);
            engelUst.Location = new Point(308, -171);
            engelUst1.Location = new Point(584, -15);
            engelAlt.Location = new Point(308, 300);
            engelAlt1.Location = new Point(584, 456);
            puan.Location = new Point(327, -7);
            puan1.Location =   new Point(606, -26);
            puanRe.Location =  new Point(415, 5);
            puanRe1.Location = new Point(694, -14);
            timerOyun.Enabled = true;
            startImage.Visible = false;
            startButonImage.Visible = false;
            gameOverImage.Visible = false;
        }

        void coinSound()
        {
            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\res\\coin.wav";

                player.Play();
            }
            catch 
            {
             
            }
        }

        void deadSound()
        {
            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\res\\dead.wav";

                player.Play();
            }
            catch
            {
              
            }
        }
        private void timerPuan_Tick(object sender, EventArgs e)
        {
            if (karakter.Bounds.IntersectsWith(puan.Bounds) || karakter.Bounds.IntersectsWith(puan1.Bounds))
            {

                timerPuan.Enabled = false;
                score++;
                label1.Text = score.ToString();
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
            if (timerOyun.Enabled)
                coinSound();
        }
    }
}
