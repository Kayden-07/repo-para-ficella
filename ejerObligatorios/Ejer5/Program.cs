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
            int videojuegosEntregados = 0;
            int seriesEntregadas = 0;

            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];
            series[0] = new Serie();
            series[1] = new Serie("Hellow kitty", "Maeia becerra");
            series[2] = new Serie("Los Simpsoms", "Luigi");
            series[3] = new Serie();
            series[4] = new Serie("Ben 10", "Cartein Howarks");

            videojuegos[0] = new Videojuego("Hollow Knight", 15);
            videojuegos[1] = new Videojuego();
            videojuegos[2] = new Videojuego();
            videojuegos[3] = new Videojuego("Minecraft", 40);
            videojuegos[4] = new Videojuego();

            videojuegos[2].Entregar();
            videojuegos[3].Entregar();
            series[4].Entregar();
            series[0].Entregar();
            series[2].Entregar();

            foreach (var i in videojuegos)
            {
                if (i.IsEntregado())
                {
                    videojuegosEntregados++;
                }
            }

            foreach (var i in series)
            {
                if (i.IsEntregado())
                {
                    seriesEntregadas++;
                }
            }

            Console.WriteLine(videojuegosEntregados);
            Console.WriteLine(seriesEntregadas);
            Console.ReadKey();
        }
    }
}
