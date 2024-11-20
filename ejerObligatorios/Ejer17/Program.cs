using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Baraja Española
            var barajaEspañola = new BarajaEspañola(false); 
            barajaEspañola.Barajar();
            Console.WriteLine("Baraja Española:");
            var cartaEspañola = barajaEspañola.SiguienteCarta();
            Console.WriteLine(cartaEspañola.ToString());

            var barajaFrancesa = new BarajaFrancesa();
            barajaFrancesa.Barajar();
            Console.WriteLine("Baraja Francesa:");
            var cartaFrancesa = barajaFrancesa.SiguienteCarta();
            Console.WriteLine(cartaFrancesa.ToString()); 

            if (cartaFrancesa != null)
            {
                if (barajaFrancesa.EsCartaRoja(cartaFrancesa))
                {
                    Console.WriteLine("Es carta roja");
                }
                else
                {
                    Console.WriteLine("Es carta negra");
                }
            }
            Console.ReadKey();
        }
    }
}

