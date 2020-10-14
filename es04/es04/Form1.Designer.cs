namespace es04
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSecondariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFigliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPassaAfiglia = new System.Windows.Forms.Button();
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.menuToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.infoToolStripMenuItem.Text = "info";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSecondariaToolStripMenuItem,
            this.newDinamicaToolStripMenuItem,
            this.newFigliaToolStripMenuItem,
            this.newMDIToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newSecondariaToolStripMenuItem
            // 
            this.newSecondariaToolStripMenuItem.Name = "newSecondariaToolStripMenuItem";
            this.newSecondariaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newSecondariaToolStripMenuItem.Text = "New secondaria";
            this.newSecondariaToolStripMenuItem.Click += new System.EventHandler(this.newSecondariaToolStripMenuItem_Click);
            // 
            // newDinamicaToolStripMenuItem
            // 
            this.newDinamicaToolStripMenuItem.Name = "newDinamicaToolStripMenuItem";
            this.newDinamicaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newDinamicaToolStripMenuItem.Text = "New dinamica";
            this.newDinamicaToolStripMenuItem.Click += new System.EventHandler(this.newDinamicaToolStripMenuItem_Click);
            // 
            // newFigliaToolStripMenuItem
            // 
            this.newFigliaToolStripMenuItem.Name = "newFigliaToolStripMenuItem";
            this.newFigliaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newFigliaToolStripMenuItem.Text = "New figlia";
            this.newFigliaToolStripMenuItem.Click += new System.EventHandler(this.newFigliaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome:";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(114, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 3;
            // 
            // txtCognome
            // 
            this.txtCognome.Enabled = false;
            this.txtCognome.Location = new System.Drawing.Point(114, 102);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.ReadOnly = true;
            this.txtCognome.Size = new System.Drawing.Size(100, 22);
            this.txtCognome.TabIndex = 4;
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // newMDIToolStripMenuItem
            // 
            this.newMDIToolStripMenuItem.Name = "newMDIToolStripMenuItem";
            this.newMDIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newMDIToolStripMenuItem.Text = "New MDI";
            // 
            // btnPassaAfiglia
            // 
            this.btnPassaAfiglia.Location = new System.Drawing.Point(12, 213);
            this.btnPassaAfiglia.Name = "btnPassaAfiglia";
            this.btnPassaAfiglia.Size = new System.Drawing.Size(133, 33);
            this.btnPassaAfiglia.TabIndex = 5;
            this.btnPassaAfiglia.Text = "passa a figlia";
            this.btnPassaAfiglia.UseVisualStyleBackColor = true;
            this.btnPassaAfiglia.Click += new System.EventHandler(this.btnPassaAfiglia_Click);
            // 
            // txtPadre
            // 
            this.txtPadre.Location = new System.Drawing.Point(170, 218);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.Size = new System.Drawing.Size(100, 22);
            this.txtPadre.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPadre);
            this.Controls.Add(this.btnPassaAfiglia);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSecondariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDinamicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFigliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMDIToolStripMenuItem;
        private System.Windows.Forms.Button btnPassaAfiglia;
        private System.Windows.Forms.TextBox txtPadre;
    }
}

