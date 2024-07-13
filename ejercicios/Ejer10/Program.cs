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
            /*10. Crear un programa que permita al usuario convertir una cantidad de una unidad
             * de medida a otra, por ejemplo, de metros a pies.*/

            Console.WriteLine("Pasar de metros a pies");
            Console.Write("Ingrese los metros: ");
            double metros = double.Parse(Console.ReadLine());

            double pies = metros * 3.28;

            Console.WriteLine(metros + " metros son " + pies + " pies");
            Console.ReadKey();
        }
    }
}
