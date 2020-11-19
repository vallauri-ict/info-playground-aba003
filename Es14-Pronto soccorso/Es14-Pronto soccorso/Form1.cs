using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es14_Pronto_soccorso
{
    public partial class Form1 : Form
    {
        public struct Paziente
        {
            public string nome;
            public string eta;
            public string temperatura;
            public string colore;
        }
        Queue<string> CodiceBianco = new Queue<string>();
        Queue<string> CodiceVerde = new Queue<string>();
        Queue<string> CodiceGiallo = new Queue<string>();
        Queue<string> CodiceRosso = new Queue<string>();
        int temperatura = 0;
        string nome = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Paziente paziente;
            paziente.nome = txtNome.Text;
            paziente.eta = txteta.Text;
            paziente.temperatura = txtTemp.Text;
            paziente.colore = cmbCodice.Text;
            if (Convert.ToInt32(paziente.temperatura)>=temperatura)
            {
                temperatura = Convert.ToInt32(paziente.temperatura);
                nome = paziente.nome;
            }
            switch (paziente.colore)
            {
                case "Rosso":
                    CodiceRosso.Enqueue(paziente.nome);
                    break;
                case "Giallo":
                    CodiceGiallo.Enqueue(paziente.nome);
                    break;
                case "Verde":
                    CodiceVerde.Enqueue(paziente.nome);
                    break;
                case "Bianco":
                    CodiceBianco.Enqueue(paziente.nome);
                    break;
                default:
                    break;
            }
            txtNome.Text = "";
            txteta.Text = "";
            txtTemp.Text = "";
            cmbCodice.SelectedIndex = -1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CodiceRosso.Count!=0)
            {
                MessageBox.Show(CodiceRosso.Dequeue());
            }
            else if (CodiceGiallo.Count != 0)
            {
                MessageBox.Show(CodiceGiallo.Dequeue());
            }
            else if (CodiceVerde.Count != 0)
            {
                MessageBox.Show(CodiceVerde.Dequeue());
            }
            else
            {
                MessageBox.Show(CodiceBianco.Dequeue());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La persona con la temperatura piu alta è: " + nome + " e la sua temperatura è stata: " + temperatura);
        }
    }
}
