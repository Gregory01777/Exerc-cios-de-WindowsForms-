using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permissão_para_dirigir
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
            if (!int.TryParse(textBox1.Text, out int idade))
            {
                label3.Text = "Por favor, digite uma idade válida.";
                return;
            }

            string temCarteira = textBox2.Text.ToLower().Trim();
            
            if (idade >= 18 && temCarteira == "sim")
            {
                label3.Text = "Você pode dirigir.";
            }
            else
            {
                label3.Text = "Você NÃO pode dirigir.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
