using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Café_com_adicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string desejaAcucar = textBox1.Text.Trim().ToLower();
            string desejaLeite = textBox2.Text.Trim().ToLower();

         
            if (desejaAcucar == "sim" || desejaLeite == "sim")
            {
                label4.Text = "Café com adicional preparado!";
            }
            else
            {
                label4.Text = "Café simples preparado!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
