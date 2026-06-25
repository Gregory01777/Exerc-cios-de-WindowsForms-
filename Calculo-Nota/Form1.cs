using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(textBox2.Text);
            double nota2 = Convert.ToDouble(textBox3.Text);
            double nota3 = Convert.ToDouble(textBox4.Text);
            string nome = textBox1.Text;

            double resultado;
            resultado = (nota1 + nota2 + nota3) / 3;

            if (resultado >= 7)
            {
                MessageBox.Show("Parabéns " + nome + " você foi aprovado com a média: " + resultado);

            }
            else
            {
                MessageBox.Show("Infelizmente " + nome + " você foi reprovado com a média: " + resultado);

            }
        }
    }
}

