namespace PMatrizes.Forms
{
    partial class FrmEx5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVerificar = new Button();
            lstBoxSaida = new ListBox();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(70, 171);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(169, 78);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lstBoxSaida
            // 
            lstBoxSaida.FormattingEnabled = true;
            lstBoxSaida.ItemHeight = 25;
            lstBoxSaida.Location = new Point(301, 32);
            lstBoxSaida.Name = "lstBoxSaida";
            lstBoxSaida.Size = new Size(457, 379);
            lstBoxSaida.TabIndex = 1;
            // 
            // FrmEx5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBoxSaida);
            Controls.Add(btnVerificar);
            Name = "FrmEx5";
            Text = "FrmEx5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerificar;
        private ListBox lstBoxSaida;
    }
}