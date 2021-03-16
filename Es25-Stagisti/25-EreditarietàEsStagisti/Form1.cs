using System;
using System.Windows.Forms;

namespace _25_EreditarietàEsStagisti
{
    public partial class Form1 : Form
    {
        clsElenco elencoStudenti;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new clsElenco();
        }
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            clsAlunno studente;
            if (txtOreStage.Text.Trim() == "")
            {
                studente = new clsAlunno(txtNome.Text,txtCognome.Text,txtCitta.Text, Convert.ToChar(cmbClasse.SelectedItem)
                    , cmbSezione.SelectedItem.ToString(),cmbSpec.SelectedItem.ToString());
            }
            else
            {
                studente = new clsStagista(txtNome.Text, txtCognome.Text, txtCitta.Text, Convert.ToChar(cmbClasse.SelectedItem)
                    , cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString(), cmbAzienda.SelectedItem.ToString(),
                    txtOreStage.Text);
                btnRicerca.Enabled = true;
            }
            elencoStudenti.inserisci(studente);
            elencoStudenti.visualizzaDgv(dgvStudenti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach (Control c in Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                    //TextBox txt = (TextBox)t; -> txt.Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
        }
        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedItem.ToString();
            int ore = elencoStudenti.OreAzienda(azienda);

            if(ore!=0)
            {
                MessageBox.Show("Gli stagisti hanno effettuato " + ore + " ore in " + azienda,"Information"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Non è stata effettuata alcuna ora in " + azienda, "Information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPosizione.Text == "")
                {
                    elencoStudenti.cancella();
                }
                else
                {
                    elencoStudenti.cancella(Convert.ToInt32(txtPosizione.Text));
                }
                MessageBox.Show("Cancellazione Effettuata!");
                elencoStudenti.visualizzaDgv(dgvStudenti);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
