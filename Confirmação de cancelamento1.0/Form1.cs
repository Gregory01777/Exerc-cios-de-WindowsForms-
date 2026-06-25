using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confirmação_de_cancelamento1._0
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

        private void verificar_Click(object sender, EventArgs e)
        {

            string resposta = textBox1.Text;

                if (resposta == "não" || resposta == "nao")
                {
                    label2.Text = "Por favor, confirme o cancelamento da operação.";
                }
                else if (resposta == "sim")
                {
                    label2.Text = "Operação mantida com sucesso!";
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
