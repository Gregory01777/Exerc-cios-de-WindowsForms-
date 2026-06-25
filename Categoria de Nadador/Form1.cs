using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categoria_de_Nadador
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
  
            if (!int.TryParse(textBox2.Text, out int idade1))
            {
                label4.Text = "Idade inválida";
                return;
            }

            if (idade1 >= 5 && idade1 <= 7)
            {
                label4.Text = "Categoria Infantil A";
            }
            else if (idade1 >= 8 && idade1 <= 10)
            {
                label4.Text = "Categoria Infantil B";
            }
            else if (idade1 >= 11 && idade1 <= 13)
            {
                label4.Text = "Categoria Juvenil A";
            }
            else if (idade1 >= 14 && idade1 <= 17)
            {
                label4.Text = "Categoria Juvenil B";
            }
            else
            {
                label4.Text = "Senior";
            }
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
