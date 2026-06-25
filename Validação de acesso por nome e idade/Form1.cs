using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validação_de_acesso_por_nome_e_idade
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

        private void button1_Click(object sender, EventArgs e)
        {
        
            
            string nome = textBox1.Text.Trim();

            
            if (int.TryParse(textBox2.Text, out int idade))
            {
                if (nome.Length > 3 && idade >= 18)
                {
                    label4.Text = "Acesso permitido";
                }
                else
                {
                    label4.Text = "Acesso negado";
                }
            }
            else
            {
               
                label4.Text = "Por favor, insira uma idade numérica válida. Erro";
            }
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
