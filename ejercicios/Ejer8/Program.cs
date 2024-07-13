using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> libros = new List<string> { "bella", "anchoa", "delfin", "perro", "marmota" };
            List<string> prestados = new List<string>();
            List<string> nombres = new List<string>();
            List<string> DNIS = new List<string>();

            string pregunta, accion, busqueda, nombre, DNI;
            bool encontrado = false;

            do
            {
                Console.Write("¿Quieres ver libros, prestar, prestados o devueltos?: ");
                accion = Console.ReadLine();

                if (accion == "libros")
                {
                    Console.WriteLine("¿Qué libro quieres buscar?: ");
                    busqueda = Console.ReadLine();

                    if (libros.Contains(busqueda))
                    {
                        Console.WriteLine("Ese libro está disponible.");
                    }
                    else if (prestados.Contains(busqueda))
                    {
                        Console.WriteLine("Ese libro está prestado.");
                    }
                    else
                    {
                        Console.WriteLine("Ese libro no está en la biblioteca.");
                    }
                }
                else if (accion == "prestar")
                {
                    Console.WriteLine("¿Qué libro quieres prestar?: ");
                    busqueda = Console.ReadLine();

                    if (libros.Contains(busqueda))
                    {
                        Console.WriteLine("Nombre de a quien se lo quieres prestar: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("DNI de la persona: ");
                        DNI = Console.ReadLine();

                        nombres.Add(nombre);
                        DNIS.Add(DNI);
                        prestados.Add(busqueda);
                        libros.Remove(busqueda);

                        Console.WriteLine("Libro prestado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Ese libro no está disponible para prestar.");
                    }
                }
                else if (accion == "prestados")
                {
                    Console.WriteLine("Libros prestados: ");
                    foreach (var item in prestados)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (accion == "devueltos")
                {
                    Console.WriteLine("¿Qué libro están devolviendo?: ");
                    busqueda = Console.ReadLine();

                    if (prestados.Contains(busqueda))
                    {
                        libros.Add(busqueda);
                        prestados.Remove(busqueda);

                        Console.WriteLine("Libro devuelto con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Ese libro no está en la lista de prestados.");
                    }
                }
                else
                {
                    Console.WriteLine("Acción no reconocida.");
                }

                Console.Write("¿Quieres ver más cosas? (si/no): ");
                pregunta = Console.ReadLine();
            } while (pregunta == "si");

            Console.ReadKey();
        }
    }
}
