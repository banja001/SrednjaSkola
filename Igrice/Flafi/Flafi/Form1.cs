using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Probaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1,j=0,d=0,k=1,p=0,d1=0,q=0,s=0,c=0;
        bool w = true,l=true;
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            a.Top += i;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            Poeni.Text = p.ToString();
            Broj.BackColor = Color.Transparent;
            Poeni.BackColor = Color.Transparent;
            a.BackColor = Color.Transparent;
            rocket1.Visible = false;
            rocket1.BackColor = Color.Transparent;
            rocket2.Visible = false;
            rocket2.BackColor = Color.Transparent;
            koin.Visible = false;
            koin.BackColor = Color.Transparent;
            coin.BackColor = Color.Transparent;
            coins.BackColor = Color.Transparent;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            kec.Left -= k;
            dvojka.Left -= k;
            kec1.Left -= k;
            dvojka1.Left -= k;
            p++;
            if (kec.Left < -kec.Width)
            {
                Ode();
            }
            if (kec1.Left < -kec1.Width)
            {
                Ode1();
            }
            Poeni.Text = p.ToString();
            
            if (p == 500)
            {
                k = 2;
            }
            if (p == 550)
                Koins();
            if (p == 1000)
            {
                k = 3;
                Raketa();
            }
            if (p == 1500)
            {
                k = 4;
                Raketa();
            }
            if (p == 1750)
                Raketa2();
            if (p == 2000)
            {
                k = 5;
                Raketa();
                Raketa2();
            }
            if (p == 2500)
            {
                k = 6;
                Raketa();
            }
            if (p == 2750)
                Raketa2();
            if (p == 3000)
            {
                k = 7;
                Raketa();
                Raketa2();
            }
            if (p == 3500)
            {
                k = 8;
                Raketa();
            }
            if (p == 3750)
                Raketa2();
            if (p == 4000)
            {
                k = 11;
                Raketa();
                Raketa2();
            }
            if (koin.Left < 0)
            {
                Koins();
            }
            Pogodak();
            Kraj();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                i = -1;
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (w)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                    w = false;
                }
                else if(l)
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    timer4.Start();
                    timer5.Start();
                    w = true;
                }
            }
        }

        public void Ode()
        {      
                d = r.Next(0,ClientSize.Height-100);
                kec.Height = d;
                dvojka.Height = ClientSize.Height - d - 100;
                kec.Location = new Point(ClientSize.Width, 0);
                dvojka.Location = new Point(ClientSize.Width,kec.Height+100);
        }

        public void Ode1()
        {
            d1 = r.Next(0, ClientSize.Height - 100);
            kec1.Height = d1;
            dvojka1.Height = ClientSize.Height - d1 - 100;
            kec1.Location = new Point(ClientSize.Width, 0);
            dvojka1.Location = new Point(ClientSize.Width, kec1.Height + 100);
        }
        public void Kraj()
        {
            if (a.Bounds.IntersectsWith(kec.Bounds) || a.Bounds.IntersectsWith(dvojka.Bounds) || a.Top < 0 || a.Top > ClientSize.Height - a.Height || a.Bounds.IntersectsWith(kec1.Bounds) || a.Bounds.IntersectsWith(dvojka1.Bounds) || a.Bounds.IntersectsWith(rocket1.Bounds) || a.Bounds.IntersectsWith(rocket2.Bounds))
            {
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timer1.Stop();
                timer2.Stop();
                l = false;
            }
        }

       /* public void Poen()
        {
            if (a.Location.X == kec.Location.X + kec.Width || a.Location.X == kec1.Location.X + kec1.Width)
                p++;
        }
        */

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                i = 1;
               
            }
        }
        public void Raketa()
        {
            rocket1.Visible=true;
            rocket1.Location = new Point(ClientSize.Width-rocket1.Width,r.Next(rocket1.Height,ClientSize.Height-rocket1.Height));
            j = 0;
            timer3.Start();
        }

        public void Raketa2()
        {
            rocket2.Visible = true;
            rocket2.Location = new Point(ClientSize.Width - rocket2.Width, r.Next(rocket2.Height, ClientSize.Height - rocket2.Height));
            q = 0;
            timer4.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            j++;
            if (j == 100)
            {
                rocket1.Image = null;
                rocket1.BackColor = Color.White;
            }
            if (j == 107)
            {
                rocket1.Image = Resource2.rocket;
                rocket1.BackColor = Color.Transparent;
            }
            if (j > 107)
            {
                rocket1.Left -= 20;
            }
            if (rocket1.Left == -rocket1.Width)
                timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            q++;
            if (q == 150)
            {
                rocket2.Image = null;
                rocket2.BackColor = Color.White;
            }
            if (q == 157)
            {
                rocket2.Image = Resource2.rocket;
                rocket2.BackColor = Color.Transparent;
            }
            if (q > 157)
            {
                rocket2.Left -= 20;
            }
            if (rocket2.Left == -rocket2.Width)
                timer4.Stop();
        }
        public void Koins()
        {

            koin.Visible = true;
            koin.Location = new Point(ClientSize.Width , r.Next(rocket2.Height, ClientSize.Height - rocket2.Height));
            while (koin.Bounds.IntersectsWith(kec.Bounds) || koin.Bounds.IntersectsWith(kec1.Bounds) || koin.Bounds.IntersectsWith(dvojka.Bounds) || koin.Bounds.IntersectsWith(dvojka1.Bounds))
                koin.Location = new Point(ClientSize.Width, r.Next(rocket2.Height, ClientSize.Height - rocket2.Height));
            s = 0;
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            s++;
            koin.Left -= k;
            if (koin.Left == -koin.Width)
                timer5.Stop();
        }
        public void Pogodak()
        {
            if (a.Bounds.IntersectsWith(koin.Bounds))
            {
                c++;
                koin.Location = new Point(-koin.Width, r.Next(rocket2.Height, ClientSize.Height - rocket2.Height));
                coin.Text = c.ToString();
                timer5.Stop();
            }
        }
    }
}