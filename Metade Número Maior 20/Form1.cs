using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metade_Número_Maior_20
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
            double metade = numero % 2;
            if (numero > 20)
            {
                label3.Text = "A metade do número é : "+ metade;
            }
            else
            {
                label3.Text = "A metade do número não é maior que 20.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
