using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_SoftwareArch_GUI
{
    public partial class Form1 : Form
    {
        int m, n, p;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = uxTextBox.Text;
            m = Int32.Parse(s);

            // how to generate random numbers:
            Random r = new Random();
            int min = 0;
            int max = 10;
            n = r.Next(min, max + 1);

            uxRandom.Text = n.ToString();
        }

        private void uxNext_Click(object sender, EventArgs e)
        {
            string x = uxTextBoxP.Text;
            p = Int32.Parse(x);
            if (m + n + p == 10)
            {
                MessageBox.Show("You win!");
            }
            else
            {
                MessageBox.Show("You lose!");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uxTextBoxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
    }