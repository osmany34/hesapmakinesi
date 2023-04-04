using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class hesap : Form
    {
        int secim = 0;
        
        double sayi1, sayi2, sonuc;

        public hesap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 3;
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 2;
            textBox1.Text = "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           
        }

        private void Buttonlar(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }    
                
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text ="0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 1;
            textBox1.Text = "0";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") < 1)
            {
                textBox1.Text += ","; 
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                if (textBox1.Text.StartsWith("-"))
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");

                }
                else if (textBox1.Text.StartsWith(""))
                {
                    textBox1.Text = "-" + textBox1.Text;

                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 4;
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(textBox1.Text);    
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;

            }
            textBox1.Text= sonuc.ToString();

            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;

            }
            textBox1.Text = sonuc.ToString();
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;

            }
            textBox1.Text = sonuc.ToString();
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;

            }
            textBox1.Text = sonuc.ToString();
        }
    }
}
