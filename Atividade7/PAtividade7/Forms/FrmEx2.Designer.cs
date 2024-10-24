namespace PAtividade7.Forms
{
    partial class FrmEx2
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
            components = new System.ComponentModel.Container();
            txtBoxNumN = new TextBox();
            lblNumH = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxNumN
            // 
            txtBoxNumN.Location = new Point(157, 104);
            txtBoxNumN.Name = "txtBoxNumN";
            txtBoxNumN.Size = new Size(454, 31);
            txtBoxNumN.TabIndex = 0;
            // 
            // lblNumH
            // 
            lblNumH.AutoSize = true;
            lblNumH.Location = new Point(349, 57);
            lblNumH.Name = "lblNumH";
            lblNumH.Size = new Size(95, 25);
            lblNumH.TabIndex = 1;
            lblNumH.Text = "Número N";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(310, 302);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(178, 79);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular H";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += BtnCalcular_Click;
            // 
            // FrmEx2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblNumH);
            Controls.Add(txtBoxNumN);
            Name = "FrmEx2";
            Text = "FrmEx2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNumN;
        private Label lblNumH;
        private ErrorProvider errorProvider1;
        private Button btnCalcular;
    }
}