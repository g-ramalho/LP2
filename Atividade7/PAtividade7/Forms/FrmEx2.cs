using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAtividade7.Forms
{
    public partial class FrmEx2 : Form
    {
        public FrmEx2()
        {
            InitializeComponent();
        }

        int numN = 0;

        private bool ValidarNumN(System.Windows.Forms.TextBox txtBox, out int num)
        {
            if (!int.TryParse(txtBox.Text, out num))
            {
                errorProvider1.SetError(txtBoxNumN, "O texto inserido não é um número");
            }

            if (num <= 0)
            {
                errorProvider1.SetError(txtBoxNumN, "O número deve ser maior que 0");
            }

            errorProvider1.SetError(txtBox, "");

            return true;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarNumN(txtBoxNumN, out numN)) return;

            double numH = 1;

            for (int i = 2; i <= numN; i++)
            {
                numH += 1.0 / i;
            }

            MessageBox.Show(numH.ToString());
        }
    }
}
