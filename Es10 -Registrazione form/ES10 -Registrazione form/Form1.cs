using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace ES10__Registrazione_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valido = true;
            string errore = "";

            //***********COGNOME******************
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$"); //il + indica uno o piu lettere minuscole
            controlla(regCognome, txtCognome);
            //***********NOME******************
            Regex regNome = new Regex(@"^[A-Z]{1}[a-z]+$"); 
            controlla(regNome, txtNome);
            ////*****************CAP******************
            Regex regCap = new Regex(@"^\d{5}$");
            controlla(regCap, txtCap);
            ////*****************INDIRIZZO******************
            Regex regIndirizzo = new Regex(@"^[A-Za-z\s]+\s\d+$"); 
            controlla(regIndirizzo, txtIndirizzo);
            ////**************EMAIL******** (inizia con dei caratteri, ".", "_","-","@",alcuni caratteri ,".",altri caratteri[da 2 a 4])
            Regex regEmail = new Regex(@"^([a-zA-Z\d_\-\.]+)@([a-zA-Z\d_\-\.]+)\.([a-zA-Z]{2,4})$"); //il + indica uno o piu lettere minuscole
            controlla(regEmail, txtEmail);
            ////*************CODICE FISCALE****************
            Regex regFiscale = new Regex(@"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$"); 
            controlla(regFiscale, txtCod);
            ////*************USERNAME************************
            Regex regUsername = new Regex(@"^[a-zA-Z\d]{2,20}$"); 
            controlla(regUsername, txtUsername);
            ////**************password****************
            Regex regPw = new Regex(@"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20})$");
            controlla(regPw, txtPassword);


            void controlla(Regex regex, TextBox textBox)
            {
                if (textBox.Text.ToString()=="")
                {
                    MessageBox.Show("Dato mancante in " + textBox.Name);
                    textBox.BackColor = (Color.Red);
                    valido = false;
                }
                else if (!regex.IsMatch(textBox.Text))
                {
                    MessageBox.Show("Dato inserito non valido in " + textBox.Name);
                    textBox.BackColor = (Color.Red);
                    valido = false;
                }
                else
                {
                    textBox.BackColor = Color.White;
                   
                }
            }

            if (valido)
            {

                MessageBox.Show("registrazione avvenuta con successo!");
                Utenti utente = Utenti.Creautente( txtCognome.Text, txtNome.Text, txtCap.Text, txtIndirizzo.Text, txtEmail.Text, txtCod.Text, txtUsername.Text, txtPassword.Text);
            }
            else
            {
                MessageBox.Show("registrazione fallita!");
            }


            

           
            
           

      

        }
    }
}
