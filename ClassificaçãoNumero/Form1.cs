using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificaçãoNumero
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

       
            private void button1_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(textBox1.Text);
            if (numero > 0)
            {
                label3.Text = "O número é positivo.";
            }
            else if (numero < 0)
            {
                label3.Text = "O número é negativo.";
            }
            else
            {
                label3.Text = "O número é nulo (zero).";
            }
        }
    }
}
