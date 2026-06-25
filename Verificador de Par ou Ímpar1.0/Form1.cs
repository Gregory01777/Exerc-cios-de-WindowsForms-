using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificador_de_Par_ou_Ímpar1._0
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
            double valor1 = Convert.ToDouble(textBox1.Text);

            if ( valor1 % 2 == 0)
            {
                label2.Text = "O número é par.";
            }
            else
            {
                label2.Text = "O número é ímpar.";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
