using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_OOP_Persone_Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Studente> lstStudenti = new List<Studente>();

        private void btnCarica_Click(object sender, EventArgs e)
        {
            try
            {
                Studente s = new Studente();
                s.SetAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
                lstStudenti.Add(s);
                lstVwStudenti.Items.Add(s.getCognome());
                txtNome.Text = "";
                txtCognome.Text = "";
                txtSesso.Text = "";
                txtEta.Text = "";
                

            }
            catch (Exception)
            {

                MessageBox.Show("Campi inseriti errati");
            }
           
        }

        private void lstVwStudenti_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstStudenti.Find(stud => stud.getCognome() == lstVwStudenti.SelectedItems[0].Text);
            MessageBox.Show("I voti di " + s.getCognome() + " sono: ");
            foreach (var voto in s.voti)
            {
                MessageBox.Show(voto.ToString());
            }
        }

        private void btnCaricavoto_Click(object sender, EventArgs e)
        {
            try
            {
                string cognome = lstVwStudenti.SelectedItems[0].Text;
                int voto = Convert.ToInt32(txtVoto.Text);
                foreach (var item in lstStudenti)
                {
                    if (cognome == item.getCognome())
                    {
                        item.voti.Add(voto);
                    }
                }
                txtVoto.Text = "";
                MessageBox.Show("Voto inserito correttamente");


            }
            catch (Exception)
            {

                MessageBox.Show("Voto non inserito");
            }
        }
    }
}
