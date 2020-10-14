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
    public partial class Form2 : Form
    {
        public string nome="";
        public string cognome = "";
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.nome = txtNomef2.Text;
            this.cognome = txtCognomef2.Text;
            MessageBox.Show("operazione eseguira con successo");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           nome = "";
            cognome = "";
            MessageBox.Show("operazione annullata");
        }
    }
}
