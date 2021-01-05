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
            Studente s = new Studente();
            s.SetAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
            lstStudenti.Add(s);
            lstVwStudenti.Items.Add(s.getCognome());
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstVwStudenti.Find(Studente => Studente.getCognome() == lstVwStudenti.SelectedItems[0].Text);

        }

        private void lstVwStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cognome = lstVwStudenti.SelectedItems[0].Text;
            foreach (Studente student in lstStudenti)
            {
                if(student.getCognome() == cognome)
                {
                    student.voti.Add(Convert.ToInt32(txtVoto.Text));
                }
            }
        }
    }
}
