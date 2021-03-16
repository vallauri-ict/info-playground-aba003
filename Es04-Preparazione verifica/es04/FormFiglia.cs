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
    public partial class FormFiglia : Form
    {
        TextBox txt;
        TextBox inviaAform1;
        
       
        public FormFiglia()
        {
            InitializeComponent();
        }

        public FormFiglia(TextBox txtPadre)
        {
            InitializeComponent();
            this.txt = txtPadre;
            txtFiglia.Text = this.txt.Text;
            inviaAform1 = txtPadre;

        }

        private void FormFiglia_Load(object sender, EventArgs e)
        {

        }

        private void btnPassaAformPadre_Click(object sender, EventArgs e)
        {
            inviaAform1.Text=txtFiglia.Text;
            
        }
    }
}
