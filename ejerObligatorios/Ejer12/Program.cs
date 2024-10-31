using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();

            for (int i = 0; i < 6; i++)
            {
                jugadores.Add(new Jugador(i));
            }

            Juego juego = new Juego(jugadores);

            while (!juego.FinJuego())
            {
                juego.Ronda();
            }

            Console.WriteLine("El juego termino");

            Console.ReadKey();
        }
    }
}
