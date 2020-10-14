using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newDinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formdinamica = new Form();
            Formdinamica.Text = "aperta from dinamica";
            Formdinamica.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newSecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                txtCognome.Text = f2.cognome;
                txtNome.Text = f2.nome;

            }
            else
            {
                txtCognome.Text = f2.cognome;
                txtNome.Text = f2.nome;
            }
        }

        private void newFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia formFiglia = new FormFiglia(txtPadre);
            formFiglia.Show();
        }

        private void btnPassaAfiglia_Click(object sender, EventArgs e)
        {
            FormFiglia formFiglia = new FormFiglia(txtPadre);
            formFiglia.Show();
        }
        
    }
}
