using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Oblik[] o;
        Random r = new Random();
        float p = 0;
        float O = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
            int n = Convert.ToInt32(numericUpDown1.Value);
            if (n == 0)
                this.Text = "Ukupna povrsina je 0 , a obim je 0";
            o = new Oblik[n];
            p = 0;
            O = 0;
            for (int i = 0; i < n; i++)
            {
                int t = r.Next(1, 3);
                Color boja = new Color();
                boja = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                Point centar=new Point(r.Next(0,pictureBox1.Size.Width-100),r.Next(0,pictureBox1.Size.Height-100));
                switch (t)
                {
                    case 1:
                        {
                            o[i] = new Krug(boja, centar, r.Next(10, 50));
                            p = p + o[i].Povrsina;
                            O = O + o[i].Obim;
                        } break;
                    case 2:
                        {
                            o[i] = new Kvadrat(boja, centar, r.Next(10, 50), r.Next(10, 50));
                            p = p + o[i].Povrsina;
                            O = O + o[i].Obim;
                            
                        } break;
                    default:
                        { } break;
                }
                o[i].Crtanje(pictureBox1.CreateGraphics());
                
               
                this.Text = "Ukupna povrsina je " + p.ToString("0.00") + " , a obim je " + O.ToString("0.00");
            }
        }
    }
    public abstract class Oblik
    {
        protected Color boja;
        protected Point centar;
        public Oblik(Color boja, Point centar)
        {
            this.boja = boja;
            this.centar = centar;
        }
        public Oblik()
        {
            this.boja = Color.FromArgb(0,0,0);
            this.centar = new Point(0,0);
        }
        public abstract float Obim
        {
            get;
        }
        public abstract float Povrsina
        {
            get;
        }
        public abstract void Crtanje(Graphics g);
    }
    public class Kvadrat : Oblik
    {
        protected float a, b;
        public Kvadrat(Color boja, Point centar, float a, float b)
            : base(boja, centar)
        {
            this.a = a;
            this.b = b;
            this.centar = centar;
            this.boja = boja;
        }
        public Kvadrat():base()
        {
            this.a = 0;
            this.b = 0;
            this.centar = new Point(0,0);
            this.boja = Color.Black;
        }
        public override float Obim
        {
            get {return 2*a+2*b; }
        }
        public override float Povrsina
        {
            get { return a * b; }
        }
        public override void Crtanje(Graphics g)
        {
            SolidBrush s= new SolidBrush(boja);
            g.FillRectangle(s, centar.X + a / 2, centar.Y + b / 2, a, b);
        }
    }
    public class Krug : Oblik
    {
        protected float r;
        public Krug(Color boja, Point centar, float r)
            : base(boja, centar)
        {
            this.r = r;
            this.centar = centar;
            this.boja = boja;
        }
        public Krug():base()
        {
            this.r = 0;
            this.centar = new Point(0,0);
            this.boja = Color.Black;
        }
        public override float Obim
        {
            get { return Convert.ToSingle(2 * r * Math.PI); }
        }
        public override float Povrsina
        {
            get { return Convert.ToSingle(r*r*Math.PI); }
        }
        public override void Crtanje(Graphics g)
        {
            SolidBrush s = new SolidBrush(boja);
            g.FillEllipse(s, centar.X + r, centar.Y + r, r, r);
        }
    }
}
     