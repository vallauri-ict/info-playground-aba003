﻿namespace MultiForm
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
            this.components = new System.ComponentModel.Container();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm2B = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassa = new System.Windows.Forms.Button();
            this.btnFormModale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFm = new System.Windows.Forms.TextBox();
            this.txtEtaFm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(16, 15);
            this.btnForm2.Margin = new System.Windows.Forms.Padding(4);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(100, 28);
            this.btnForm2.TabIndex = 0;
            this.btnForm2.Text = "Apri Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm2B
            // 
            this.btnForm2B.Location = new System.Drawing.Point(124, 15);
            this.btnForm2B.Margin = new System.Windows.Forms.Padding(4);
            this.btnForm2B.Name = "btnForm2B";
            this.btnForm2B.Size = new System.Drawing.Size(100, 28);
            this.btnForm2B.TabIndex = 1;
            this.btnForm2B.Text = "Apri Form 2B";
            this.btnForm2B.UseVisualStyleBackColor = true;
            this.btnForm2B.Click += new System.EventHandler(this.btnForm2B_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(16, 50);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(100, 22);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassa
            // 
            this.btnPassa.Location = new System.Drawing.Point(124, 50);
            this.btnPassa.Name = "btnPassa";
            this.btnPassa.Size = new System.Drawing.Size(133, 23);
            this.btnPassa.TabIndex = 3;
            this.btnPassa.Text = "Passa txt a F2";
            this.btnPassa.UseVisualStyleBackColor = true;
            this.btnPassa.Click += new System.EventHandler(this.btnPassa_Click);
            // 
            // btnFormModale
            // 
            this.btnFormModale.Location = new System.Drawing.Point(12, 198);
            this.btnFormModale.Name = "btnFormModale";
            this.btnFormModale.Size = new System.Drawing.Size(122, 33);
            this.btnFormModale.TabIndex = 4;
            this.btnFormModale.Text = "apri form modale";
            this.btnFormModale.UseVisualStyleBackColor = true;
            this.btnFormModale.Click += new System.EventHandler(this.btnFormModale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome ";
            // 
            // txtNomeFm
            // 
            this.txtNomeFm.Location = new System.Drawing.Point(83, 93);
            this.txtNomeFm.Name = "txtNomeFm";
            this.txtNomeFm.ReadOnly = true;
            this.txtNomeFm.Size = new System.Drawing.Size(100, 22);
            this.txtNomeFm.TabIndex = 6;
            // 
            // txtEtaFm
            // 
            this.txtEtaFm.Location = new System.Drawing.Point(83, 144);
            this.txtEtaFm.Name = "txtEtaFm";
            this.txtEtaFm.ReadOnly = true;
            this.txtEtaFm.Size = new System.Drawing.Size(100, 22);
            this.txtEtaFm.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Età";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtEtaFm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFormModale);
            this.Controls.Add(this.btnPassa);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.btnForm2B);
            this.Controls.Add(this.btnForm2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnForm2B;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.Button btnPassa;
        private System.Windows.Forms.Button btnFormModale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFm;
        private System.Windows.Forms.TextBox txtEtaFm;
        private System.Windows.Forms.Label label2;
    }
}

