using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confirmação_de_compra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resposta = textBox1.Text;
            if (resposta.ToLower() == "sim" || resposta.ToLower() == "s")
            {
                label2.Text = "Compra confirmada!";
            }
            else if (resposta.ToLower() == "não" || resposta.ToLower() == "nao")
            {
                label2.Text = "Compra cancelada.";
            }
            else
            {
                label2.Text = "Resposta inválida. Por favor, digite 'sim' ou 'não'.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
