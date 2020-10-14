namespace es04
{
    partial class FormFiglia
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
            this.txtFiglia = new System.Windows.Forms.TextBox();
            this.btnPassaAformPadre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFiglia
            // 
            this.txtFiglia.Location = new System.Drawing.Point(18, 12);
            this.txtFiglia.Name = "txtFiglia";
            this.txtFiglia.Size = new System.Drawing.Size(173, 22);
            this.txtFiglia.TabIndex = 0;
            // 
            // btnPassaAformPadre
            // 
            this.btnPassaAformPadre.Location = new System.Drawing.Point(12, 57);
            this.btnPassaAformPadre.Name = "btnPassaAformPadre";
            this.btnPassaAformPadre.Size = new System.Drawing.Size(179, 55);
            this.btnPassaAformPadre.TabIndex = 1;
            this.btnPassaAformPadre.Text = "passa a papà";
            this.btnPassaAformPadre.UseVisualStyleBackColor = true;
            this.btnPassaAformPadre.Click += new System.EventHandler(this.btnPassaAformPadre_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 124);
            this.Controls.Add(this.btnPassaAformPadre);
            this.Controls.Add(this.txtFiglia);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.Load += new System.EventHandler(this.FormFiglia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiglia;
        private System.Windows.Forms.Button btnPassaAformPadre;
    }
}