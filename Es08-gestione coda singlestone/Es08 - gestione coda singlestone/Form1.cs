using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es08___gestione_coda_singlestone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (txtLibro.Text=="")
            {
                MessageBox.Show("Inserire il titolo di un libro!");
            }
            else
            {
                Singleston s = Singleston.GetClsSingleton();
                s.push(txtLibro.Text);
                txtLibro.Text = "";
            }
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            Singleston s = Singleston.GetClsSingleton();
            s.pull();
        }
    }
}
