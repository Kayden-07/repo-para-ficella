using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaCine sala = new SalaCine("Rosa", 134);
            Pelicula pelicula = new Pelicula("Avengers", 180, 13, "Joss Whedon");
            sala.MostrarAsientos();
            Console.Write("");
            for (int i = 0; i < 10; i++) 
            { 
                Espectador espectador = new Espectador();
                sala.AsignarAsiento(espectador);
            }
            Console.ReadKey();
        }
    }
}
