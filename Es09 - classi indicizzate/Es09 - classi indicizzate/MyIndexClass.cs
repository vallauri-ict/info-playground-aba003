using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es09___classi_indicizzate
{
    class MyIndexClass
    {
        private string[] element;
        public MyIndexClass(int elementNumber)//creando il costruttore (quante stringhe vengano generate nella ia classe indexata)
        {
            element = new string[elementNumber];
            for (int i = 0; i < element.Length; i++)
            {
                element[i] = "empty";
            }
        }

        //iteratore 
        public string this[int pos]//questo metodo viene richiamato nel main 
        {
            
            get { return element[pos]; }
            set { element[pos] = value; }
        }
        public int length()
        {
            return element.Length;
        }
    }
}
