﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Scopa
{
    class Mano
    {
        List<Carta> mano = new List<Carta>();

        public Mano()
        {
            mano.Clear();
        }
        public List<Carta> Lettura()
        {
            return mano;
        }

        public Carta Gioca(int indice)
        {
            Carta aus = mano.ElementAt(indice);
            mano.RemoveAt(indice);
            return aus;
        }
    }
}
