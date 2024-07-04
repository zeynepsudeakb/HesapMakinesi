using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        string islem;
        double sonuc = 0;
        bool kontrol = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // textBox1 içeriðini temizle
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Buraya yüzde iþlemi yapýlacak kodlarý ekleyin
            // Örneðin, textBox1.Text üzerinde yüzde iþlemi yapabilirsiniz
            // Örnek bir yüzde iþlemi:
            if (double.TryParse(textBox1.Text, out double value))
            {
                double result = value / 100;
                textBox1.Text = result.ToString();
            }
        }
       
        private void button19_Click(object sender, EventArgs e)

        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double sayi = double.Parse(textBox1.Text);
                double sonuc = sayi * sayi;
                textBox1.Text = sonuc.ToString();
            }
        }






        private void button0_Click(object sender, EventArgs e)
        {
            if (kontrol)
            {
                kontrol = false;
                textBox1.Text = "";
            }
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            islem = Convert.ToString(b.Text);
            sonuc = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    textBox1.Text = (sonuc + Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (sonuc - Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (sonuc * Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (sonuc / Convert.ToDouble(textBox1.Text)).ToString();
                    break;

            }
            kontrol = true;
            sonuc = 0;

        }
    }
}