using System;
using System.Windows.Forms;

namespace _31_SecondoEsercizioDispense_Delegate_
{
    public partial class Form1 : Form
    {

        Counter cnt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                cnt = new Counter(Convert.ToInt32(txtMaxValue.Text));
                cnt.OverMax += new OverMaxEventHandler(gestioneMaxValue);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void gestioneMaxValue(object sender, OverMaxEventArgs e)
        {
            MessageBox.Show("Raggiunto il valore: " + e.ValoreSoglia);
        }

        private void btnIncrementa_Click(object sender, EventArgs e)
        {
            cnt.Incrementa();//necessaria revisione in qunto non funzionante
        }
    }
}
