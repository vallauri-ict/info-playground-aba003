using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_liste
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public int id;
            public string titolo;
            public string autore;
        }

        List<Libro> miaLista = new List<Libro>(); //inizializzazione di una list associata alla struttura

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            Libro l;

            l.id = Convert.ToInt32(txtID.Text);
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            miaLista.Add(l);
        }

        private void BtnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (var libro in miaLista)
            {
                MessageBox.Show("Titolo: "+libro.titolo+"\nAutore: "+libro.autore);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void btnAggiungiobj_Click(object sender, EventArgs e)
        {

        }
    }
}
