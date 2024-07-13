using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Crear un programa que genere una lista de números primos hasta un número 
             * ingresado por el usuario.*/

            List<int> list = new List<int>();
            int numero_limite;

            Console.Write("Elija el límite de la lista de números primos: ");
            numero_limite = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numero_limite; i++)
            {
                bool esPrimo = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                    }
                }

                if (esPrimo)
                {
                    list.Add(i);
                }
            }

            Console.WriteLine("Lista de números primos hasta " + numero_limite + ":");
            foreach (var numero in list)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
