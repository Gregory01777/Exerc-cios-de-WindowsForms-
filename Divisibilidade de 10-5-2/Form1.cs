using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisibilidade_de_10_5_2
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);

            List<string> divisores = new List<string>();

            if (numero % 10 == 0)
            {
                divisores.Add("10");
            }
            if (numero % 5 == 0)
            {
                divisores.Add("5");
            }
            if (numero % 2 == 0)
            {
                divisores.Add("2");
            }


            if (divisores.Count > 0)
            {
                string resultado = string.Join(", ", divisores);
                label2.Text = $"O número {numero} é divisível por: {resultado}.";
            }
            else
            {
                label2.Text = $"O número {numero} não é divisível por 10, 5 ou 2.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
