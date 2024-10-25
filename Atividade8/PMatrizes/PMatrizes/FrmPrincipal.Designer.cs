namespace PMatrizes
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnEx1 = new Button();
            btnEx2 = new Button();
            btnEx3 = new Button();
            btnEx4 = new Button();
            btnEx5 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnEx1
            // 
            btnEx1.Location = new Point(159, 56);
            btnEx1.Name = "btnEx1";
            btnEx1.Size = new Size(144, 68);
            btnEx1.TabIndex = 0;
            btnEx1.Text = "Exercício 1";
            btnEx1.UseVisualStyleBackColor = true;
            btnEx1.Click += btnEx1_Click;
            // 
            // btnEx2
            // 
            btnEx2.Location = new Point(159, 212);
            btnEx2.Name = "btnEx2";
            btnEx2.Size = new Size(144, 68);
            btnEx2.TabIndex = 1;
            btnEx2.Text = "Exercício 2";
            btnEx2.UseVisualStyleBackColor = true;
            btnEx2.Click += btnEx2_Click;
            // 
            // btnEx3
            // 
            btnEx3.Location = new Point(463, 56);
            btnEx3.Name = "btnEx3";
            btnEx3.Size = new Size(144, 68);
            btnEx3.TabIndex = 3;
            btnEx3.Text = "Exercício 3";
            btnEx3.UseVisualStyleBackColor = true;
            btnEx3.Click += btnEx3_Click;
            // 
            // btnEx4
            // 
            btnEx4.Location = new Point(463, 212);
            btnEx4.Name = "btnEx4";
            btnEx4.Size = new Size(144, 68);
            btnEx4.TabIndex = 2;
            btnEx4.Text = "Exercício 4";
            btnEx4.UseVisualStyleBackColor = true;
            btnEx4.Click += btnEx4_Click;
            // 
            // btnEx5
            // 
            btnEx5.Location = new Point(313, 322);
            btnEx5.Name = "btnEx5";
            btnEx5.Size = new Size(144, 68);
            btnEx5.TabIndex = 4;
            btnEx5.Text = "Exercício 5";
            btnEx5.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEx5);
            Controls.Add(btnEx3);
            Controls.Add(btnEx4);
            Controls.Add(btnEx2);
            Controls.Add(btnEx1);
            Name = "FrmPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEx1;
        private Button btnEx2;
        private Button btnEx3;
        private Button btnEx4;
        private Button btnEx5;
        private ErrorProvider errorProvider1;
    }
}
