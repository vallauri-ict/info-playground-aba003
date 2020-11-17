using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es12_Dictionary
{
    public partial class Form1 : Form
    {
        public struct libro
        {
            public string titolo;
            public string autore;
        }
        public int i = 0;
        Dictionary<int, libro> dizionarioLibri = new Dictionary<int, libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            libro l;
         
            if (!(textBox2.Text=="" || textBox2.Text == ""))
            {
                l.titolo = textBox2.Text;
                l.autore = textBox3.Text;
                dizionarioLibri.Add(i++, l);
                MessageBox.Show("Dati inseriti correttamente!");
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Dati  errati!");
            }
          
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(dizionarioLibri.Count==0))
            {
                foreach (int key in dizionarioLibri.Keys)
                    MessageBox.Show(Convert.ToString(key));
                foreach (libro l in dizionarioLibri.Values)
                    MessageBox.Show(l.titolo + " " + l.autore);
            }
            else
            {
                MessageBox.Show("La coda è vuota Inserire un valore");
            }
            
            
        }
    }
}
