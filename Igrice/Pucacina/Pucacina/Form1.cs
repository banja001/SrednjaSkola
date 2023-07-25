using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pucacina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Top + 10;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 10;
            meci1.BackColor = Color.Transparent;
            meci2.BackColor = Color.Transparent;
            meci3.BackColor = Color.Transparent;
            meci4.BackColor = Color.Transparent;
            meci5.BackColor = Color.Transparent;
            meci1.Location = new Point(10,ClientSize.Height-meci1.Size.Height-10);
            meci2.Location = new Point(10 + meci1.Size.Width, ClientSize.Height - meci2.Size.Height - 10);
            meci3.Location = new Point(10 + meci1.Size.Width + meci2.Size.Width, ClientSize.Height - meci3.Size.Height - 10);
            meci4.Location = new Point(10 + meci1.Size.Width + meci2.Size.Width + meci3.Size.Width, ClientSize.Height - meci4.Size.Height - 10);
            meci5.Location = new Point(10 + meci1.Size.Width + meci2.Size.Width + meci3.Size.Width + meci4.Size.Width, ClientSize.Height - meci5.Size.Height - 10);
            reload.Location = new Point(ClientSize.Width - 10 - reload.Size.Width, ClientSize.Height - 10 - reload.Size.Height);
            meta1.Hide();
            meta2.Hide();
            meta3.Hide();
            meta4.Hide();
            meta5.Hide();
            meta1.BackColor = Color.Transparent;
            meta2.BackColor = Color.Transparent;
            meta3.BackColor = Color.Transparent;
            meta4.BackColor = Color.Transparent;
            meta5.BackColor = Color.Transparent;
            rez2.Location = new Point(0, 0);
            rez.Location = new Point(10, 15);
            rez2.BackColor = Color.Transparent;
            srce1.BackColor = Color.Transparent;
            srce2.BackColor = Color.Transparent;
            srce3.BackColor = Color.Transparent;
            srce1.Location = new Point(ClientSize.Width - 10 - srce3.Size.Width - srce2.Size.Width-srce1.Size.Width, 10);
            srce2.Location = new Point(ClientSize.Width - 10 - srce3.Size.Width - srce2.Size.Width, 10);
            srce3.Location = new Point(ClientSize.Width - srce3.Size.Width - 10, 10);
            odeigra2.BackColor = Color.Transparent;
            igra2.BackColor = Color.Transparent;
            pomoc2.BackColor = Color.Transparent;
            kraji2.BackColor = Color.Transparent;
            odeigra.Location = new Point(ClientSize.Width / 2 - odeigra2.Size.Width / 2 + 60, 100 + odeigra2.Size.Height + 16 - 50);
            odeigra2.Location = new Point(ClientSize.Width / 2 - odeigra2.Size.Width / 2, 100 + odeigra2.Size.Height - 50);
            igra.Location = new Point(ClientSize.Width / 2 - igra2.Size.Width / 2 + 20, 160 + odeigra2.Size.Height + igra2.Size.Height + 10 - 50);
            pomoc.Location = new Point(ClientSize.Width / 2 - pomoc2.Size.Width / 2 + 20, 180 + odeigra2.Size.Height + igra2.Size.Height + pomoc2.Size.Height + 10 - 50);
            kraji.Location = new Point(ClientSize.Width / 2 - kraji2.Size.Width / 2 + 27, 200 + odeigra2.Size.Height + igra2.Size.Height + pomoc2.Size.Height + kraji2.Size.Height + 10 - 50);
            igra2.Location = new Point(ClientSize.Width / 2 - igra2.Size.Width / 2, 160 + odeigra2.Size.Height + igra2.Size.Height-50);
            pomoc2.Location = new Point(ClientSize.Width / 2 - pomoc2.Size.Width / 2, 180 + odeigra2.Size.Height + igra2.Size.Height + pomoc2.Size.Height-50);
            kraji2.Location = new Point(ClientSize.Width / 2 - kraji2.Size.Width / 2, 200 + odeigra2.Size.Height + igra2.Size.Height + pomoc2.Size.Height + kraji2.Size.Height-50);
            odeigra.Hide();
            odeigra2.Hide();
            beg1.BackColor = Color.Transparent;
            loop1.BackColor = Color.Transparent;
            beg1.Hide();
            this.Text = "Shoot or die!";
            this.Cursor = nov((Bitmap)Resource1.ada, new Size(50, 50));
        }
        public static Cursor nov(Bitmap b, Size s)
        {
            b = new Bitmap(b, s);
            return new Cursor(b.GetHicon());
        }
        int metak = 0;
        int i = 0,x;
        Random r = new Random();
        int pom = 30, rezultat = 0,zivot=0,j=0,k=0;
        public void ode(PictureBox a,int brz)
        {
            if (a.Top > ClientSize.Height)
            {
                x = r.Next(0, ClientSize.Width-60);
                a.Location = new Point(x, -60);
                zivot++;
            }
            else
            {
                a.Top += Convert.ToInt32(brz);
            }
        }
        public void beg(PictureBox a, int brz)
        {
            if (a.Top > ClientSize.Height)
            {
                x = r.Next(0, ClientSize.Width - 60);
                a.Location = new Point(x, -60);
                brojac += 15;
            }
            if (a.Top <= ClientSize.Height&&a.Top!=0)
                a.Top += Convert.ToInt32(brz);
            
        }
        public void metkovi()
        {
            if (metak == 0&&j==0)
            {
                meci5.Hide();
                metak++;
            }
            else
            {
                if (metak == 1&&j==0)
                {
                    meci4.Hide();
                    metak++;
                }
                else
                {
                    if (metak == 2&&j==0)
                    {
                        meci3.Hide();
                        metak++;
                    }
                    else
                    {
                        if (metak == 3 && j == 0)
                        {
                            meci2.Hide();
                            metak++;
                        }
                        else
                        {
                            if (metak == 4 && j == 0)
                            {
                                meci1.Hide();
                                metak++;
                            }
                        }
                    }
                }
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            metkovi();
        }
        int brojac = 15;
        int brojac1 = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 25)
            {
                meta1.Show();
                ode(meta1,pom+rezultat);
            }
            if (i > 25)
            {
                meta3.Show();
                ode(meta3, pom + rezultat);
            }
            if (i > 25)
            {
                meta5.Show();
                ode(meta5, pom + rezultat);
            }
            if (rezultat > 20 )
            {
                meta2.Show();
                ode(meta2, pom + rezultat);
            }
            if (rezultat > 30)
            {
                meta4.Show();
                ode(meta4, pom + rezultat);
            }
            if (rezultat > brojac)
            {
                beg1.Show();
                beg(beg1, pom + rezultat);
            }
            else
            {
                beg1.Hide();
            }
            i++;
            if (rezultat > brojac1&&j==0)
            {
                loop1.Show();
                beg(loop1, pom + rezultat);
                
            }
            else
            {
                loop1.Hide();
            }
            loop();
            kraj();
        }

        private void meta1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (metak < 5)
            {
                rezultat++;
                rez.Text = "SCORE: " + rezultat.ToString();
                x = r.Next(0, ClientSize.Width - 60);
                meta1.Location = new Point(x, -60);
            }
            metkovi();
        }

        private void meta3_Click(object sender, EventArgs e)
        {
            if (metak < 5)
            {
                rezultat++;
                rez.Text = "SCORE: " + rezultat.ToString();
                x = r.Next(0, ClientSize.Width - 60);
                meta3.Location = new Point(x, -60);
            }
            metkovi();
        }

        private void meta5_Click(object sender, EventArgs e)
        {
            if (metak < 5)
            {
                rezultat++;
                rez.Text = "SCORE: " + rezultat.ToString();
                x = r.Next(0, ClientSize.Width - 60);
                meta5.Location = new Point(x, -60);
            }
            metkovi();
        }

        private void meta2_Click(object sender, EventArgs e)
        {
            if (metak < 5)
            {
                rezultat++;
                rez.Text = "SCORE: " + rezultat.ToString();
                x = r.Next(0, ClientSize.Width - 60);
                meta2.Location = new Point(x, -60);
            }
            metkovi();
        }

        private void meta4_Click(object sender, EventArgs e)
        {
            if (metak < 5)
            {
                rezultat++;
                rez.Text = "SCORE: " + rezultat.ToString();
                x = r.Next(0, ClientSize.Width - 60);
                meta4.Location = new Point(x, -60);
            }
            metkovi();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            object b= new object();
            EventArgs a = new EventArgs();
            if (e.KeyCode == Keys.R)
                reload_Click(b,a);
        }

        private void reload_Click(object sender, EventArgs e)
        {
            meci1.Show();
            meci2.Show();
            meci3.Show();
            meci4.Show();
            meci5.Show();
            metak = 0;
        }
        public void kraj()
        {
            if (zivot > 0)
                srce1.Hide();
            if (zivot > 1)
                srce2.Hide();
            if (zivot >2)
            {
                srce3.Hide();
                timer1.Stop();
                odeigra.Show();
                odeigra2.Show();
                igra.Show();
                kraji.Show();
                pomoc.Show();
                igra2.Show();
                kraji2.Show();
                pomoc2.Show();
                metak = 5;
            }
        }
        private void igra_Click(object sender, EventArgs e)
        {
            odeigra.Hide();
            odeigra2.Hide();
            igra.Hide();
            pomoc.Hide();
            kraji.Hide();
            igra2.Hide();
            pomoc2.Hide();
            kraji2.Hide();
            timer1.Start();
            zivot = 0;
            metak = 0;
            rezultat = 0;
            pom = 30;
            i = 0;
            meci1.Visible = meci2.Visible = meci3.Visible = meci4.Visible = meci5.Visible = true;
            brojac = brojac1 = 15;
            srce1.Visible = srce2.Visible = srce3.Visible = true;
            j = 0;
            k = 0;
            meta1.Location = new Point(r.Next(0,ClientSize.Width-60),-60);
            meta2.Location = new Point(r.Next(0, ClientSize.Width - 60), -60);
            meta3.Location = new Point(r.Next(0, ClientSize.Width - 60), -60);
            meta4.Location = new Point(r.Next(0, ClientSize.Width - 60), -60);
            meta5.Location = new Point(r.Next(0, ClientSize.Width - 60), -60);
            rez.Text = "SCORE: " + rezultat.ToString();
        }

        private void kraji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pomoc_Click(object sender, EventArgs e)
        {
            Form2 nova = new Form2();
            nova.Owner = this;
            nova.ShowDialog();
        }

        private void beg1_Click(object sender, EventArgs e)
        {
            if (metak < 5)
            {
                zivot++;
                x = r.Next(0, ClientSize.Width - 60);
                beg1.Location = new Point(x, -60);
            }
        }
        private void loop()
        {
            if (k <= 15 && k > 0)
            {

                meci1.Visible = meci2.Visible = meci3.Visible = meci4.Visible = meci5.Visible = true;
                metak = -1;
            }
            else
            {
                timer2.Stop();
                j = 0;
                k = 0;
            }
            if (k == 15)
            {
                metak = 0;
            }
        }
        private void loop1_Click(object sender, EventArgs e)
        {
            x = r.Next(0, ClientSize.Width - 60);
            loop1.Location = new Point(x, -60);
            timer2.Start();
            j = 1;
            k = 1;
            brojac1 += 30;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            k++;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                object b = new object();
                EventArgs a = new EventArgs();
                reload_Click(b, a);
            }
        }
    }
}
