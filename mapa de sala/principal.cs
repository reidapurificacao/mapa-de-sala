﻿using System;
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
            MessageBox.Show("Ola Mundo");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("hello word");
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void btmconfirmar_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("entrei no botao");

        }
    }
}
