using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_SecondoEsercizioDispense_Delegate_
{
    public class OverMaxEventArgs : EventArgs
    {
        public int ValoreSoglia { get; }

        public OverMaxEventArgs(int valoreSoglia)
        {
            ValoreSoglia = valoreSoglia;
        }
    }
}