using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja1 = new Baraja();

            baraja1.Barajar();

            foreach (var carta in baraja1.barajaCartas)
            {
                Console.Write($"[{carta.Numero}|{carta.Palo}] ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write(baraja1.SiguienteCarta());
            Console.Write(baraja1.DarCartas(5));

            Console.WriteLine();
            Console.WriteLine();

            foreach (var carta in baraja1.barajaCartas)
            {
                Console.Write($"[{carta.Numero}|{carta.Palo}] ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}