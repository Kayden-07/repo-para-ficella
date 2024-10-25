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

            Console.WriteLine();
            Console.WriteLine();

            Console.Write(baraja1.MostrarCartas());

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine();

            Console.Write(baraja1.CartasMonton());

            Console.ReadKey();
        }
    }
}