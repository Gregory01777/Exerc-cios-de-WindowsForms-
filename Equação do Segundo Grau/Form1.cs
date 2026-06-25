using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equação_do_Segundo_Grau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(textBox1.Text);
            int numero2 = Convert.ToInt32(textBox2.Text);
            int numero = Convert.ToInt32(textBox3.Text);

            if (!int.TryParse(textBox1.Text, out int a) ||
                !int.TryParse(textBox2.Text, out int b) ||
                !int.TryParse(textBox3.Text, out int c))
            {
                MessageBox.Show("Por favor, insira valores inteiros válidos para A, B e C.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (a == 0)
            {
                label5.Text = "O valor de 'A' não pode ser zero.\nNão é uma equação de 2º grau.";
                return;
            }

            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                label5.Text = $"Delta = {delta}\nA equação não possui raízes reais (Delta é negativo).";
            }
            else if (delta == 0)
            {
                double x = (double)-b / (2 * a);
                label5.Text = $"Delta = {delta}\nA equação possui uma única raiz real:\nX = {x:F2}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                label5.Text = $"Delta = {delta}\nA equação possui duas raízes reais:\n" +
                                   $"X1 = {x1:F2}\n" +
                                   $"X2 = {x2:F2}";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}


