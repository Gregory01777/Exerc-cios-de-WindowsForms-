using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualificação_para_vaga
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string possuiDiploma = textBox1.Text.Trim().ToLower();

            if (int.TryParse(textBox2.Text, out int idade))
            {
                if (possuiDiploma == "sim" && idade > 21)
                {
                    label4.Text = "Parabéns, você está qualificado para a vaga!";
                    label4.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    label4.Text = "Infelizmente você não atende aos requisitos mínimos.";
                    label4.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
          
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
