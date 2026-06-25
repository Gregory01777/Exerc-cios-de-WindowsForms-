using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconhecimento_de_usuário
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

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;

            if (usuario == "Wilson" || usuario == "Gloria")
            {
                label2.Text = "Bem-vindo de volta " + usuario + "!";

            }
            else
            {
                label2.Text = "Usuário não reconhecido.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
