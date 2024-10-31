using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer12
{
    internal class Revolver
    {
        private Random random = new Random();
        private int posicionActual;
        private int posicionBala;
        public int PosicionActual
        {
            get { return posicionActual; }
            set { posicionActual = value; }
        }
        public int PosicionBala 
        {
            get { return posicionBala; } 
            set { posicionBala = value; } 
        }
        public Revolver()
        {
            this.posicionActual = random.Next(0, 6);
            this.posicionBala = random.Next(0, 6);
        }
        public bool Disparar()
        {
            if (posicionActual == posicionBala)
            {
                return true;
            }
            return false;
        }
        public void SiguienteBala()
        {
            posicionActual++;

            if (posicionActual >= 6)
            {
                posicionActual = 0;
            }
        }
    }
}
