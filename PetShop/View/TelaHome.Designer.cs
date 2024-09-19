namespace PetShop.View
{
    partial class TelaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHome));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            agendamentoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MidnightBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, agendamentoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(601, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(88, 22);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // agendamentoToolStripMenuItem
            // 
            agendamentoToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            agendamentoToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            agendamentoToolStripMenuItem.Size = new Size(126, 22);
            agendamentoToolStripMenuItem.Text = "Agendamento";
            // 
            // TelaHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(601, 516);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "TelaHome";
            Text = "TelaHome";
            Load += TelaHome_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem agendamentoToolStripMenuItem;
    }
}