namespace Probaaa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.a = new System.Windows.Forms.PictureBox();
            this.kec = new System.Windows.Forms.PictureBox();
            this.dvojka = new System.Windows.Forms.PictureBox();
            this.dvojka1 = new System.Windows.Forms.PictureBox();
            this.kec1 = new System.Windows.Forms.PictureBox();
            this.Broj = new System.Windows.Forms.Label();
            this.Poeni = new System.Windows.Forms.Label();
            this.rocket1 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.rocket2 = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.koin = new System.Windows.Forms.PictureBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.coin = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvojka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvojka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koin)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // a
            // 
            this.a.Image = ((System.Drawing.Image)(resources.GetObject("a.Image")));
            this.a.Location = new System.Drawing.Point(124, 137);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(41, 40);
            this.a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a.TabIndex = 0;
            this.a.TabStop = false;
            // 
            // kec
            // 
            this.kec.Image = ((System.Drawing.Image)(resources.GetObject("kec.Image")));
            this.kec.Location = new System.Drawing.Point(900, 0);
            this.kec.Name = "kec";
            this.kec.Size = new System.Drawing.Size(45, 190);
            this.kec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kec.TabIndex = 1;
            this.kec.TabStop = false;
            // 
            // dvojka
            // 
            this.dvojka.Image = ((System.Drawing.Image)(resources.GetObject("dvojka.Image")));
            this.dvojka.Location = new System.Drawing.Point(900, 290);
            this.dvojka.Name = "dvojka";
            this.dvojka.Size = new System.Drawing.Size(45, 72);
            this.dvojka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dvojka.TabIndex = 2;
            this.dvojka.TabStop = false;
            // 
            // dvojka1
            // 
            this.dvojka1.Image = ((System.Drawing.Image)(resources.GetObject("dvojka1.Image")));
            this.dvojka1.Location = new System.Drawing.Point(450, 225);
            this.dvojka1.Name = "dvojka1";
            this.dvojka1.Size = new System.Drawing.Size(45, 137);
            this.dvojka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dvojka1.TabIndex = 4;
            this.dvojka1.TabStop = false;
            // 
            // kec1
            // 
            this.kec1.Image = ((System.Drawing.Image)(resources.GetObject("kec1.Image")));
            this.kec1.Location = new System.Drawing.Point(450, 0);
            this.kec1.Name = "kec1";
            this.kec1.Size = new System.Drawing.Size(45, 125);
            this.kec1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kec1.TabIndex = 3;
            this.kec1.TabStop = false;
            // 
            // Broj
            // 
            this.Broj.AutoSize = true;
            this.Broj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Broj.ForeColor = System.Drawing.Color.White;
            this.Broj.Location = new System.Drawing.Point(731, 9);
            this.Broj.Name = "Broj";
            this.Broj.Size = new System.Drawing.Size(163, 25);
            this.Broj.TabIndex = 5;
            this.Broj.Text = "BROJ POENA: ";
            // 
            // Poeni
            // 
            this.Poeni.AutoSize = true;
            this.Poeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poeni.ForeColor = System.Drawing.Color.White;
            this.Poeni.Location = new System.Drawing.Point(883, 9);
            this.Poeni.Name = "Poeni";
            this.Poeni.Size = new System.Drawing.Size(24, 25);
            this.Poeni.TabIndex = 6;
            this.Poeni.Text = "0";
            // 
            // rocket1
            // 
            this.rocket1.Image = ((System.Drawing.Image)(resources.GetObject("rocket1.Image")));
            this.rocket1.Location = new System.Drawing.Point(862, 104);
            this.rocket1.Name = "rocket1";
            this.rocket1.Size = new System.Drawing.Size(105, 50);
            this.rocket1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket1.TabIndex = 7;
            this.rocket1.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // rocket2
            // 
            this.rocket2.Image = ((System.Drawing.Image)(resources.GetObject("rocket2.Image")));
            this.rocket2.Location = new System.Drawing.Point(862, 225);
            this.rocket2.Name = "rocket2";
            this.rocket2.Size = new System.Drawing.Size(105, 50);
            this.rocket2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket2.TabIndex = 8;
            this.rocket2.TabStop = false;
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // koin
            // 
            this.koin.Image = ((System.Drawing.Image)(resources.GetObject("koin.Image")));
            this.koin.Location = new System.Drawing.Point(704, 90);
            this.koin.Name = "koin";
            this.koin.Size = new System.Drawing.Size(40, 40);
            this.koin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.koin.TabIndex = 9;
            this.koin.TabStop = false;
            // 
            // timer5
            // 
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // coin
            // 
            this.coin.AutoSize = true;
            this.coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coin.ForeColor = System.Drawing.Color.Yellow;
            this.coin.Location = new System.Drawing.Point(110, 9);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(24, 25);
            this.coin.TabIndex = 11;
            this.coin.Text = "0";
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coins.ForeColor = System.Drawing.Color.Yellow;
            this.coins.Location = new System.Drawing.Point(12, 9);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(104, 25);
            this.coins.TabIndex = 10;
            this.coins.Text = "ŽETONI: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 362);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.koin);
            this.Controls.Add(this.rocket2);
            this.Controls.Add(this.rocket1);
            this.Controls.Add(this.Poeni);
            this.Controls.Add(this.Broj);
            this.Controls.Add(this.dvojka1);
            this.Controls.Add(this.kec1);
            this.Controls.Add(this.dvojka);
            this.Controls.Add(this.kec);
            this.Controls.Add(this.a);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flafi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvojka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvojka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox a;
        private System.Windows.Forms.PictureBox kec;
        private System.Windows.Forms.PictureBox dvojka;
        private System.Windows.Forms.PictureBox dvojka1;
        private System.Windows.Forms.PictureBox kec1;
        private System.Windows.Forms.Label Broj;
        private System.Windows.Forms.Label Poeni;
        private System.Windows.Forms.PictureBox rocket1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox rocket2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox koin;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label coin;
        private System.Windows.Forms.Label coins;
    }
}

