using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Mutia
{
    public partial class Form1 : Form
    {
        double angkapertama;
        string operasi;
        public Form1()
        {
            InitializeComponent();
        }

        private void angka1_Click(object sender, EventArgs e)
        {
           if(hasil.Text!= null)
            {
                hasil.Text = hasil.Text + "1";
            }
            
           else
            {
                hasil.Text = "1";
            }

        }

        private void angka2_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + "2";
            }

            else
            {
                hasil.Text = "2";
            }
        }

        private void angka3_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + "3";
            }

            else
            {
                hasil.Text = "3";
            }
        }

        private void angka4_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + "4";
            }

            else
            {
                hasil.Text = "4";
            }
        }

        private void angka5_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + "5";
            }

            else
            {
                hasil.Text = "5";
            }
        }

        private void angka6_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + "6";
            }

            else
            {
                hasil.Text = "6";
            }
        }

        private void angka7_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                /* hasil.Text = hasil.Text + "7";*/ hasil.Text += "7" ;
            }

            else
            {
                hasil.Text = "7";
            }
        }

        private void angka8_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + "8";
            }

            else
            {
                hasil.Text = "8";
            }
        }

        private void angka9_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + "9";
            }

            else
            {
                hasil.Text = "9";
            }
        }

        private void angka0_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + "0";
            }

            else
            {
                hasil.Text = "0";
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            angkapertama = Convert.ToDouble(hasil.Text);
            hasil.Text = null;
            operasi = "+";
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            angkapertama = Convert.ToDouble(hasil.Text);
            hasil.Text = null;
            operasi = "-";
        }

        private void kali_Click(object sender, EventArgs e)
        {
            angkapertama = Convert.ToDouble(hasil.Text);
            hasil.Text = null;
            operasi = "*";
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            angkapertama = Convert.ToDouble(hasil.Text);
            hasil.Text = null;
            operasi = "/";
        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            double angkakedua;
            double hasiloperasi;
            
            angkakedua = Convert.ToDouble(hasil.Text);

            if (operasi=="+")
                {                    
                hasiloperasi = (angkapertama + angkakedua);
                hasil.Text = Convert.ToString(hasiloperasi);   
                }

            if (operasi == "-")
            {
                hasiloperasi = (angkapertama - angkakedua);
                hasil.Text = Convert.ToString(hasiloperasi);
            }

            if (operasi == "*")
            {
                hasiloperasi = (angkapertama * angkakedua);
                hasil.Text = Convert.ToString(hasiloperasi);
            }

            if (operasi == "/")
            {
                hasiloperasi = (angkapertama / angkakedua);
                hasil.Text = Convert.ToString(hasiloperasi);
            }
        }

        private void titik_Click(object sender, EventArgs e)
        {
            if (hasil.Text != null)
            {
                hasil.Text = hasil.Text + ".";
            }

            else
            {
                hasil.Text = ".";
            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            hasil.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pertama;
            double kedua;
            double penjumlahan;

            pertama = Convert.ToDouble(textBox1.Text);
            kedua = Convert.ToDouble(textBox2.Text);
            penjumlahan = pertama + kedua;
            textBox3.Text = Convert.ToString(penjumlahan);
        }

    }
}
