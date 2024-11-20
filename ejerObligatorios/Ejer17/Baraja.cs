using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer17
{
    public enum PalosEspañola //representa un conjunto de valores constantes con nombre
    {
        oros, // es 0
        copas, // es 1
        espadas, // es 2
        bastos //es 3
    } 

    public enum PalosFrancesa //representa un conjunto de valores constantes con nombre
    {
        diamantes,
        picas,
        corazones,
        treboles
    }
    internal abstract class Baraja<T> //abstract: clase base para otras clases, no puede ser instanciada directamente
    {
        protected List<Carta<T>> barajaCartas = new List<Carta<T>>(); //protected: para que sea accesible en las clases hijas, pero no desde fuera de la herencia
        protected List<Carta<T>> cartaSaque = new List<Carta<T>>();
        protected Random random = new Random(); 

        public abstract void CrearBaraja();
        public void Barajar()
        {
            Carta<T> cartaguardada;
            int numRand;
            for (int i = barajaCartas.Count - 1; i >= 0; i--)
            {
                numRand = random.Next(0, barajaCartas.Count);
                cartaguardada = barajaCartas[i];
                barajaCartas[i] = barajaCartas[numRand];
                barajaCartas[numRand] = cartaguardada;
            }
        }
        public Carta<T> SiguienteCarta()
        {
            if (barajaCartas.Count > 0)
            {
                var carta = barajaCartas[0]; 
                barajaCartas.RemoveAt(0); 
                cartaSaque.Add(carta);
                return carta; 
            }
            return null; 
        }
        public void CartasDisplonibles()
        {
            Console.Write(barajaCartas.Count.ToString());
        }
        public string DarCartas(int cantPedidas)
        {
            string cartas = "";
            if (barajaCartas.Count >= cantPedidas)
            {
                for (int i = 0; i < cantPedidas; i++)
                {
                    cartas += $"[{barajaCartas[0].Numero}|{barajaCartas[0].Palo}] ";
                    for (int j = barajaCartas.Count - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            cartaSaque.Add(barajaCartas[j]);
                            barajaCartas.Remove(barajaCartas[j]);
                        }
                    }
                }
                return cartas;
            }
            return "No hay mas cartas";
        }
        public string CartasMonton()
        {
            string cartas = "";
            if (cartaSaque.Count > 0)
            {
                foreach (var carta in cartaSaque)
                {
                    cartas += $"[{carta.Numero}|{carta.Palo}] ";
                }
                return cartas;
            }
            return "No hay cartas que ya salieron";
        }
        public string MostrarCartas()
        {
            string cartas = "";
            if (barajaCartas.Count > 0)
            {
                foreach (var carta in barajaCartas)
                {
                    cartas += $"[{carta.Numero}|{carta.Palo}] ";
                }
                return cartas;
            }
            return "no hay mas cartas";
        }
    }

    internal class BarajaEspañola : Baraja<PalosEspañola>
    {
        private bool incluir8y9;
        public BarajaEspañola(bool incluir8y9)
        {
            this.incluir8y9 = incluir8y9;
            CrearBaraja();
        }

        public override void CrearBaraja()
        {
            foreach (PalosEspañola palo in Enum.GetValues(typeof(PalosEspañola))) //recorre un tipo de palo y despues pasa al siguiente. Ej ciclo1 oros y da 13 vueltas, pasa al ciclo 2 copas y da 13 vueltas
            {
                for (int i = 1; i <= 12; i++)
                {
                    if (incluir8y9 == true)
                    {
                        barajaCartas.Add(new Carta<PalosEspañola>(i, palo));
                    }
                    else if (incluir8y9 == false && i != 8 && i != 9)
                    {
                        barajaCartas.Add(new Carta<PalosEspañola>(i, palo));
                    }
                }
            }
        }
    }

    internal class BarajaFrancesa : Baraja<PalosFrancesa>
    {
        public BarajaFrancesa()
        {
            CrearBaraja();
        }

        public override void CrearBaraja()
        {
            foreach (PalosFrancesa palo in Enum.GetValues(typeof(PalosFrancesa)))  //recorre un tipo de palo y despues pasa al siguiente. Ej ciclo1 diamantes y da 13 vueltas, pasa al ciclo 2 picas y da 13 vueltas
            {
                for (int i = 1; i <= 13; i++)
                {
                    barajaCartas.Add(new Carta<PalosFrancesa>(i, palo));
                }
            }
        }

        public bool EsCartaRoja(Carta<PalosFrancesa> carta)
        {
            if (carta.Palo == PalosFrancesa.corazones || carta.Palo == PalosFrancesa.diamantes)
            {
                return true;
            }
            return false;
        }

        public bool EsCartaNegra(Carta<PalosFrancesa> carta)
        {
            if (carta.Palo == PalosFrancesa.picas || carta.Palo == PalosFrancesa.treboles)
            {
                return true;
            }
            return false;
        }
    }
}
