using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maior_entre_Três_Números
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(textBox1.Text);
            int valor2 = Convert.ToInt32(textBox2.Text);
            int valor3 = Convert.ToInt32(textBox4.Text);

            int maior;
            if (valor1 > valor2 && valor1 > valor3)
            {
                maior = valor1;
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                maior = valor2;
            }
            else
            {
                maior = valor3;
            }
            label5.Text = $"O maior número digitado foi: {maior}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
