using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra_de_carro_novo
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

        private void button1_Click(object sender, EventArgs e)
        
        {
          
            string desejaComprar = textBox1.Text.ToLower().Trim();
            string temDinheiro = textBox2.Text.ToLower().Trim();

           
            if (desejaComprar == "sim" && temDinheiro == "sim")
            {
                label4.Text = "Parabéns, você pode comprar um carro novo!";
            }
            else
            {
                label4.Text = "Não é possível realizar a compra.";
            }
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
