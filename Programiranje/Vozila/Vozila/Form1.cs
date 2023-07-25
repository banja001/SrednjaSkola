using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vozila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Vozila
        {
            protected int x, y, a, b, dx;
            protected Color boja;
            public Vozila()
            {
                this.a = 0;
                this.b = 0;
                this.x = 0;
                this.y = 0;
                this.boja = Color.White;
            }
            public Vozila(int a, int b, int x, int y, Color boja)
            {
                this.boja = boja;
                this.x = x;
                this.y = y;
                this.a = a;
                this.b = b;
            }
            public void Pokreni(int dx)
            {
                this.dx = dx;
            }
            public void Stop()
            {
                this.dx = 0;
            }
            public void Pomeri()
            {
                x += dx;
            }
            abstract public void Crtaj(Graphics g);
        }
        public class Auto : Vozila
        {
            public Auto(int x, int y, int a, int b, Color boja)
                : base(a, b, x, y, boja)
            { }
            public override void Crtaj(Graphics g)
            {
                SolidBrush cetka = new SolidBrush(boja);
                Pen olovka = new Pen(Color.Black);
                g.FillRectangle(cetka, x - a / 4, y - b / 2, a / 2, b / 2);
                g.FillRectangle(cetka, x - a / 2, y, a, b / 2);
                g.DrawLine(olovka, x - a / 4, y - b / 2, x + a / 4, y - b / 2);
                g.DrawLine(olovka, x - a / 2, y + b / 2, x + a / 2, y + b / 2);
                g.DrawLine(olovka, x - a / 2, y, x - a / 4, y);
                g.DrawLine(olovka, x + a / 2, y, x + a / 4, y);
                g.DrawLine(olovka, x - a / 2, y, x - a / 2, y + b / 2);
                g.DrawLine(olovka, x + a / 2, y, x + a / 2, y + b / 2);
                g.DrawLine(olovka, x - a / 4, y, x - a / 4, y - b / 2);
                g.DrawLine(olovka, x + a / 4, y, x + a / 4, y - b / 2);
                cetka.Color = Color.Black;
                g.FillEllipse(cetka, x - a / 4 - a / 6, y + b / 2 - a / 6, a / 3, a / 3);
                g.FillEllipse(cetka, x + a / 4 - a / 6, y + b / 2 - a / 6, a / 3, a / 3);

            }
        }
        public class Autobus : Vozila
        {
            public Autobus(int x, int y, int a, int b, Color boja)
                : base(x, y, a, b, boja)
            {
            }
            public override void Crtaj(Graphics g)
            {
                SolidBrush cetka = new SolidBrush(boja);
                Pen olovka = new Pen(Color.Black);
                g.FillRectangle(cetka, x - 2 * a / 3, y - b / 2, 4 * a / 3, b);
                g.DrawRectangle(olovka, x - 2 * a / 3, y - b / 2, 4 * a / 3, b);
                cetka.Color = Color.LightBlue;
                g.FillRectangle(cetka, x - 2 * a / 3 + a / 10, y - b / 2 + b / 10, 4 * a / 3 - a / 5, b / 2);
                g.DrawRectangle(olovka, x - 2 * a / 3 + a / 10, y - b / 2 + b / 10, 4 * a / 3 - a / 5, b / 2);
                cetka.Color = Color.Black;
                g.FillEllipse(cetka, x - a / 4 - a / 6, y + b / 2 - a / 6, a / 3, a / 3);
                g.FillEllipse(cetka, x + a / 4 - a / 6, y + b / 2 - a / 6, a / 3, a / 3);
            }
        }

        public class Kamion : Vozila
        {
            public Kamion(int x, int y, int a, int b, Color boja)
                : base(x, y, a, b, boja)
            {
            }
            public override void Crtaj(Graphics g)
            {
                SolidBrush cetka = new SolidBrush(boja);
                Pen olovka = new Pen(Color.Black);
                g.FillRectangle(cetka, x - a / 2, y - b / 2, a, b);
                g.DrawRectangle(olovka, x - a / 2, y - b / 2, a, b);
                g.DrawLine(olovka, x + a / 2, y - b / 4, x + 3 * a / 4, y - b / 4);
                g.DrawLine(olovka, x + 3 * a / 4, y - b / 4, x + a, y);
                g.DrawLine(olovka, x + a, y, x + a, y + b / 2);
                g.DrawLine(olovka, x + a, y + b / 2, x + a / 2, y + b / 2);
                cetka.Color = Color.Black;
                g.FillEllipse(cetka, x - a / 2 + a / 6, y + b / 2 - a / 6, a / 3, a / 3);
                g.FillEllipse(cetka, x + a / 4 + a / 6, y + b / 2 - a / 6, a / 3, a / 3);
            }
        }
        Random r = new Random();
        Vozila[] vozilo = new Vozila[500];
        int n = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 60;
            int b = 40;
            for (int x = -50 * ClientRectangle.Width; x < ClientRectangle.Width; x += 2 * a)
            {
                Color boja = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                int tip = r.Next(3);
                if (tip == 0)
                    vozilo[n] = new Auto(x, pictureBox1.Height / 2,a, b,  boja);
                else if (tip == 1)
                    vozilo[n] = new Kamion(a, b, x, pictureBox1.Height / 2, boja);
                else
                    vozilo[n] = new Autobus(a, b,x, pictureBox1.Height / 2,  boja);
                n++;
            }
            for (int i = 0; i < n; i++)
                vozilo[i].Pokreni(5);
            timer1.Start();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < n; i++)
                vozilo[i].Crtaj(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                vozilo[i].Pomeri();
            }
            Refresh();
        }
    }
}

