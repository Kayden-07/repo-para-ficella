using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9
{
    internal class Asiento
    {
        private int fila;
        private char columna;
        private bool ocupado;
        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }
        public char Columna
        {
            get { return columna; }
            set { columna = value; }
        }
        public bool Ocupado
        {
            get { return ocupado; }
            set { ocupado = value; }
        }
        public Asiento(int fila, char columna)
        {
            this.fila = fila;
            this.columna = columna;
            this.ocupado = false;
        }
    }
}
