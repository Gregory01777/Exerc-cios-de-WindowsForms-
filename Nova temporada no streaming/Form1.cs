using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_temporada_no_streaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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
            string ehAssinante = textBox1.Text.Trim().ToLower();
            string jaAssistiu = textBox2.Text.Trim().ToLower();

            
            if (ehAssinante == "sim" && jaAssistiu == "sim")
            {
                label4.Text = "Ótimo, agora você pode assistir à nova temporada!";
                label4.ForeColor = System.Drawing.Color.Green; 
            }
            else
            {
                label4.Text = "Para acessar, você precisa ser assinante e ter assistido serie antes.";
                label4.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
