using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer17
{
    internal class Carta<T> // <T>: parámetro de tipo generico que representa un tipo de datos que no esta definido hasta el momento de su uso
    {
        private int numero;
        private T palo;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public T Palo
        {
            get { return palo; }
            set { palo = value; }
        }
        public Carta(int numero, T palo)
        {
            this.numero = numero;
            this.palo = palo;
        }
        public string ObtenerNombreCarta()
        {
            string nombreCarta = Numero.ToString(); 

            if (Palo is PalosFrancesa)
            {
                switch (Numero)
                {
                    case 1:
                        nombreCarta = "As";
                        break;
                    case 11:
                        nombreCarta = "Jota";
                        break;
                    case 12:
                        nombreCarta = "Reina";
                        break;
                    case 13:
                        nombreCarta = "Rey";
                        break;
                }
            }
            else if (Palo is PalosEspañola)
            {
                switch (Numero)
                {
                    case 1:
                        nombreCarta = "As";
                        break;
                    case 10:
                        nombreCarta = "Sota";
                        break;
                    case 11:
                        nombreCarta = "Jota";
                        break;
                    case 12:
                        nombreCarta = "Caballo";
                        break;
                    case 13:
                        nombreCarta = "Rey";
                        break;
                }
            }

            return nombreCarta;
        }
        public override string ToString()
        {
            return $"{ObtenerNombreCarta()} de {Palo}";
        }
    }
}
