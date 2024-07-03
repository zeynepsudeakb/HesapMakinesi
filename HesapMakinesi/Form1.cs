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