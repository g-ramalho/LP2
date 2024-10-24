namespace PAtividade7.Forms
{
    partial class FrmEx1
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
            richTxtBox = new RichTextBox();
            btnContarEspaços = new Button();
            btnContarR = new Button();
            btnContarPares = new Button();
            SuspendLayout();
            // 
            // richTxtBox
            // 
            richTxtBox.Location = new Point(106, 56);
            richTxtBox.Name = "richTxtBox";
            richTxtBox.Size = new Size(561, 238);
            richTxtBox.TabIndex = 0;
            richTxtBox.Text = "";
            // 
            // btnContarEspaços
            // 
            btnContarEspaços.Location = new Point(106, 349);
            btnContarEspaços.Name = "btnContarEspaços";
            btnContarEspaços.Size = new Size(159, 61);
            btnContarEspaços.TabIndex = 1;
            btnContarEspaços.Text = "Contar Espaços";
            btnContarEspaços.UseVisualStyleBackColor = true;
            btnContarEspaços.Click += BtnContarEspaços_Click;
            // 
            // btnContarR
            // 
            btnContarR.Location = new Point(312, 349);
            btnContarR.Name = "btnContarR";
            btnContarR.Size = new Size(159, 61);
            btnContarR.TabIndex = 2;
            btnContarR.Text = "Contar Letras R";
            btnContarR.UseVisualStyleBackColor = true;
            btnContarR.Click += BtnContarR_Click;
            // 
            // btnContarPares
            // 
            btnContarPares.Location = new Point(508, 349);
            btnContarPares.Name = "btnContarPares";
            btnContarPares.Size = new Size(159, 61);
            btnContarPares.TabIndex = 3;
            btnContarPares.Text = "Contar Pares de Letra";
            btnContarPares.UseVisualStyleBackColor = true;
            btnContarPares.Click += BtnContarPares_Click;
            // 
            // FrmEx1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContarPares);
            Controls.Add(btnContarR);
            Controls.Add(btnContarEspaços);
            Controls.Add(richTxtBox);
            Name = "FrmEx1";
            Text = "Exercício 1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTxtBox;
        private Button btnContarEspaços;
        private Button btnContarR;
        private Button btnContarPares;
    }
}