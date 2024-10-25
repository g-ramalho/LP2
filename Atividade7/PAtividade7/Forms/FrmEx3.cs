﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade7
{
    public partial class FrmEx3 : Form
    {
        public FrmEx3()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text.Trim().Replace(" ", "").ToUpper(); 

            char[] vetor = texto.ToCharArray(); 

            Array.Reverse(vetor); 

            string textoInvertido = new string(vetor); 

            if (textoInvertido.Equals(texto)) 
            {
                MessageBox.Show("É um Palíndromo");
            }
            else
            {
                MessageBox.Show("Não é um Palíndromo");
            }
        }
    }
}
