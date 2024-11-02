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

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Alternativa[] gabarito = [Alternativa.A, Alternativa.B, Alternativa.E, Alternativa.D, Alternativa.C, Alternativa.E, Alternativa.D, Alternativa.A, Alternativa.B, Alternativa.C];

            Alternativa[,] alternativas = new Alternativa[8,10];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string alternativa = Interaction.InputBox($"Digite a alternativa da questão {j + 1} para o aluno {i + 1}", "Entrada de Dados");

                    if (!String.IsNullOrEmpty(alternativa))
                    {
                        switch (alternativa[0])
                        {
                            case 'A':
                            case 'a':
                                alternativas[i, j] = Alternativa.A;
                                break;
                            case 'B':
                            case 'b':
                                alternativas[i, j] = Alternativa.B;
                                break;
                            case 'C':
                            case 'c':
                                alternativas[i, j] = Alternativa.C;
                                break;
                            case 'D':
                            case 'd':
                                alternativas[i, j] = Alternativa.D;
                                break;
                            case 'E':
                            case 'e':
                                alternativas[i, j] = Alternativa.A;
                                break;
                            default:
                                j--;
                                break;
                        }
                    } else
                    {
                        j--;
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0;j < 10; j++)
                {
                    string aux = "";

                    if (gabarito[j] == alternativas[i,j])
                    {
                        aux += $"O aluno {i + 1} acertou ";
                    } else
                    {
                        aux += $"O aluno {i + 1} errou ";
                    }

                    aux += $"questão {j + 1}: era {gabarito[j]} escolheu {alternativas[i, j]}";

                    lstBoxSaida.Items.Add(aux);
                }
            }
        }
    }
}
