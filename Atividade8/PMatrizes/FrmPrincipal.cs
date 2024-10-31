using Microsoft.VisualBasic;
using System.Collections;

namespace PMatrizes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFrm<T>(T form) where T : Form
        {
            if (Application.OpenForms.OfType<T>().Count() > 0)
            {
                form.BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            int[] vet = new int[20];

            string aux = new("");

            for (int i = 0; i < vet.Length; i++)
            {

                while (!int.TryParse(Interaction.InputBox($"Digite o número {i + 1}", "Entrada de Dados"), out vet[i]))
                {
                    errorProvider1.SetError(this, "O texto inserido não pode ser convertido para número");
                }

                aux = vet[i].ToString() + '\n' + aux;
            }

            MessageBox.Show(aux);
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            ArrayList alunos = ["Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio",
                                "Marcelo", "Pedro", "Thais"];

            alunos.Remove("Otávio");

            MessageBox.Show(string.Join(',', alunos.ToArray()));
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] medias = new double[20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    while (!double.TryParse(Interaction.InputBox($"Digite a nota {j + 1} do aluno {i + 1}", "Entrada de Dados"), out notas[i, j]))
                    {
                        errorProvider1.SetError(this, "O texto inserido não pode ser convertido para número");
                    }
                }
                medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
            }

            string aux = "";

            for (int k = 0; k < 20; k++)
            {
                aux += $"Média do aluno {k + 1} = {medias[k]}\n";
            }

            MessageBox.Show(aux);
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            ArrayList nomes = [];

            string aux = "";

            ListBox lstBoxSaida = new ListBox();

            for (int i = 0; i < 10; i++)
            {
                string nome = Interaction.InputBox($"Digite o nome completo de uma pessoa", "Entrada de Dados");

                nomes.Add(nome);

                int count = 0;

                foreach (char c in nome)
                {
                    if (Char.IsLetter(c))
                    {
                        count++;
                    }
                }

                aux += $"O nome: \"{nome}\" contém {count} caracteres";

                lstBoxSaida.Items.Add(aux);
            }

            MessageBox.Show(lstBoxSaida.Text);
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            AbrirFrm(new Forms.FrmEx5());
        }
    }
}
