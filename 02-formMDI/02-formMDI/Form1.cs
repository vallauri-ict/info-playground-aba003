using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _02_formMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApri1_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.Text = "Figlia1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            //impostare con posizionamento manuel da codice e non da windows
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(20, 30);
            f.Show();
        }

        private void btnApri2_Click(object sender, EventArgs e)
        {
            Figlia2 f = new Figlia2();
            f.Text = "Figlia2";
            f.MdiParent = this;
            f.Size = new Size(280, 180);
            //impostare con posizionamento manuel da codice e non da windows
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(250, 30);
            f.Show();
        }

        private void btnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sono state aperte: " + this.MdiChildren.Length + " finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("finestra " + f.Text + " aperta");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolstrilbl_Click(object sender, EventArgs e)
        {

        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolstrilbl.Text = "premuto apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolstrilbl.Text = "premuto apri 2";
        }
    }
}
