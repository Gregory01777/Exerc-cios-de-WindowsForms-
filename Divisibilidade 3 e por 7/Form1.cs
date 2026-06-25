using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisibilidade_3_e_por_7
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

            int numero = Convert.ToInt32(textBox1.Text);
            if (numero % 3 == 0 && numero % 7 == 0)
            {
                label2.Text = $"O número {numero} é divisível por 3 e por 7.";
            }
            else
            {
                label2.Text = $"O número {numero} NÃO é divisível por 3 e por 7 ao mesmo tempo.";
            }
        }
    }
}
