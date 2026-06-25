using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Nota1._0
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(textBox2.Text);
            double nota2 = Convert.ToDouble(textBox3.Text);
            double nota3 = Convert.ToDouble(textBox4.Text);
            string nome = textBox1.Text;
           
            double resultado = (nota1 + nota2 + nota3) / 3;

            if (resultado >= 7)
            {
                label6.Text = "Parabens, " + nome + " você foi aprovado com uma media de :" + resultado;
            }
            else if (resultado >= 5.10 && resultado <= 6.90)
            {
                label6.Text = "O aluno " + nome + " esta de recuperação com uma media de :" + resultado;
            }
            else       
            {
                label6.Text = "Infelizzmente o aluno " + nome + "foi reprovado com uma media de :" + resultado;
            }
                
        
        }
    }
}
