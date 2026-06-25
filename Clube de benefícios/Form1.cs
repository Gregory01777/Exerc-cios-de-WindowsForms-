using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clube_de_benefícios
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
            string resposta = textBox1.Text.Trim().ToLower();

            if (resposta == "não" || resposta == "nao")
            {
                label2.Text = "Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube.";
            }
            else if (resposta == "sim")
            {
                label2.Text = "Inscrição ativa! Aproveite os benefícios.";
            }
            else
            {
                label2.Text = "Por favor, responda com 'sim' ou 'não'.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
