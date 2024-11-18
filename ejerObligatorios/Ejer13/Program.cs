using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial1 = new Comercial("Laura", 25, 1200, 300);
            Comercial comercial2 = new Comercial("Carlos", 35, 1500, 300);

            Repartidor repartidor1 = new Repartidor("Ana", 22, 1000, "zona 3");
            Repartidor repartidor2 = new Repartidor("Luis", 30, 1100, "zona 3");

            comercial1.PonerPlus();
            comercial2.PonerPlus();
            repartidor1.PonerPlus();
            repartidor2.PonerPlus();

            Console.WriteLine(comercial1.Salario);
            Console.WriteLine(comercial2.Salario);
            Console.WriteLine(repartidor1.Salario);
            Console.WriteLine(repartidor2.Salario);
            Console.ReadKey();
        }
    }
}
