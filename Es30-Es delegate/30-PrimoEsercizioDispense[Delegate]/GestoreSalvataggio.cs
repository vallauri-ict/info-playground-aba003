﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_PrimoEsercizioDispense_Delegate_
{
    // DICHIARO il mio delegate
    public delegate void salvataggioEseguitoEventHandler(int id);
    class GestoreSalvataggio
    {
        // DICHIARO l'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile(int id)
        {
            System.Windows.Forms.MessageBox.Show("Sto eseguendo il salvataggio...");

            salvataggioEseguito(id);
        }
    }
}
