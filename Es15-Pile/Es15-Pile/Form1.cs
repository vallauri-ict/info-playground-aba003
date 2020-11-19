using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es15_Pile
{
    public partial class Form1 : Form
    {
        public struct Container
        {
            public string Codice;
            public int Peso;
            public int Tara;
        }
        Stack<Container> pila = new Stack<Container>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                Container container;
                container.Codice = txtCodice.Text;
                container.Peso = Convert.ToInt32(txtPeso.Text);
                container.Tara = Convert.ToInt32(txtTara.Text);
                pila.Push(container);
                txtCodice.Text = "";
                txtPeso.Text = "";
                txtTara.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Nessun container inserito");
            }
           
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            try
            {
                Container container = pila.Pop();
                MessageBox.Show("É stato caricato il container:"+" "+container.Codice+" con il peso: "+container.Peso+" e la tara: " + container.Tara );
            }
            catch (Exception)
            {
                MessageBox.Show("Non c'è nessun container in porto");
            }

        }
    }
}
