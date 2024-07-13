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
            /*7. Crear un programa que permita al usuario ingresar una serie de números y determine 
             * cuál es el número más grande y cuál es el número más pequeño.*/

            List<int> list = new List<int>();

            int numero, cant_numeros;

            Console.Write("Cuantos numeros queres que tenga la lista?: ");
            cant_numeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < cant_numeros; i++)
            {
                Console.Write("Ingrese un numero (diferente al anterior): ");
                numero = int.Parse(Console.ReadLine());
                list.Add(numero);
            }

            int mayor = list[0], menor = list[0];

            foreach (int num in list)
            {
                if (num < menor)
                {
                    menor = num;
                }
                if (num > mayor)
                {
                    mayor = num;
                }
            }
            Console.WriteLine("El numero mas chico es: " + menor);
            Console.WriteLine("El numero mas grande es: " + mayor);
            Console.ReadKey();
        }
    }
}
