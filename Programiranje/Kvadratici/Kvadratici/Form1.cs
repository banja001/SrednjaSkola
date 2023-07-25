using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Kvadratici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Kvadrat
        {
            private int x, y;
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            public void pomeri()
            {
                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        Kvadrat[] a = new Kvadrat[100];
        int i = 0;
        Random r = new Random();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int n=r.Next(0,20);
            a[i] = new Kvadrat();
            a[i].X = e.X + n / 2;
            a[i].Y = e.Y + n / 2;
            Pen p=new Pen(Color.Red,2);
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(p, a[i].X, a[i].Y, n, n);
        }
    }
}
