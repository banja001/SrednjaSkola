using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

namespace Autici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Cars";
            rezu2.Hide();
            label4.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label7.Text = "X 0";
            stit.Hide();
            pok.Hide();
            pb.Hide();
            rp.Hide();
            odebata1.Hide();
            odebata2.Hide();
            odebata3.Hide();
            odebata4.Hide();
            label1.Hide();
            novcic1.Hide();
            novcic2.Hide();
            novcic3.Hide();
            novcic4.Hide();
            auto2.Hide();
            pb2.Hide();
            leva.Width = 10;
            leva.Height = ClientSize.Height;
            desna.Width = 10;
            desna.Height = ClientSize.Height;
            desna.Location = new Point(ClientSize.Width - 10, 0);
            label1.Location = new Point(ClientSize.Width / 2 - label1.Size.Width / 2, ClientSize.Height / 10);
            label2.Location = new Point(ClientSize.Width / 2 - label2.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 3.125));
            label6.Location = new Point(ClientSize.Width / 2 - label6.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 2.315));
            label3.Location = new Point(ClientSize.Width / 2 - label3.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.525));
            label5.Location = new Point(ClientSize.Width / 2 - label5.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.84));
            pictureBox3.Location = new Point(ClientSize.Width / 2 - pictureBox3.Size.Width / 2, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(ClientSize.Width / 2 - pictureBox4.Size.Width / 2, pictureBox4.Location.Y);
            pictureBox5.Location = new Point(ClientSize.Width / 2 - pictureBox5.Size.Width / 2, pictureBox5.Location.Y);
            pictureBox6.Location = new Point(ClientSize.Width / 2 - pictureBox6.Size.Width / 2, pictureBox6.Location.Y);
            pictureBox7.Location = new Point(ClientSize.Width / 2 - pictureBox7.Size.Width / 2, pictureBox7.Location.Y);
            pictureBox9.Location = new Point(ClientSize.Width / 2 - pictureBox9.Size.Width / 2, pictureBox9.Location.Y);
            pictureBox3.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox4.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox5.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox6.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox7.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox9.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            auto.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8);
            auto.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28));
            odebata1.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata3.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata4.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            if (i > 0)
            {
                odebata1.Location = new Point(ClientSize.Width / 10, ClientSize.Height / 10);
                odebata2.Location = new Point(ClientSize.Width / 4, Convert.ToInt32(ClientSize.Height / 1.86));
                odebata3.Location = new Point(Convert.ToInt32(ClientSize.Height / 1.67), Convert.ToInt32(ClientSize.Height / 3.84));
                odebata4.Location = new Point(Convert.ToInt32(ClientSize.Height / 1.27), Convert.ToInt32(ClientSize.Height / 1.67));
            }
            rp.Location = new Point(ClientSize.Width / 2 - rp.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 2.315));
            rp.Font = label6.Font;
            rezu1.Location = new Point(ClientSize.Width - desna.Size.Width - label7.Size.Width - rezu2.Size.Width, 3);
            rezu1.Size = new Size(Convert.ToInt32(ClientSize.Width / 8.51), Convert.ToInt32(ClientSize.Width / 8.51));
            rezu2.Size = new Size(Convert.ToInt32(ClientSize.Width / 8.51), Convert.ToInt32(ClientSize.Width / 8.51));
            label7.Location = new Point(Convert.ToInt32(ClientSize.Width - desna.Size.Width - label7.Size.Width), rezu2.Size.Height / 2 - label7.Size.Height / 2);
            auto2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8);
            novcic1.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic2.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic3.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic4.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            stit.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            label4.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 33.333333));
            label3.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label2.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label1.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label6.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label7.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 33.33333));
            label5.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            if (a == 0)
            {
                pb.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28 + auto.Size.Height));
                pb.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
            }
            if (a == 2)
            {

                pb2.Location = new Point(Convert.ToInt32(ClientSize.Width / 2.78), Convert.ToInt32(ClientSize.Height / 1.11));
                pb.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.96), Convert.ToInt32(ClientSize.Height / 1.11));
                pb.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
                pb2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
            }
            label4.Location = new Point(Convert.ToInt32(leva.Size.Width + rezu2.Size.Width), rezu2.Size.Height / 2 - label4.Size.Height / 2);
            label4.Hide();
        }
        int j=0,k=0;
        SoundPlayer zika = new SoundPlayer("ja.wav");
        SoundPlayer zika3 = new SoundPlayer("bit3.wav");
        SoundPlayer zika2 = new SoundPlayer("bit.wav");
        int skor1, skor2;
        int sp;
        int jao = 1;
        int brzina = 60;
        double i=0;
        int a = 0, q = 0;
        int rez = 0,rez2=0,s=50;
        double pom = 10;
        Random r = new Random();
        int x,z=0,mz=0;
        int l = 0,m=0;
        double y = 0;
        public int [] niz=new int[20];
       public string [] sad=new string[20];
        void odebata(double brz,PictureBox odebata1)
        {
            if (odebata1.Top > ClientSize.Height)
            {
                x = r.Next(10, ClientSize.Width-odebata1.Size.Width);
                odebata1.Location = new Point(x, 0);
            }
            else
            {
                odebata1.Top +=Convert.ToInt32(brz);
            }
        }
        void stitovi(double brz, PictureBox stit)
        {
            if (stit.Top > ClientSize.Height)
            {
                if(i>s)
                {
                    x = r.Next(10, ClientSize.Width - stit.Size.Width);
                    stit.Location = new Point(x, 0);
                    s+=50;
                }
            }
            else
            {
                stit.Top += Convert.ToInt32(brz);
            }
        }
        void linije(double pom, PictureBox p)
        {
            if (p.Top > ClientSize.Height)
                p.Top = 0;
            else
                p.Top += Convert.ToInt32(pom);
        }
        void ogr(PictureBox p)
        {
            if (p.Left > ClientSize.Width-p.Size.Width-desna.Size.Width)
                p.Left = ClientSize.Width - p.Size.Width - desna.Size.Width;
            if (p.Left < 10)
                p.Left = 10;
        }
        void ogr2(ProgressBar p)
        {
            if (p.Left > ClientSize.Width - p.Size.Width - desna.Size.Width)
                p.Left = ClientSize.Width - p.Size.Width - desna.Size.Width;
            if (p.Left < 10)
                p.Left = 10;
        }
        void citanje()
        {
            using (StreamReader reader = new StreamReader("Skor.txt"))
            {
                string s = reader.ReadLine();
                while (s != null)
                {
                    jao++;
                    s = reader.ReadLine();
                }
                reader.Close();
            }
        }
        public string[] nik()
        {
            string [] sa=new string[11];
            int i = 0;
            using (StreamReader reader = new StreamReader("Skor.txt"))
            {
                string s = reader.ReadLine();
                char c = ',';
                while (s != null)
                {
                    if (i == 9)
                    {
                        int n = s.LastIndexOf(c);
                        string a = s.Substring(4, n - 4);
                        sa[i] = a;
                        s = reader.ReadLine();
                        i++;
                    }
                    else
                    {
                        int n = s.LastIndexOf(c);
                        string a = s.Substring(3, n - 3);
                        sa[i] = a;
                        s = reader.ReadLine();
                        i++;
                    }
                }
            }
            return sa;
        }
        public int[] raz()
        {
            int [] raz=new int [11];
            int i = 0;
            using (StreamReader reader = new StreamReader("Skor.txt"))
            {
                string s = reader.ReadLine();
                char c = ',';
                while (s != null)
                {
                    int n = s.LastIndexOf(c);
                    string a = s.Substring(n + 1, 3);
                    raz[i] = Convert.ToInt32(a);
                    s = reader.ReadLine();
                    i++;
                }
            }
            return raz;
        }
        public int jot=11;
        public string imena;
        void kraj(PictureBox a, PictureBox b, PictureBox c, PictureBox d, PictureBox e,int w,PictureBox a2)
        {
            
            if (w == 0)
            {
                if ((a.Bounds.IntersectsWith(b.Bounds) || a.Bounds.IntersectsWith(c.Bounds) || a.Bounds.IntersectsWith(d.Bounds) || a.Bounds.IntersectsWith(e.Bounds)) && l == 0)
                {
                    
                    label1.Show();
                    label2.Show();
                    label3.Show();
                    label5.Show();
                    label6.Show();
                    timer1.Stop();
                    rez = 0;
                    rez2 = 0;
                    pom = 10;
                    y = 0;
                    j++;
                    brzina = 60;
                    //citanje();
                    
                }
                else if (a.Bounds.IntersectsWith(b.Bounds) || a.Bounds.IntersectsWith(c.Bounds) || a.Bounds.IntersectsWith(d.Bounds) || a.Bounds.IntersectsWith(e.Bounds))
                {
                    l--;
                    if (l > 0)
                    {
                        pb.Value=l;
                    }
                    if (l < 1)
                        pb.Hide();
                }

            }
            else if (w == 2)
            {
                if ((a.Bounds.IntersectsWith(b.Bounds)||a.Bounds.IntersectsWith(c.Bounds)||a.Bounds.IntersectsWith(d.Bounds)||a.Bounds.IntersectsWith(e.Bounds))&& l==0)
                {
                    j++;
                    pb.Hide();
                    auto.Hide();
                }
                else if ((a.Bounds.IntersectsWith(b.Bounds)||a.Bounds.IntersectsWith(c.Bounds)||a.Bounds.IntersectsWith(d.Bounds)||a.Bounds.IntersectsWith(e.Bounds)))
                {
                    l--;
                    if (l > 0)
                    {
                        pb.Value = l;
                    }
                    if (l < 1)
                        pb.Hide();
                }
                if ((a2.Bounds.IntersectsWith(b.Bounds) || a2.Bounds.IntersectsWith(c.Bounds) || a2.Bounds.IntersectsWith(d.Bounds) || a2.Bounds.IntersectsWith(e.Bounds)) && m == 0)
                {
                    k++;
                    pb2.Hide();
                    auto2.Hide();
                }
                else if (a2.Bounds.IntersectsWith(b.Bounds) || a2.Bounds.IntersectsWith(c.Bounds) || a2.Bounds.IntersectsWith(d.Bounds) || a2.Bounds.IntersectsWith(e.Bounds))
                {
                    m--;
                    if (m > 0)
                    {
                        pb2.Value = m;
                    }
                    if (m < 1)
                        pb2.Hide();
                }
            }
        }
        int rezultat(PictureBox a, PictureBox b, PictureBox c, PictureBox d, PictureBox e)
        {
            if (a.Bounds.IntersectsWith(e.Bounds)&&j==0)
            {
                rez++;
                y+=0.5;
                x = r.Next(10, ClientSize.Width - 45);
                e.Location = new Point(x, 0);
                brzina++;
            }
            if (a.Bounds.IntersectsWith(c.Bounds)&&j==0)
            {
                y += 0.5;
                rez++;
                x = r.Next(10, ClientSize.Width - 45);
                c.Location = new Point(x, 0);
                brzina++;
            }
            if (a.Bounds.IntersectsWith(d.Bounds) && j == 0)
            {
                y += 0.5;
                rez++;
                x = r.Next(10, ClientSize.Width - 45);
                d.Location = new Point(x, 0);
                brzina++;
            }
            if (a.Bounds.IntersectsWith(b.Bounds) && j == 0)
            {
                y += 0.5;
                rez++;
                x = r.Next(10, ClientSize.Width - 45);
                b.Location = new Point(x, 0);
                brzina++;
            }
            return rez;
        }
        int rezultat2(PictureBox a, PictureBox b, PictureBox c, PictureBox d, PictureBox e)
        {
            if (a.Bounds.IntersectsWith(e.Bounds)&&k==0)
            {
                rez2++;
                y += 0.5;
                x = r.Next(10, ClientSize.Width - 45);
                e.Location = new Point(x, 0);
                brzina++;
            }
            if (a.Bounds.IntersectsWith(c.Bounds) && k == 0)
            {
                y += 0.5;
                rez2++;
                x = r.Next(10, ClientSize.Width - 45);
                c.Location = new Point(x, 0);
                brzina++;
            }
            if (a.Bounds.IntersectsWith(d.Bounds) && k == 0)
            {
                y += 0.5;
                rez2++;
                x = r.Next(10, ClientSize.Width - 45);
                d.Location = new Point(x, 0);
                brzina++;
            }
            if (a.Bounds.IntersectsWith(b.Bounds) && k == 0)
            {
                y += 0.5;
                rez2++;
                x = r.Next(10, ClientSize.Width - 45);
                b.Location = new Point(x, 0);
                brzina++;
            }
            return rez2;
        }
        void moc(PictureBox a, PictureBox b)
        {
            if (a.Bounds.IntersectsWith(b.Bounds))
            {
                l = 12;
                pb.Value = l;
                pb.Show();
                x = r.Next(10, ClientSize.Width - 45);
                b.Location = new Point(x, 0);
            }
        }
        void moc2(PictureBox a, PictureBox b)
        {
            if (a.Bounds.IntersectsWith(b.Bounds))
            {
                m = 12;
                pb2.Value = m;
                pb2.Show();
                x = r.Next(10, ClientSize.Width - 45);
                b.Location = new Point(x, 0);
            }
        }
        int max(int a, int b)
        {
            if (a > b)
                return a;
            else 
                return b;
        }
        void upis()
        {
            if (a == 0)
            {
                niz = raz();
                niz[10] = skor1;
                sad = nik();
                Array.Sort(niz);
                Array.Reverse(niz);
                for (int o = 0; o < 10; o++)
                {
                    if (niz[o] == skor1)
                        jot = o;
                }
                Form2 nova = new Form2();
                nova.Owner = this;
                nova.ShowDialog();
                if(nova.sicko==1)
                imena = nova.ime.Text;
                string name = "Skor.txt";
                using (StreamWriter sr = new StreamWriter(name, false))
                {
                    int jo = 0;
                    for (int o = 0; o < 10; o++)
                    {
                        if (o == jot)

                            sr.WriteLine((o + 1).ToString() + ". " + imena + "," + niz[o].ToString("000"));

                        else
                        {
                            sr.WriteLine((o + 1).ToString() + ". " + sad[jo] + "," + niz[o].ToString("000"));
                            jo++;
                        }
                    }
                    sr.Close();
                }
            }
            else if (a == 2)
            {
                niz = raz();
                int maks = max(skor1, skor2);
                niz[10] = maks;
                sad = nik();
                Array.Sort(niz);
                Array.Reverse(niz);
                for (int o = 0; o < 10; o++)
                {
                    if (niz[o] == maks)
                        jot = o;
                }
                Form2 nova = new Form2();
                nova.Owner = this;
                nova.ShowDialog();
                if(nova.sicko==1)
                imena = nova.ime.Text;
                string name = "Skor.txt";
                using (StreamWriter sr = new StreamWriter(name, false))
                {
                    int jo = 0;
                    for (int o = 0; o < 10; o++)
                    {
                        if (i == jot)

                            sr.WriteLine((o + 1).ToString() + ". " + imena + "," + niz[o].ToString("000"));

                        else
                        {
                            sr.WriteLine((o + 1).ToString() + ". " + sad[jo] + "," + niz[o].ToString("000"));
                            jo++;
                        }
                    }
                    sr.Close();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            linije(pom+y, pictureBox3);
            linije(pom + y, pictureBox4);
            linije(pom + y, pictureBox5);
            linije(pom + y, pictureBox6);
            linije(pom + y, pictureBox7);
            linije(pom + y, pictureBox9);
            odebata(pom + y, odebata1);
            odebata(pom + y, odebata2);
            odebata(pom + y, odebata3);
            odebata(pom + y, odebata4);
            odebata(pom + y, novcic1);
            odebata(pom + y, novcic2);
            odebata(pom + y, novcic3);
            odebata(pom + y, novcic4);
            skor1 = rezultat(auto, novcic1, novcic2, novcic3, novcic4);
            skor2 = rezultat2(auto2, novcic1, novcic2, novcic3, novcic4);
            label7.Text = "X " + skor1.ToString();
            label4.Text = "X " + skor2.ToString();
            i++;
            km.Text = brzina.ToString() + " Km/h";
            km.Location = new Point(ClientSize.Width - 10 - km.Size.Width, ClientSize.Height - km.Height);
            if (i > 100)
            {
                stit.Show();
                stitovi(pom + y, stit);
            }
            label7.Location = new Point(Convert.ToInt32(ClientSize.Width - desna.Size.Width - label7.Size.Width), rezu2.Size.Height / 2 - label7.Size.Height / 2);
            rezu1.Location = new Point(ClientSize.Width - desna.Size.Width - label7.Size.Width - rezu2.Size.Width, 3);
            if(j==0)
            moc(auto, stit);
            if (k == 0)
            moc2(auto2, stit);
            kraj(auto, odebata1, odebata2, odebata3, odebata4,a, auto2);
            if (k > 0)
                pb2.Hide();
            if (j > 0)
                pb.Hide();
            if (k >0 && j >0)
            {
                label1.Show();
                label2.Show();
                label5.Show();
                label3.Show();
                label6.Show();
                timer1.Stop();
                rez = 0;
                rez2 = 0;
                pom = 10;
                y = 0;
                i = 0;
                brzina = 60;
                upis();
            }

        }
        int ik = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left && ik==0)
            {
                auto.Left -= 30;
                pb.Left -= 30;
            }
            if (e.KeyCode == Keys.Right && ik == 0)
            {
                auto.Left += 30;
                pb.Left += 30;
            }
            if (e.KeyCode == Keys.A && ik == 0)
            {
                auto2.Left -= 30;
                pb2.Left -= 30;
            }
            if (e.KeyCode == Keys.D && ik == 0)
            {
                auto2.Left += 30;
                pb2.Left += 30;
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (ik == 0)
                {
                    timer1.Stop();
                    ik = 1;
                    label2.Visible = true;
                    label3.Visible = true;
                    label5.Visible = true;
                    rp.Visible = true;
                }
                else
                {
                    if (ik == 1)
                    {
                        timer1.Start();
                        ik = 0;
                        label2.Visible = false;
                        label3.Visible = false;
                        label5.Visible = false;
                        rp.Visible = false;
                    }
                }
            }
            ogr(auto);
            ogr(auto2);
            ogr2(pb);
            ogr2(pb2);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            rez = 0;
            rp.Hide();
            rez2 = 0;
            pom = 10;
            y = 0;
            brzina = 60;
            a = 0;
            i = 0;
            ik = 0;
            k = 1;
            stit.Hide();
            auto2.Hide();
            auto.Show();
            rezu2.Hide();
            timer1.Start();
            label4.Hide();
            if (a == 0)
            {
                auto.Location = new Point(ClientSize.Width / 2 -auto.Size.Width/2, Convert.ToInt32(ClientSize.Height / 1.28));
            }
            else if (a == 2)
            {
                auto.Location = new Point(Convert.ToInt32(ClientSize.Width / 2.78), Convert.ToInt32(ClientSize.Height / 1.11));
                auto2.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.96), Convert.ToInt32(ClientSize.Height / 1.11));
            }
            label1.Hide();
            pb.Hide();
            label2.Hide();
            label3.Hide();
            label5.Hide();
            label6.Hide();
            label4.Hide();
            odebata1.Show();
            odebata2.Show();
            odebata3.Show();
            odebata4.Show();
            novcic1.Show();
            novcic2.Show();
            novcic3.Show();
            novcic4.Show();
            odebata1.Location = new Point(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata2.Location = new Point(ClientSize.Width / 4, Convert.ToInt32(ClientSize.Height / 1.86));
            odebata3.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.67), Convert.ToInt32(ClientSize.Height / 3.84));
            odebata4.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.27), Convert.ToInt32(ClientSize.Height / 1.67));
            auto.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8); 
            auto.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28));
            auto2.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28+100));
            pom = 10;
            j = 0;
            if (a == 0)
            {
                pb.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28+auto.Size.Height));
                pb.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
                pb2.Location = new Point(Convert.ToInt32(ClientSize.Width / 2.78), Convert.ToInt32(ClientSize.Height / 1.11+100));
            }
            if (a == 2)
            {

                pb2.Location = new Point(Convert.ToInt32(ClientSize.Width / 2.78), Convert.ToInt32(ClientSize.Height / 1.11));
                pb.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.96), Convert.ToInt32(ClientSize.Height / 1.11));
                pb.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
                pb2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
           leva.Width = 10;
            leva.Height = ClientSize.Height;
            desna.Width = 10;
            desna.Height = ClientSize.Height;
            desna.Location = new Point(ClientSize.Width - 10, 0);
            label1.Location = new Point(ClientSize.Width / 2 - label1.Size.Width / 2, ClientSize.Height / 10);
            label2.Location = new Point(ClientSize.Width / 2 - label2.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 3.125));
            label6.Location = new Point(ClientSize.Width / 2 - label6.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 2.315));
            label3.Location = new Point(ClientSize.Width / 2 - label3.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.525));
            label5.Location = new Point(ClientSize.Width / 2 - label5.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.84));
            pictureBox3.Location = new Point(ClientSize.Width / 2 - pictureBox3.Size.Width / 2, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(ClientSize.Width / 2 - pictureBox4.Size.Width / 2, pictureBox4.Location.Y);
            pictureBox5.Location = new Point(ClientSize.Width / 2 - pictureBox5.Size.Width / 2, pictureBox5.Location.Y);
            pictureBox6.Location = new Point(ClientSize.Width / 2 - pictureBox6.Size.Width / 2, pictureBox6.Location.Y);
            pictureBox7.Location = new Point(ClientSize.Width / 2 - pictureBox7.Size.Width / 2, pictureBox7.Location.Y);
            pictureBox9.Location = new Point(ClientSize.Width / 2 - pictureBox9.Size.Width / 2, pictureBox9.Location.Y);
            pictureBox3.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox4.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox5.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox6.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox7.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox9.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            auto.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8);
            //auto.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28));
            odebata1.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata3.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata4.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            /*if (i > 0)
            {
                odebata1.Location = new Point(ClientSize.Width / 10, ClientSize.Height / 10);
                odebata2.Location = new Point(ClientSize.Width / 4, Convert.ToInt32(ClientSize.Height / 1.86));
                odebata3.Location = new Point(Convert.ToInt32(ClientSize.Height / 1.67), Convert.ToInt32(ClientSize.Height / 3.84));
                odebata4.Location = new Point(Convert.ToInt32(ClientSize.Height / 1.27), Convert.ToInt32(ClientSize.Height / 1.67));
            }*/
            rezu1.Location = new Point(ClientSize.Width-desna.Size.Width-label7.Size.Width-rezu2.Size.Width,3);
            rezu1.Size = new Size(Convert.ToInt32(ClientSize.Width / 8.51), Convert.ToInt32(ClientSize.Width / 8.51));
            rezu2.Size = new Size(Convert.ToInt32(ClientSize.Width / 8.51), Convert.ToInt32(ClientSize.Width / 8.51));
            label7.Location = new Point(Convert.ToInt32(ClientSize.Width -desna.Size.Width-label7.Size.Width), rezu2.Size.Height/2-label7.Size.Height/2);
            auto2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8);
            novcic1.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic2.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic3.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic4.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            stit.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            label4.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height/33.333333));
            label3.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height /16.67));
            label2.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label1.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label6.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label7.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 33.33333));
            label5.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            /*if (a == 0)
            {
                pb.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28 + auto.Size.Height));
                pb.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
            }
            if (a == 2)
            {

                pb2.Location = new Point(Convert.ToInt32(ClientSize.Width / 2.78), Convert.ToInt32(ClientSize.Height / 1.11));
                pb.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.96), Convert.ToInt32(ClientSize.Height / 1.11));
                pb.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
                pb2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
            }*/
            label4.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            odebata1.BackColor = Color.Transparent;
            odebata2.BackColor = Color.Transparent;
            odebata3.BackColor = Color.Transparent;
            odebata4.BackColor = Color.Transparent;
            novcic1.BackColor = Color.Transparent;
            novcic2.BackColor = Color.Transparent;
            novcic3.BackColor = Color.Transparent;
            novcic4.BackColor = Color.Transparent;
            auto.BackColor = Color.Transparent;
            auto2.BackColor = Color.Transparent;
            label4.Location = new Point(Convert.ToInt32(leva.Size.Width + rezu2.Size.Width), rezu2.Size.Height / 2 - label4.Size.Height / 2);
            zvuk.Location = new Point(10, ClientSize.Height - zvuk.Size.Height);
            zvuk.Size = new Size(Convert.ToInt32(ClientSize.Width / 16.76), Convert.ToInt32(ClientSize.Width / 16.76));
            km.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 33.333333));
            km.Location = new Point(ClientSize.Width - 10 - km.Size.Width, ClientSize.Height - km.Height);
            rp.Location = new Point(ClientSize.Width / 2 - rp.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 2.315));
            rp.Font = label6.Font;
            this.Top = Screen.PrimaryScreen.WorkingArea.Top + 10;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 10;
            this.Width = 620;
        }

        private void label5_Click(object sender, EventArgs e)
        {

            /*Form2 nova = new Form2();
            nova.Owner = this;
            nova.ShowDialog();*/
            Form3 nova = new Form3();
            nova.Owner = this;
            nova.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            rez = 0;
            rez2 = 0;
            pom = 10;
            y = 0;
            brzina = 60;
            ik = 0;
            a = 2;
            stit.Hide();
            j = k = 0;
            i = 0;
            label4.Show();
            auto2.Show();
            pb.Hide();
            pb2.Hide();
            rezu2.Show();
            timer1.Start();
            if (a == 0)
            {
                auto.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28));
                pb.Location = new Point(Convert.ToInt32(ClientSize.Width / 2 - auto.Size.Width / 2), Convert.ToInt32(ClientSize.Height / 1.28 + auto.Size.Height));
            }
            else if (a == 2)
            {
                auto2.Location = new Point(Convert.ToInt32(ClientSize.Width / 2.78), Convert.ToInt32(ClientSize.Height / 1.11 - auto.Size.Height));
                auto.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.96), Convert.ToInt32(ClientSize.Height / 1.11 - auto.Size.Height));
                pb.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.96), Convert.ToInt32(ClientSize.Height / 1.11));
                pb2.Location = new Point(Convert.ToInt32(ClientSize.Width / 2.78), Convert.ToInt32(ClientSize.Height / 1.11));
            }
            stit.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label5.Hide();
            label6.Hide();
            label4.Show();
            odebata1.Show();
            odebata2.Show();
            odebata3.Show();
            odebata4.Show();
            novcic1.Show();
            novcic2.Show();
            novcic3.Show();
            novcic4.Show();
            auto.Show();
            auto2.Show();
            odebata1.Location = new Point(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata2.Location = new Point(ClientSize.Width / 4, Convert.ToInt32(ClientSize.Height / 1.86));
            odebata3.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.67), Convert.ToInt32(ClientSize.Height / 3.84));
            odebata4.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.27), Convert.ToInt32(ClientSize.Height / 1.67));
            auto.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8);
            auto2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8);
            label4.Location = new Point(Convert.ToInt32(leva.Size.Width + rezu2.Size.Width), rezu2.Size.Height / 2 - label4.Size.Height / 2);
            pom = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rezu2.Hide();
            zika.Play();
            this.Top = Screen.PrimaryScreen.WorkingArea.Top + 10;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 10;
            label4.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            odebata1.BackColor = Color.Transparent;
            odebata2.BackColor = Color.Transparent; 
            odebata3.BackColor = Color.Transparent; 
            odebata4.BackColor = Color.Transparent;
            novcic1.BackColor = Color.Transparent;
            novcic2.BackColor = Color.Transparent;
            novcic3.BackColor = Color.Transparent;
            novcic4.BackColor = Color.Transparent;
            auto.BackColor = Color.Transparent;
            auto2.BackColor = Color.Transparent;
            label7.Text = "X 0";
            stit.Hide();
            pok.Hide();
            pb.Hide();
            odebata1.Hide();
            odebata2.Hide();
            odebata3.Hide();
            odebata4.Hide();
            label1.Hide();
            novcic1.Hide();
            novcic2.Hide();
            novcic3.Hide();
            novcic4.Hide();
            auto2.Hide();
            pb2.Hide();
            leva.Width = 10;
            leva.Height = ClientSize.Height;
            desna.Width = 10;
            desna.Height = ClientSize.Height;
            rp.Location = new Point(ClientSize.Width / 2 - rp.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 2.315));
            desna.Location = new Point(ClientSize.Width - 10, 0);
            label1.Location = new Point(ClientSize.Width / 2 - label1.Size.Width / 2, ClientSize.Height / 10);
            label2.Location = new Point(ClientSize.Width / 2 - label2.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 3.125));
            label6.Location = new Point(ClientSize.Width / 2 - label6.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 2.315));
            label3.Location = new Point(ClientSize.Width / 2 - label3.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.525));
            label5.Location = new Point(ClientSize.Width / 2 - label5.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.84));
            pictureBox3.Location = new Point(ClientSize.Width / 2 - pictureBox3.Size.Width / 2, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(ClientSize.Width / 2 - pictureBox4.Size.Width / 2, pictureBox4.Location.Y);
            pictureBox5.Location = new Point(ClientSize.Width / 2 - pictureBox5.Size.Width / 2, pictureBox5.Location.Y);
            pictureBox6.Location = new Point(ClientSize.Width / 2 - pictureBox6.Size.Width / 2, pictureBox6.Location.Y);
            pictureBox7.Location = new Point(ClientSize.Width / 2 - pictureBox7.Size.Width / 2, pictureBox7.Location.Y);
            pictureBox9.Location = new Point(ClientSize.Width / 2 - pictureBox9.Size.Width / 2, pictureBox9.Location.Y);
            pictureBox3.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox4.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox5.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox6.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox7.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            pictureBox9.Size = new Size(ClientSize.Width / 50, ClientSize.Height / 10);
            auto.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8);
            auto.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28));
            odebata1.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata3.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            odebata4.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
            if (i > 0)
            {
                odebata1.Location = new Point(ClientSize.Width / 10, ClientSize.Height / 10);
                odebata2.Location = new Point(ClientSize.Width / 4, Convert.ToInt32(ClientSize.Height / 1.86));
                odebata3.Location = new Point(Convert.ToInt32(ClientSize.Height / 1.67), Convert.ToInt32(ClientSize.Height / 3.84));
                odebata4.Location = new Point(Convert.ToInt32(ClientSize.Height / 1.27), Convert.ToInt32(ClientSize.Height / 1.67));
            }
            rezu1.Location = new Point(ClientSize.Width - desna.Size.Width - label7.Size.Width - rezu2.Size.Width, 3);
            rezu1.Size = new Size(Convert.ToInt32(ClientSize.Width / 8.51), Convert.ToInt32(ClientSize.Width / 8.51));
            rezu2.Size = new Size(Convert.ToInt32(ClientSize.Width / 8.51), Convert.ToInt32(ClientSize.Width / 8.51));
            label7.Location = new Point(Convert.ToInt32(ClientSize.Width - desna.Size.Width - label7.Size.Width), rezu2.Size.Height / 2 - label7.Size.Height / 2);
            auto2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 8);
            novcic1.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic2.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic3.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            novcic4.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            stit.Size = new Size(Convert.ToInt32(ClientSize.Width / 14.28), Convert.ToInt32(ClientSize.Width / 14.28));
            label4.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 33.333333));
            label3.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label2.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label1.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label6.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            label7.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 33.33333));
            label5.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 16.67));
            if (a == 0)
            {
                pb.Location = new Point(ClientSize.Width / 2 - auto.Size.Width / 2, Convert.ToInt32(ClientSize.Height / 1.28 + auto.Size.Height));
            }   
            pb.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
            if (a == 2)
            {

                pb2.Location = new Point(Convert.ToInt32(ClientSize.Width / 2.78), Convert.ToInt32(ClientSize.Height / 1.11));
                pb.Location = new Point(Convert.ToInt32(ClientSize.Width / 1.96), Convert.ToInt32(ClientSize.Height / 1.11));
            }
            pb.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
            pb2.Size = new Size(ClientSize.Width / 10, ClientSize.Height / 50);
            
            label4.Location = new Point(Convert.ToInt32(leva.Size.Width + rezu2.Size.Width), rezu2.Size.Height / 2 - label4.Size.Height / 2);
            label4.Hide();
            zvuk.Location = new Point(10, ClientSize.Height - zvuk.Size.Height);
            rand.Location = new Point(20 + zvuk.Size.Width, ClientSize.Height - zvuk.Size.Height);
            km.Font = new Font("Microsoft Sans Serif", Convert.ToSingle(ClientSize.Height / 33.333333));
            km.Location = new Point(ClientSize.Width - 10 - km.Size.Width, ClientSize.Height - km.Height);
            rand.BackColor = Color.Transparent;
            zvuk.BackColor = Color.Transparent;
            int n = r.Next(1, 4);
           
            switch (n)
            {
                case 1: zika.Play(); sp = 1; break;
                case 2: zika2.Play(); sp = 2; break;
                case 3: zika3.Play(); sp = 3; break;
                default: zika.Play(); sp = 1; break;
            }
        }

        private void zvuk_Click(object sender, EventArgs e)
        {
            if (mz % 2 == 0)
            {
                switch (sp)
                {
                    case 1: zika.Stop(); break;
                    case 2: zika2.Stop(); break;
                    case 3: zika3.Stop(); break;
                    default: zika.Stop(); break;
                }
                zvuk.Image = Resource1.soff;
                mz++;
            }
            else
            {
                switch (sp)
                {
                    case 1: zika.Play(); break;
                    case 2: zika2.Play(); break;
                    case 3: zika3.Play(); break;
                    default: zika.Play(); break;
                }
                zvuk.Image = Resource1.son;
                mz++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sp == 1)
                sp = 2;
            else
            {
                if (sp == 2)
                    sp = 3;
                else
                {
                    if (sp == 3)
                        sp = 1;
                }
            }
            switch (sp)
            {
                case 1: zika.Play(); break;
                case 2: zika2.Play(); break;
                case 3: zika3.Play(); break;
                default: zika.Play(); break;
            }
        }

        private void rp_Click(object sender, EventArgs e)
        {
            ik = 0;
            timer1.Start();
            rp.Hide();
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
        }

        
    }
}