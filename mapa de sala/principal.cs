using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapa_de_sala
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Nome = txtnum1.Text;
            MessageBox.Show(Nome);
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void btmconfirmar_MouseEnter(object sender, EventArgs e)
        {
            


        }

        private void txtefeito_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtnum1.Text);
            int numero2 = Convert.ToInt32(txtnum2.Text);
            int mult = numero1 * numero2;
            MessageBox.Show(mult.ToString());
        }

        private void btm5_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtnum1.Text);
            int numero2 = Convert.ToInt32(txtnum2.Text);
            int soma = numero1 + numero2;
            MessageBox.Show( soma.ToString());
        }

        private void btm4_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtnum1.Text);
            int numero2 = Convert.ToInt32(txtnum2.Text);
            int sub = numero1 - numero2;
            MessageBox.Show(sub.ToString());
        }

        private void btm3_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtnum1.Text);
            int numero2 = Convert.ToInt32(txtnum2.Text);
            int div = numero1 / numero2;
            MessageBox.Show(div.ToString());
        }
    }
}
