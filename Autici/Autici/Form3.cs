using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Autici
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Form1 stara = (Form1)this.Owner;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 stara = (Form1)this.Owner;
            stara.niz = stara.raz();
            stara.sad = stara.nik();
            Array.Sort(stara.niz);
            Array.Reverse(stara.niz);
            /*int jo = 0;
            for (int o = 0; o < 10; o++)
            {
                if (i == jot)

                    sr.WriteLine((o + 1).ToString() + ". " + imena + "," + niz[o].ToString("000"));

                else
                {
                    sr.WriteLine((o + 1).ToString() + ". " + sad[jo] + "," + niz[o].ToString("000"));
                    jo++;
                }
            }*/
                for (int i = 0; i < 10; i++)
                {
                    string sa="";
                    string saa = "";
                    if (i == stara.jot)
                    {
                        sa = (i + 1).ToString() + ". " + stara.imena;
                        saa = stara.niz[i].ToString();
                    }
                    else
                    {
                        sa = (i + 1).ToString() + ". " + stara.sad[i];
                        saa = stara.niz[i].ToString();
                    }
                    label6.Text += sa+"\n";
                    label7.Text += saa + "\n";
                }
            
            /*

            label1.Text = reader.ReadToEnd();

            reader.Close();
            for (int i = 0; i < 10; i++)
            {
                label1.Text += stara.sad[i]+"\n";
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form3_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(530,510);
        }
    }
}
