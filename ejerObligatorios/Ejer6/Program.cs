using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro("Caidos del mapa", "Jonathan", 1234567, 140);
            Libro libro2 = new Libro("Arsene Lupin", "Manuel", 8544485, 39);
            libro.DetallesLibro();
            libro2.DetallesLibro();

            if (libro.NumeroPaginas > libro2.NumeroPaginas)
            {
                Console.WriteLine("El libro " + libro.Titulo + " tiene mas paginas");
            } 
            else
            {
                Console.WriteLine("El libro " + libro2.Titulo + " tiene mas paginas");
            }

            Console.ReadKey();
        }
    }
}
