using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Es08___gestione_coda_singlestone
{
    class Singleston
    {
        private static Singleston istanza = null;
        public static Queue<string> codaStampa = new Queue<string>();

        public void push (string s)
        {
            codaStampa.Enqueue(s);
            MessageBox.Show("il libro: " + s + " è stato aggiunto alla coda");
        }
        public void pull()
        {
            try
            {
                string s = codaStampa.Dequeue();
                MessageBox.Show("il libro: " + s + " è stato rimosso dalla coda");
            }
            catch (Exception)
            {

                MessageBox.Show("la coda di stampa è vuota!");
            }
        }
        public static Singleston GetClsSingleton()
        {
            if (istanza == null)
            {
                istanza = new Singleston();
            }
            return istanza;
        }
    }
}
