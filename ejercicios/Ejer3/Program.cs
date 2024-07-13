using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Crear un programa que simule un juego de adivinanza de números, en el que el usuario 
             * debe adivinar un número generado aleatoriamente por el programa.*/

            Random aleatorio = new Random();

            int numero_random = aleatorio.Next(1, 100), respuesta;
            Console.WriteLine(numero_random);
            string pregunta = "";

            do {
                Console.Write("Elija un numero entre el 1 y el 100: ");
                respuesta = int.Parse(Console.ReadLine());

                if (respuesta != numero_random)
                {
                    Console.Write("Fallaste, otro intento? (si/no): ");
                    pregunta = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Acertaste");
                    break;
                }
            } while (pregunta == "si");
            Console.ReadKey();
        }
    }
}
