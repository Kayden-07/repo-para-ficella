using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices raices1 = new Raices(1, 5, 6);
            raices1.calcular();
            Console.ReadKey();
        }
    }
}
