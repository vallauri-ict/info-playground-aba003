namespace Gestione_liste
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnAggiungiobj = new System.Windows.Forms.Button();
            this.btnvisualizzaobj = new System.Windows.Forms.Button();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(93, 7);
            this.txtTitolo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(132, 22);
            this.txtTitolo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autore";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(93, 96);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(93, 49);
            this.txtAutore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(132, 22);
            this.txtAutore.TabIndex = 5;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(13, 146);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(129, 28);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi libro";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(173, 146);
            this.btnVisualizza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(129, 28);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "Visualizza catalogo";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.BtnVisualizza_Click);
            // 
            // btnAggiungiobj
            // 
            this.btnAggiungiobj.Location = new System.Drawing.Point(13, 201);
            this.btnAggiungiobj.Name = "btnAggiungiobj";
            this.btnAggiungiobj.Size = new System.Drawing.Size(129, 27);
            this.btnAggiungiobj.TabIndex = 8;
            this.btnAggiungiobj.Text = "Aggiungi obj";
            this.btnAggiungiobj.UseVisualStyleBackColor = true;
            this.btnAggiungiobj.Click += new System.EventHandler(this.btnAggiungiobj_Click);
            // 
            // btnvisualizzaobj
            // 
            this.btnvisualizzaobj.Location = new System.Drawing.Point(173, 201);
            this.btnvisualizzaobj.Name = "btnvisualizzaobj";
            this.btnvisualizzaobj.Size = new System.Drawing.Size(129, 27);
            this.btnvisualizzaobj.TabIndex = 9;
            this.btnvisualizzaobj.Text = "Visualizza obj";
            this.btnvisualizzaobj.UseVisualStyleBackColor = true;
            // 
            // txtRicerca
            // 
            this.txtRicerca.Location = new System.Drawing.Point(173, 247);
            this.txtRicerca.Margin = new System.Windows.Forms.Padding(4);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(129, 22);
            this.txtRicerca.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ricerca: titolo/autore";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(13, 319);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(131, 27);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "cerca titolo";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(174, 319);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(131, 27);
            this.btnFindAll.TabIndex = 13;
            this.btnFindAll.Text = "cerca titolo";
            this.btnFindAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 422);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtRicerca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnvisualizzaobj);
            this.Controls.Add(this.btnAggiungiobj);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnAggiungiobj;
        private System.Windows.Forms.Button btnvisualizzaobj;
        private System.Windows.Forms.TextBox txtRicerca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindAll;
    }
}

