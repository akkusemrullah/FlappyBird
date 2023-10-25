
namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.engelAlt = new System.Windows.Forms.PictureBox();
            this.engelUst = new System.Windows.Forms.PictureBox();
            this.engelAlt1 = new System.Windows.Forms.PictureBox();
            this.karakter = new System.Windows.Forms.PictureBox();
            this.timerOyun = new System.Windows.Forms.Timer(this.components);
            this.timerZipla = new System.Windows.Forms.Timer(this.components);
            this.engelUst1 = new System.Windows.Forms.PictureBox();
            this.gameOverImage = new System.Windows.Forms.PictureBox();
            this.startImage = new System.Windows.Forms.PictureBox();
            this.startButonImage = new System.Windows.Forms.PictureBox();
            this.puan = new System.Windows.Forms.PictureBox();
            this.puan1 = new System.Windows.Forms.PictureBox();
            this.timerPuan = new System.Windows.Forms.Timer(this.components);
            this.puanRe1 = new System.Windows.Forms.PictureBox();
            this.puanRe = new System.Windows.Forms.PictureBox();
            this.yol1 = new System.Windows.Forms.PictureBox();
            this.ustEngel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelAlt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelUst1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puanRe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puanRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustEngel)).BeginInit();
            this.SuspendLayout();
            // 
            // yol
            // 
            this.yol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yol.BackgroundImage")));
            this.yol.Location = new System.Drawing.Point(0, 610);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(874, 112);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // engelAlt
            // 
            this.engelAlt.BackColor = System.Drawing.Color.Transparent;
            this.engelAlt.Image = ((System.Drawing.Image)(resources.GetObject("engelAlt.Image")));
            this.engelAlt.Location = new System.Drawing.Point(308, 300);
            this.engelAlt.Name = "engelAlt";
            this.engelAlt.Size = new System.Drawing.Size(52, 320);
            this.engelAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.engelAlt.TabIndex = 2;
            this.engelAlt.TabStop = false;
            // 
            // engelUst
            // 
            this.engelUst.BackColor = System.Drawing.Color.Transparent;
            this.engelUst.Image = ((System.Drawing.Image)(resources.GetObject("engelUst.Image")));
            this.engelUst.Location = new System.Drawing.Point(308, -171);
            this.engelUst.Name = "engelUst";
            this.engelUst.Size = new System.Drawing.Size(52, 320);
            this.engelUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.engelUst.TabIndex = 3;
            this.engelUst.TabStop = false;
            // 
            // engelAlt1
            // 
            this.engelAlt1.BackColor = System.Drawing.Color.Transparent;
            this.engelAlt1.Image = ((System.Drawing.Image)(resources.GetObject("engelAlt1.Image")));
            this.engelAlt1.Location = new System.Drawing.Point(584, 456);
            this.engelAlt1.Name = "engelAlt1";
            this.engelAlt1.Size = new System.Drawing.Size(52, 320);
            this.engelAlt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.engelAlt1.TabIndex = 4;
            this.engelAlt1.TabStop = false;
            // 
            // karakter
            // 
            this.karakter.BackColor = System.Drawing.Color.Transparent;
            this.karakter.Image = ((System.Drawing.Image)(resources.GetObject("karakter.Image")));
            this.karakter.Location = new System.Drawing.Point(106, 117);
            this.karakter.Name = "karakter";
            this.karakter.Size = new System.Drawing.Size(45, 45);
            this.karakter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.karakter.TabIndex = 5;
            this.karakter.TabStop = false;
            // 
            // timerOyun
            // 
            this.timerOyun.Interval = 1;
            this.timerOyun.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerZipla
            // 
            this.timerZipla.Interval = 1;
            this.timerZipla.Tick += new System.EventHandler(this.timerZipla_Tick);
            // 
            // engelUst1
            // 
            this.engelUst1.BackColor = System.Drawing.Color.Transparent;
            this.engelUst1.Image = ((System.Drawing.Image)(resources.GetObject("engelUst1.Image")));
            this.engelUst1.Location = new System.Drawing.Point(584, -15);
            this.engelUst1.Name = "engelUst1";
            this.engelUst1.Size = new System.Drawing.Size(52, 320);
            this.engelUst1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.engelUst1.TabIndex = 7;
            this.engelUst1.TabStop = false;
            // 
            // gameOverImage
            // 
            this.gameOverImage.BackColor = System.Drawing.Color.Transparent;
            this.gameOverImage.Image = ((System.Drawing.Image)(resources.GetObject("gameOverImage.Image")));
            this.gameOverImage.Location = new System.Drawing.Point(111, 398);
            this.gameOverImage.Name = "gameOverImage";
            this.gameOverImage.Size = new System.Drawing.Size(192, 42);
            this.gameOverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameOverImage.TabIndex = 8;
            this.gameOverImage.TabStop = false;
            this.gameOverImage.Visible = false;
            // 
            // startImage
            // 
            this.startImage.BackColor = System.Drawing.Color.Transparent;
            this.startImage.Image = ((System.Drawing.Image)(resources.GetObject("startImage.Image")));
            this.startImage.Location = new System.Drawing.Point(115, 187);
            this.startImage.Name = "startImage";
            this.startImage.Size = new System.Drawing.Size(184, 163);
            this.startImage.TabIndex = 9;
            this.startImage.TabStop = false;
            this.startImage.Click += new System.EventHandler(this.startImage_Click);
            // 
            // startButonImage
            // 
            this.startButonImage.BackColor = System.Drawing.Color.Transparent;
            this.startButonImage.Image = ((System.Drawing.Image)(resources.GetObject("startButonImage.Image")));
            this.startButonImage.Location = new System.Drawing.Point(171, 449);
            this.startButonImage.Name = "startButonImage";
            this.startButonImage.Size = new System.Drawing.Size(72, 42);
            this.startButonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startButonImage.TabIndex = 10;
            this.startButonImage.TabStop = false;
            this.startButonImage.Visible = false;
            this.startButonImage.Click += new System.EventHandler(this.startButonImage_Click);
            // 
            // puan
            // 
            this.puan.BackColor = System.Drawing.Color.Transparent;
            this.puan.Location = new System.Drawing.Point(327, -7);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(11, 612);
            this.puan.TabIndex = 11;
            this.puan.TabStop = false;
            // 
            // puan1
            // 
            this.puan1.BackColor = System.Drawing.Color.Transparent;
            this.puan1.Location = new System.Drawing.Point(606, -26);
            this.puan1.Name = "puan1";
            this.puan1.Size = new System.Drawing.Size(10, 631);
            this.puan1.TabIndex = 12;
            this.puan1.TabStop = false;
            // 
            // timerPuan
            // 
            this.timerPuan.Enabled = true;
            this.timerPuan.Interval = 10;
            this.timerPuan.Tick += new System.EventHandler(this.timerPuan_Tick);
            // 
            // puanRe1
            // 
            this.puanRe1.BackColor = System.Drawing.Color.Transparent;
            this.puanRe1.Location = new System.Drawing.Point(694, -14);
            this.puanRe1.Name = "puanRe1";
            this.puanRe1.Size = new System.Drawing.Size(10, 631);
            this.puanRe1.TabIndex = 14;
            this.puanRe1.TabStop = false;
            // 
            // puanRe
            // 
            this.puanRe.BackColor = System.Drawing.Color.Transparent;
            this.puanRe.Location = new System.Drawing.Point(415, 5);
            this.puanRe.Name = "puanRe";
            this.puanRe.Size = new System.Drawing.Size(11, 612);
            this.puanRe.TabIndex = 13;
            this.puanRe.TabStop = false;
            // 
            // yol1
            // 
            this.yol1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yol1.BackgroundImage")));
            this.yol1.Location = new System.Drawing.Point(864, 610);
            this.yol1.Name = "yol1";
            this.yol1.Size = new System.Drawing.Size(874, 112);
            this.yol1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol1.TabIndex = 15;
            this.yol1.TabStop = false;
            // 
            // ustEngel
            // 
            this.ustEngel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ustEngel.BackgroundImage")));
            this.ustEngel.Location = new System.Drawing.Point(-200, -134);
            this.ustEngel.Name = "ustEngel";
            this.ustEngel.Size = new System.Drawing.Size(874, 112);
            this.ustEngel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustEngel.TabIndex = 16;
            this.ustEngel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 721);
            this.Controls.Add(this.ustEngel);
            this.Controls.Add(this.yol1);
            this.Controls.Add(this.startButonImage);
            this.Controls.Add(this.gameOverImage);
            this.Controls.Add(this.startImage);
            this.Controls.Add(this.engelUst1);
            this.Controls.Add(this.yol);
            this.Controls.Add(this.engelAlt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.engelAlt);
            this.Controls.Add(this.engelUst);
            this.Controls.Add(this.karakter);
            this.Controls.Add(this.puanRe1);
            this.Controls.Add(this.puanRe);
            this.Controls.Add(this.puan1);
            this.Controls.Add(this.puan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelAlt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engelUst1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puanRe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puanRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustEngel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox engelAlt;
        private System.Windows.Forms.PictureBox engelUst;
        private System.Windows.Forms.PictureBox engelAlt1;
        private System.Windows.Forms.PictureBox karakter;
        private System.Windows.Forms.Timer timerOyun;
        private System.Windows.Forms.Timer timerZipla;
        private System.Windows.Forms.PictureBox engelUst1;
        private System.Windows.Forms.PictureBox gameOverImage;
        private System.Windows.Forms.PictureBox startImage;
        private System.Windows.Forms.PictureBox startButonImage;
        private System.Windows.Forms.PictureBox puan;
        private System.Windows.Forms.PictureBox puan1;
        private System.Windows.Forms.Timer timerPuan;
        private System.Windows.Forms.PictureBox puanRe1;
        private System.Windows.Forms.PictureBox puanRe;
        private System.Windows.Forms.PictureBox yol1;
        private System.Windows.Forms.PictureBox ustEngel;
    }
}

