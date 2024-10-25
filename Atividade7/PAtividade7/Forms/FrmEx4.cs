using System;
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
    public partial class FrmEx4 : Form
    {
        public FrmEx4()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int B = 0, C = 0, D = 0;
            double salariobruto;
            if (!Double.TryParse(txtSalario.Text, out double salario))
            {
                MessageBox.Show("Insira um valor válido");
                txtSalario.Text = "";
            }
            if (!int.TryParse(txtProducao.Text, out int producao))
            {
                MessageBox.Show("Insira um valor válido");
                txtProducao.Text = "";
            }
            if (!int.TryParse(txtGratificacoes.Text, out int gratificacoes))
            {
                MessageBox.Show("Insira um valor válido");
                txtGratificacoes.Text = "";
            }
            if (txtNome.Text == "")
                MessageBox.Show("Insira um valor válido");
            else
                foreach (char x in txtNome.Text)
                {
                    if (char.IsNumber(x))
                    {
                        MessageBox.Show("Insira um nome válido");
                        txtNome.Text = "";
                        break;
                    }
                }
            if (!int.TryParse(txtMatricula.Text, out int matricula))
            {
                MessageBox.Show("Insira um valor válido");
                txtMatricula.Text = "";
            }

            if (producao >= 150)
            {
                B = 1;
                C = 1;
                D = 1;
            }
            else if (producao >= 120)
            {
                B = 1;
                C = 1;
                D = 0;
            }
            else if (producao >= 100) 
            {
                B = 1;
                C = 0;
                D = 0;
            }
                

            salariobruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacoes;

            if (salariobruto > 7000)
            {
                if (!((salariobruto > 7000) && (producao >= 150) && (gratificacoes > 0)))
                {
                    salariobruto = 7000;
                }
                    
            }

            txtSalbruto.Text = salariobruto.ToString("N2");
        }
    }
}
