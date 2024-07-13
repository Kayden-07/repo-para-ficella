using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Crear un programa que calcule el promedio de un conjunto de números 
             * ingresados por el usuario.*/

            List<float> list = new List<float>();
            float promedio, cant_numeros, numero_agregar, suma = 0;

            Console.Write("Cuantos numeros queres?: ");
            cant_numeros = float.Parse(Console.ReadLine());

            for (int i = 0; i < cant_numeros; i++)
            {
                Console.Write("Ingrese el numero " + (i + 1) + ": ");
                numero_agregar = float.Parse(Console.ReadLine());
                list.Add(numero_agregar);
                suma += numero_agregar;
            }
            promedio = suma / list.Count;
            Console.Write("El promedio de todos los numeros es de " + promedio);
            Console.ReadKey();
        }
    }
}
