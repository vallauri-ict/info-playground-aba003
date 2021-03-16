namespace Es09___classi_indicizzate
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
            this.btncrea = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncrea
            // 
            this.btncrea.Location = new System.Drawing.Point(57, 51);
            this.btncrea.Name = "btncrea";
            this.btncrea.Size = new System.Drawing.Size(122, 23);
            this.btncrea.TabIndex = 0;
            this.btncrea.Text = "crea classe";
            this.btncrea.UseVisualStyleBackColor = true;
            this.btncrea.Click += new System.EventHandler(this.btncrea_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(57, 90);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(122, 23);
            this.btnVisualizza.TabIndex = 1;
            this.btnVisualizza.Text = "visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(69, 13);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(100, 22);
            this.txtCampo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btncrea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrea;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.TextBox txtCampo;
    }
}

