using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_formMDI
{
    public partial class ModalX : Form
    {
        public ModalX()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ModalX f = new ModalX();
            f.Text = "usire?";
            if (f.ShowDialog()==DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
