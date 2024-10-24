using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade7.Forms
{
    public partial class FrmEx1 : Form
    {
        public FrmEx1()
        {
            InitializeComponent();
        }

        private void BtnContarEspaços_Click(object sender, EventArgs e)
        {
            String txt = richTxtBox.Text;

            int count = 0;

            for (int i = 0; i < txt.Length; i++)
            {
                if (Char.IsWhiteSpace(txt[i]))
                {
                    count++;
                }
            }

            MessageBox.Show("Contagem de espaços em branco: " + count);
        }

        private void BtnContarR_Click(object sender, EventArgs e)
        {
            String txt = richTxtBox.Text.ToLower();

            int count = 0;

            foreach (char c in txt)
            {
                if (c == 'r')
                {
                    count += 1;
                }
            }

            MessageBox.Show("Contagem de letras R: " + count);
        }

        private void BtnContarPares_Click(object sender, EventArgs e)
        {
            String txt = richTxtBox.Text;

            int count = 0;

            bool lastCharWasEqual = false;

            int i = txt.Length - 1;
            while (i > 0)
            {
                if (txt[i] == txt[i-1] && !lastCharWasEqual)
                {
                    count ++;
                    lastCharWasEqual = true;
                } else
                {
                    lastCharWasEqual = false;
                }
                i--;
            }

            MessageBox.Show("Contagem de pares de letras repetidas: " + count);
        }
    }
}
