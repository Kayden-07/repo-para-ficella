using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10
{
    internal class Baraja
    {
        public List<Carta> barajaCartas = new List<Carta>();
        private List<Carta> cartaSaque = new List<Carta>();
        Random random = new Random();
        public Baraja() 
        {
            CrearBaraja();
        }
        private void CrearBaraja ()
        {
            for (int i = 1; i <= 12; i++)
            {
                if (i != 8 && i != 9)
                {
                    Carta carta = new Carta(i, "O");
                    barajaCartas.Add(carta);
                    carta = new Carta(i, "C");
                    barajaCartas.Add(carta);
                    carta = new Carta(i, "E");
                    barajaCartas.Add(carta);
                    carta = new Carta(i, "B");
                    barajaCartas.Add(carta);
                }
            }
        }
        public void Barajar()
        {
            Carta cartaguardada = new Carta(0, "na");
            int numRand;
            for (int i = barajaCartas.Count - 1; i >= 0; i--)
            {
                numRand = random.Next(0, barajaCartas.Count);
                cartaguardada = barajaCartas[i];
                barajaCartas[i] = barajaCartas[numRand];
                barajaCartas[numRand] = cartaguardada;
            }
            numRand = 0;
        }
        public string SiguienteCarta()
        {
            if (barajaCartas.Count != 0)
            {
                for (int i = barajaCartas.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        cartaSaque.Add(barajaCartas[i]);
                        barajaCartas.Remove(barajaCartas[i]);
                    }
                }
                for (int i = cartaSaque.Count - 1; i >= 0; i--)
                {
                    if (i == cartaSaque.Count - 1)
                    {
                        return $"[{cartaSaque[i].Numero}|{cartaSaque[i].Palo}] ";
                    }
                }
            }
            return "No hay mas cartas";
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
                        if(j == 0)
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
    }
}
