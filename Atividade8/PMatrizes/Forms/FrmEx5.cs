using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMatrizes.Forms
{
    public partial class FrmEx5 : Form
    {
        public FrmEx5()
        {
            InitializeComponent();
        }

        enum Alternativa
        {
            A,
            B,
            C,
            D,
            E
        }

        Alternativa[] gabarito = [Alternativa.A, Alternativa.B, Alternativa.E, Alternativa.D, Alternativa.C, Alternativa.E, Alternativa.D, Alternativa.A, Alternativa.B, Alternativa.C];

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Alternativa[,] alternativas = new Alternativa[8,10];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string alternativa = Interaction.InputBox($"Digite a nota {i + 1} do aluno {j + 1}", "Entrada de Dados");

                    switch (alternativa[0])
                    {
                        case 'A':
                            alternativas[i, j] = Alternativa.A;
                            break;
                        case 'B':
                            alternativas[i, j] = Alternativa.B;
                            break;
                        case 'C':
                            alternativas[i, j] = Alternativa.C;
                            break;
                        case 'D':
                            alternativas[i, j] = Alternativa.D;
                            break;
                        case 'E':
                            alternativas[i, j] = Alternativa.A;
                            break;
                    }
                }
            }

            
        }
    }
}
