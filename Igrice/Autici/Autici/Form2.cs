using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Autici
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1 stara = (Form1)this.Owner;
            this.Text = "Score";
        }
        public int sicko = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ime.Text == "")
                MessageBox.Show("Wrong name! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Close();
                sicko = 1;
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ime.Text == "")
                    MessageBox.Show("Wrong name! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.Close();
                    sicko = 1;
                }
            }
        }

        private void button1_ClientSizeChanged(object sender, EventArgs e)
        {
            

        }

        private void Form2_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(370, 250);
        }
    }
}
