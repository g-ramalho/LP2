namespace PAtividade7
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
            menuStrip1 = new MenuStrip();
            exercício1ToolStripMenuItem = new ToolStripMenuItem();
            exercício2ToolStripMenuItem = new ToolStripMenuItem();
            exercício3ToolStripMenuItem = new ToolStripMenuItem();
            exercício4ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exercício1ToolStripMenuItem, exercício2ToolStripMenuItem, exercício3ToolStripMenuItem, exercício4ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // exercício1ToolStripMenuItem
            // 
            exercício1ToolStripMenuItem.Name = "exercício1ToolStripMenuItem";
            exercício1ToolStripMenuItem.Size = new Size(110, 29);
            exercício1ToolStripMenuItem.Text = "Exercício 1";
            exercício1ToolStripMenuItem.Click += Exercício1ToolStripMenuItem_Click;
            // 
            // exercício2ToolStripMenuItem
            // 
            exercício2ToolStripMenuItem.Name = "exercício2ToolStripMenuItem";
            exercício2ToolStripMenuItem.Size = new Size(110, 29);
            exercício2ToolStripMenuItem.Text = "Exercício 2";
            exercício2ToolStripMenuItem.Click += Exercício2ToolStripMenuItem_Click;
            // 
            // exercício3ToolStripMenuItem
            // 
            exercício3ToolStripMenuItem.Name = "exercício3ToolStripMenuItem";
            exercício3ToolStripMenuItem.Size = new Size(110, 29);
            exercício3ToolStripMenuItem.Text = "Exercício 3";
            exercício3ToolStripMenuItem.Click += Exercício3ToolStripMenuItem_Click;
            // 
            // exercício4ToolStripMenuItem
            // 
            exercício4ToolStripMenuItem.Name = "exercício4ToolStripMenuItem";
            exercício4ToolStripMenuItem.Size = new Size(110, 29);
            exercício4ToolStripMenuItem.Text = "Exercício 4";
            exercício4ToolStripMenuItem.Click += Exercício4ToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Atividade 7";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exercício1ToolStripMenuItem;
        private ToolStripMenuItem exercício2ToolStripMenuItem;
        private ToolStripMenuItem exercício3ToolStripMenuItem;
        private ToolStripMenuItem exercício4ToolStripMenuItem;
    }
}
