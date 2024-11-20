using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer12
{
    internal class Juego
    {
        private List<Jugador> jugadores;
        private Revolver revolver;
        public Juego(List<Jugador> jugadores) 
        {
            this.jugadores = jugadores;
            this.revolver = new Revolver();
        }
        public bool FinJuego()
        {
            foreach (var jugador in jugadores)
            {
                if (!jugador.Vivo)
                {
                    return true; 
                }
            }
            return false;
        }
        public void Ronda()
        {
            foreach (var jugador in jugadores)
            {
                Console.WriteLine($"{jugador.Nombre} se apunta y dispara");
                jugador.Disparar(revolver); 

                if (jugador.Vivo)
                {
                    Console.WriteLine($"{jugador.Nombre} no murio en esta ronda");
                }
                else
                {
                    Console.WriteLine($"{jugador.Nombre} murio");
                    break;
                }

                revolver.SiguienteBala();
            }
        }
    }
}
