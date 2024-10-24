using PAtividade7.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PAtividade7
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void OpenForm<T>(T form) where T : Form
        {
            if (Application.OpenForms.OfType<T>().Count() > 0)
            {
                form.BringToFront();
            }
            else
            {
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
        }

        private void Exerc�cio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new FrmEx1());
        }

        private void Exerc�cio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new FrmEx2());
        }

        private void Exerc�cio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new FrmEx3());
        }

        private void Exerc�cio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new FrmEx4());
        }
    }
}
