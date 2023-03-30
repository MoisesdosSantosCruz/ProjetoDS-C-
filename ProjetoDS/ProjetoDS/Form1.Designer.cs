
namespace ProjetoDS
{
    partial class frmmenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuexercicio = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercícioEnquantoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuexercicio,
            this.mnusair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuexercicio
            // 
            this.mnuexercicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício1ToolStripMenuItem,
            this.exercícioEnquantoToolStripMenuItem});
            this.mnuexercicio.Name = "mnuexercicio";
            this.mnuexercicio.Size = new System.Drawing.Size(71, 20);
            this.mnuexercicio.Text = "Exercícios";
            // 
            // exercício1ToolStripMenuItem
            // 
            this.exercício1ToolStripMenuItem.Name = "exercício1ToolStripMenuItem";
            this.exercício1ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exercício1ToolStripMenuItem.Text = "Exercício1";
            this.exercício1ToolStripMenuItem.Click += new System.EventHandler(this.exercício1ToolStripMenuItem_Click);
            // 
            // exercícioEnquantoToolStripMenuItem
            // 
            this.exercícioEnquantoToolStripMenuItem.Name = "exercícioEnquantoToolStripMenuItem";
            this.exercícioEnquantoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exercícioEnquantoToolStripMenuItem.Text = "ExercícioEnquanto";
            this.exercícioEnquantoToolStripMenuItem.Click += new System.EventHandler(this.exercícioEnquantoToolStripMenuItem_Click);
            // 
            // mnusair
            // 
            this.mnusair.Name = "mnusair";
            this.mnusair.Size = new System.Drawing.Size(38, 20);
            this.mnusair.Text = "Sair";
            this.mnusair.Click += new System.EventHandler(this.mnusair_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuexercicio;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnusair;
        private System.Windows.Forms.ToolStripMenuItem exercícioEnquantoToolStripMenuItem;
    }
}

