using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5. Crear un programa que simule un juego de ahorcado, en el que el usuario 
             * debe adivinar una palabra oculta letra por letra*/

            ConsoleKeyInfo caracter;
            String palabraOculta = "hola";
            int guiones = palabraOculta.Length;
            List<char> letras = new List<char>();

            for (int i = 0; i < palabraOculta.Length; i++)
            {
                letras.Add('_');
                Console.Write(letras[i]);
            }
            Console.WriteLine();

            while (true)
            {
                Console.Write("Ponga una letra: ");
                caracter = Console.ReadKey();
                Console.WriteLine();

                for (int j = 0; j < palabraOculta.Length; j++)
                {
                    if (caracter.KeyChar == palabraOculta[j])
                    {
                        letras[j] = caracter.KeyChar;
                    }
                }
                foreach (char c in letras)
                {
                    Console.Write(c);
                }

                if (!letras.Contains('_'))
                {
                    Console.WriteLine("¡Encontraste la palabra!");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}