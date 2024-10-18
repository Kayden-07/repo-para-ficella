using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9
{
    internal class SalaCine
    {
        private string peliActual;
        private int precioPeli;
        private Asiento[,] asientos; //creo una matriz
        private Pelicula pelicula;
        public string PeliActual
        {
            get { return peliActual; }
            set { peliActual = value; }
        }
        public int PrecioPeli
        {
            get { return precioPeli; }
            set { precioPeli = value; }
        }

        public SalaCine(string peliActual, int precioPeli, Pelicula pelicula)
        {
            this.pelicula = pelicula;
            this.peliActual = peliActual;
            this.precioPeli = precioPeli;
            asientos = new Asiento[8, 9];
            PonerAsientos();
        }
        public void PonerAsientos()
        {
            char[] columnas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    asientos[i, j] = new Asiento(8 - i, columnas[j]);
                }
            }
        }
        public void MostrarAsientos()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Asiento asiento = asientos[i, j];
                    if (asiento.Ocupado)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[X] ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"[{asiento.Fila}{asiento.Columna}]");
                    }
                }
                Console.WriteLine();
            }
        }
        public bool AsignarAsiento(Espectador espectador)
        {
            var guia = Guid.NewGuid();
            var SoloNumeros = new String(guia.ToString().Where(Char.IsDigit).ToArray());
            var semilla = int.Parse(SoloNumeros.Substring(0, 4));
            Random random = new Random(semilla);
            bool estaSentado = false;

            if (espectador.Edad < pelicula.EdadMinima)
            {
                return false;
            }
            if (espectador.Dinero < precioPeli)
            {
                return false;
            }
            while (!estaSentado) 
            {
                int i = random.Next(1, 8);
                int j = random.Next(1, 9);
                if (!asientos[i, j].Ocupado)
                {
                    estaSentado = true;
                    asientos[i, j].Ocupado = true;
                    return true;
                }
            }
            return false;
        }
    }
}

