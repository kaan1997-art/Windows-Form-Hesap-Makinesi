using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHesapMakinesi1
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(tb1.Text=="0")
            {
                tb1.Text = "1";
            }
            else
            {
                tb1.Text += "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "2";
            }
            else
            {
                tb1.Text += "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "3";
            }
            else
            {
                tb1.Text += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "4";
            }
            else
            {
                tb1.Text += "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "5";
            }
            else
            {
                tb1.Text += "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "6";
            }
            else
            {
                tb1.Text += "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "7";
            }
            else
            {
                tb1.Text += "7";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "8";
            }
            else
            {
                tb1.Text += "8";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "9";
            }
            else
            {
                tb1.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "0";
            }
            else
            {
                tb1.Text += "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(tb1.Text)> 0)
            {
                tb1.Text = tb1.Text.Remove(tb1.Text.Length - 1, 1);
                if (tb1.Text.Length==0)
                {
                    tb1.Text = "0";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(tb1.Text);
            islem = "+";
            tb1.Text = tb1.Text + "+";
            tb1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(tb1.Text);
            if (islem == "+")
            {
                tb1.Text = Convert.ToString(sayi1 + sayi2);
                sonuc1.Text = "";
            }
            if (islem == "-")
            {
                tb1.Text = Convert.ToString(sayi1 - sayi2);
                sonuc1.Text = "";
            }
            if (islem == "*")
            {
                tb1.Text = Convert.ToString(sayi1 * sayi2);
                sonuc1.Text = "";
            }
            if (islem == "/")
            {
                tb1.Text = Convert.ToString(sayi1 / sayi2);
                sonuc1.Text = "";
            }
            if (islem == "yüzde")
            {
                tb1.Text = Convert.ToString(sayi1 % sayi2);
                sonuc1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(tb1.Text);
            islem = "-";
            tb1.Text = tb1.Text + "-";
            tb1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(tb1.Text);
            islem = "*";
            tb1.Text = tb1.Text + "*";
            tb1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(tb1.Text);
            islem = "/";
            tb1.Text = tb1.Text + "/";
            tb1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(tb1.Text);
            kare = Math.Pow(kare, 2);
            tb1.Text = Convert.ToString(kare);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(tb1.Text);
            karekok = Math.Sqrt(karekok);
            tb1.Text = Convert.ToString(karekok);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(tb1.Text);
            islem = "yüzde";
            sonuc1.Text = tb1.Text + "(yüzde)" ;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tb1.Text = "0";
            sonuc1.Text = "";
        }
    }
}
