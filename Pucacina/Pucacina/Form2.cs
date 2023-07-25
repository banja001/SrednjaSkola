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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 stara = (Form1)this.Owner;
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pb1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            loop1.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            //reload.BackColor = Color.Transparent;
            this.Text = "Help";
            this.Cursor = nov((Bitmap)Resource1.ada, new Size(50, 50));
        }
        public static Cursor nov(Bitmap b, Size s)
        {
            b = new Bitmap(b, s);
            return new Cursor(b.GetHicon());
        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reload_MouseHover(object sender, EventArgs e)
        {
            reload.Cursor = nov((Bitmap)Resource1.ada, new Size(50, 50));
        }
    }
}
