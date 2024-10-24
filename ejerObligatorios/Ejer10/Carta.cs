using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10
{
    internal class Carta
    {
        private int numero;
        private string palo;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Palo
        {
            get { return palo; }
            set { palo = value; }
        }
        public Carta (int numero, string palo)
        {
            this.numero = numero;
            this.palo = palo;
        }
    }
}
