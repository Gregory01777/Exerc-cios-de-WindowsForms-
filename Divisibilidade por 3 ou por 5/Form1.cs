using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisibilidade_por_3_ou_por_5
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

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(textBox1.Text);

            if (valor1 % 3 == 0 && valor1 % 5 == 0)
            {
                label3.Text = "O número é divisível por 3 e por 5.";
            }
            else if (valor1 % 3 == 0)
            {
                label3.Text = "O número é divisível por 3.";
            }
            else if (valor1 % 5 == 0)
            {
                label3.Text = "O número é divisível por 5.";
            }
            else
            {
                label3.Text = "O número não é divisível nem por 3 nem por 5.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
