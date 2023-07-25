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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        bool b = false;
        List<string> lekovi = new List<string>();
        public string a;
        int cena=0,dan;
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                lekovi.Add(comboBox1.SelectedItem.ToString());
                listBox1.Items.Add(comboBox1.SelectedItem.ToString());
                if (comboBox1.SelectedItem == "Povidon jod(7.5%)")
                    cena += 106;
                if (comboBox1.SelectedItem == "Alkohol(70%)")
                    cena += 152;
                if (comboBox1.SelectedItem == "Bensedin")
                    cena += 209;
                if (comboBox1.SelectedItem == "Bromazepam")
                    cena += 464;
                if (comboBox1.SelectedItem == "Diazepam")
                    cena += 83;
                if (comboBox1.SelectedItem == "Glaumol")
                    cena += 167;
                if (comboBox1.SelectedItem == "Kaletra")
                    cena += 325;
                if (comboBox1.SelectedItem == "Lemod")
                    cena += 49;
                if (comboBox1.SelectedItem == "Medrol")
                    cena += 139;
                if (comboBox1.SelectedItem == "Nirmin")
                    cena += 321;
                if (comboBox1.SelectedItem == "Panklav")
                    cena += 132;
                if (comboBox1.SelectedItem == "Runac")
                    cena += 456;
                if (comboBox1.SelectedItem == "Salofalk")
                    cena += 97;
                if (comboBox1.SelectedItem == "Tilzem")
                    cena += 78;
                if (comboBox1.SelectedItem == "Zaxan")
                    cena += 172;
                if (comboBox1.SelectedItem == "Omeprol")
                    cena += 138;
                if (comboBox1.SelectedItem == "Hidrogen(3%)")
                    cena += 51;
            } 
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = true;
            StreamWriter sw = new StreamWriter(a + ".txt", true);
            sw.WriteLine("LEKOVI: ");
            foreach(object x in lekovi)
            sw.WriteLine(x.ToString());
            sw.WriteLine("Racun: " + cena.ToString() + "RSD");
            sw.WriteLine("------------------------");
            sw.Close();
            string uku = "";
            foreach (string x in lekovi)
            {
                uku += x+": " ;
                if (x == "Povidon jod(7.5%)")
                    uku += 106+ " RSD\n";
                if (x == "Alkohol(70%)")
                    uku += 152 + " RSD\n";
                if (x == "Bensedin")
                    uku += 209 + " RSD\n";
                if (x == "Bromazepam")
                    uku += 464 + " RSD\n";
                if (x == "Diazepam")
                    uku += 83 + " RSD\n";
                if (x == "Glaumol")
                    uku += 167 + " RSD\n";
                if (x == "Kaletra")
                    uku += 325 + " RSD\n";
                if (x == "Lemod")
                    uku += 49 + " RSD\n";
                if (x == "Medrol")
                    uku += 139 + " RSD\n";
                if (x == "Nirmin")
                    uku += 321 + " RSD\n";
                if (x == "Panklav")
                    uku += 132 + " RSD\n";
                if (x == "Runac")
                    uku += 456 + " RSD\n";
                if (x == "Salofalk")
                    uku += 97 + " RSD\n"; 
                if (x == "Tilzem")
                    uku += 78 + " RSD\n";
                if (x == "Zaxan")
                    uku += 172 + " RSD\n"; ;
                if (x == "Omeprol")
                    uku += 138 + " RSD\n";
                if (x == "Hidrogen(3%)")
                    uku += 51 + " RSD\n";
                
            }
           label8.Text= "Broj dana boravka: "+dan.ToString()+"\nCena po jednom danu: 1500 RSD"+"\nCena boravka: "+(dan*1500)+" RSD"+"\nUpotrebljeni lekovi:\n"+uku+"\nSveukupna cena: "+cena+" RSD";
           listBox1.Items.Clear();
           lekovi.Clear();
           cena = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string da="";
            Form2 prvi = new Form2();
            Pacijent p=new Pacijent();
            p.Ime=textBox1.Text;
            p.Prezime=textBox2.Text;
            try
            {
                p.Jmbg =textBox3.Text;
            }
            catch 
            {
                MessageBox.Show("Pogresno uneti podaci JMBG-a!");
            }
            p.Adresa=textBox4.Text;
            p.Dupis=monthCalendar1.SelectionStart;
            p.Dispis=monthCalendar2.SelectionStart;
            label6.Text = textBox1.Text + " " + textBox2.Text;
            label6.Location = new Point(this.ClientSize.Width / 2 - label6.Width / 2, 5);
            if (checkBox1.Checked)
            {
                b = true;
                da="Da";
            }
            else
            {
                b = false;
                da="Ne";
            }
            cena += p.Dani(b) * 1500;
            dan = p.Dani(b);
            if (p.Prom==6)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                StreamWriter sw = new StreamWriter(a + ".txt", true);
                sw.WriteLine("Ime: " + p.Ime);
                sw.WriteLine("Prezime: " + p.Prezime);
                sw.WriteLine("JMBG: " + p.Jmbg);
                sw.WriteLine("Adresa: " + p.Adresa);
                sw.WriteLine("Datum dolaska: " + p.Dupis.ToShortDateString());
                sw.WriteLine("Datum odlaska: " + p.Dispis.ToShortDateString());
                sw.WriteLine("Otisao pre 12h: " + da);
                sw.WriteLine("Ukupno dana: " + p.Dani(b).ToString());
                sw.Close();
                label6.Text = p.Ime + " " + p.Prezime;
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                label8.Text = "";
            }
            checkBox1.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 prvi = new Form2();
            char[] ime, prezime;
            ime = a.Split('.')[0].ToCharArray();
            prezime = a.Split('.')[1].ToCharArray();
            ime[0]=char.ToUpper(ime[0]);
            prezime[0]=char.ToUpper(prezime[0]);
            foreach (char x in ime)
               label3.Text += x;
            label3.Text += " ";
            foreach (char x in prezime)
                label3.Text += x;
            textBox1.Focus();
            button2.Enabled = false;

            button4.Enabled = false;

            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    public class Pacijent
    {
        private string ime;
        private string prezime;
        private string adresa;
        private string jmbg;
        private DateTime dupis;
        private DateTime dispis;
        private int prom;
        public Pacijent()
        { }
        public Pacijent(string ime, string prezime, string adresa, string jmbg, DateTime dupis, DateTime dispis)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.adresa = adresa;
            this.dupis = dupis;
            this.dispis = dispis;
        }
        public string Ime
        {
            get { return ime; }
            set {
                if (value == "")
                    MessageBox.Show("Ime pogresno uneto!");
                else
                {
                    ime = value;
                    prom++;
                }
            }
        }
        public string Prezime
        {
            get { return prezime; }
            set
            {
                if (value == "")
                    MessageBox.Show("Prezime pogresno uneto!");
                else
                {
                    prezime = value;
                    prom++;
                }
            }
        }
        public string Jmbg
        {
            get { return jmbg; }
            set
            {
                if (value.Length == 13)
                {
                    if (value[0] == '0')
                    {
                        double a = Convert.ToDouble(value);
                        if (a.ToString().Length == 12)
                        {
                            jmbg = value;
                            prom++;
                        }
                    }
                    else 
                    {
                        double a = Convert.ToDouble(value);
                        if(a.ToString().Length==13)
                        {
                            jmbg = value;
                            prom++;
                        }
                    }
                }
                else
                
                    MessageBox.Show("Jmbg pogresno unet!");
                
            }
        }
        public string Adresa
        {
            get { return adresa; }
            set
            {
                if (value == "")
                    MessageBox.Show("Adresa pogresno uneta!");
                else
                {
                    adresa = value;
                    prom++;
                }
            }
        }public DateTime Dispis
        {
            get { return dispis; }
            set
            {
                if (DateTime.Now >= value)
                   { 
                    dispis = value;   
                    prom++;
                   }
                else
                
                    MessageBox.Show("Pogresno uneti datumi!");
                 
            }
        }
        public DateTime Dupis
        {
            get { return dupis; }
            set
            {
                if (DateTime.Now > value)
                {
                    dupis = value;
                    prom++;
                }
                else

                    MessageBox.Show("Pogresno uneti datumi!");
                
            }
        }
        public int Prom
        {
            get { return prom; }
        }
        public string Dodaj()
        {
            return ime + " " + prezime + ", JMBG: " + jmbg + ", Adresa: " + adresa + "Datum dolaska: " + dupis.ToShortDateString() + " Datum odlaska: " + dispis.ToShortDateString();
        }
        public int Dani(bool a)
        {
            int dan,god;
            dan = dispis.DayOfYear - dupis.DayOfYear;
            god = dispis.Year - dupis.Year;
            dan += 365*god;
            if (a)
                return dan;
            else
                return dan + 1;
        }
    }
}
