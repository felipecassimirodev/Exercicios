
namespace PrimeiroProjeto
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.Button();
            this.botao_cadastrar_categoria = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            resources.ApplyResources(this.cadastrosToolStripMenuItem, "cadastrosToolStripMenuItem");
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            // 
            // produtosToolStripMenuItem
            // 
            resources.ApplyResources(this.produtosToolStripMenuItem, "produtosToolStripMenuItem");
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            resources.ApplyResources(this.categoriasToolStripMenuItem, "categoriasToolStripMenuItem");
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // botao_cadastrar_categoria
            // 
            resources.ApplyResources(this.botao_cadastrar_categoria, "botao_cadastrar_categoria");
            this.botao_cadastrar_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_cadastrar_categoria.Name = "botao_cadastrar_categoria";
            this.botao_cadastrar_categoria.UseVisualStyleBackColor = true;
            this.botao_cadastrar_categoria.Click += new System.EventHandler(this.botao_cadastrar_categoria_Click);
            // 
            // frm_menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::PrimeiroProjeto.Properties.Resources.nar;
            this.Controls.Add(this.botao_cadastrar_categoria);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button botao_cadastrar_categoria;
    }
}