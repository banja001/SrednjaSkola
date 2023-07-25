using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            kori.Focus();
        }
        public string kor;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 stra = new Form1();
            kor = kori.Text;
            StreamReader sr = new StreamReader("lekari.txt");
            string s = "";
            int i = 0;
            while (s != null)
            {
                s = sr.ReadLine();
                if (s == kori.Text)
                {
                    s = sr.ReadLine();
                    if (s == loz.Text)
                    {
                        MessageBox.Show("Dobrodosli "+kor+"!");
                        i = 1;
                    }
                }
            }
            sr.Close();
            if (i == 0)
            {
                MessageBox.Show("Netacno korisnicko ime ili lozinka!");
            }
            else
            {
                stra.a = kori.Text;
                loz.Text = "";
                stra.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            logo.Location = new Point(ClientSize.Width / 2 - logo.Size.Width / 2, 15);
            lkori.Location = new Point(ClientSize.Width / 2 - lkori.Size.Width / 2 - kori.Size.Width, 90);
            kori.Location = new Point(ClientSize.Width / 2 - kori.Size.Width / 2, 100);
            lloz.Location = new Point(ClientSize.Width / 2 - lkori.Size.Width / 2 - loz.Size.Width, 130);
            loz.Location = new Point(ClientSize.Width / 2 - loz.Size.Width / 2, 140);
            log.Location = new Point(ClientSize.Width / 2 - log.Size.Width / 2, 200);
            logo.BackColor = Color.Transparent;
            log.BackColor = Color.FromArgb(32, 50, 99);
            this.Top = Screen.PrimaryScreen.WorkingArea.Top / 2+ClientSize.Height/2;
            
        }
    }
}
