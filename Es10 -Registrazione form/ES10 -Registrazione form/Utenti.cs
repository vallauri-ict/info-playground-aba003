using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ES10__Registrazione_form
{
    public partial class Utenti : Form
    {
        public string cognome;
        public string nome;
        public string cap;
        public string indirizzo;   
        public string email;
        public string fiscale;
        public string user;
        public string password;
        public Utenti()
        {
            InitializeComponent();
        }

        private Utenti(string cognome, string nome, string cap, string indirizzo, string email, string fiscale, string user, string password)
        {
            this.cognome = cognome;
            this.nome = nome;
            this.cap = cap;
            this.indirizzo = indirizzo;
            this.fiscale = fiscale;
            this.email = email;
            this.user = user;
            this.password = password;
        }
        private void Utenti_Load(object sender, EventArgs e)
        {

        }
        public static Utenti Creautente(string cognome, string nome, string cap, string indirizzo, string email, string fiscale, string user, string password)
        {
            
        }


    }
}
