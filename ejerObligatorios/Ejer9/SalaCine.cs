using System;
using System.Collections.Generic;
using System.Linq;
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
        public SalaCine(string peliActual, int precioPeli)
        {
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
                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.Write($"[{asiento.Fila}{asiento.Columna}]");
                    }
                }
                Console.WriteLine();
            }
        }
        public bool AsignarAsiento(Espectador espectador)
        {
            if (espectador.Edad < pelicula.EdadMinima)
            {
                return false;
            }
            if (espectador.Dinero < precioPeli)
            {
                return false;
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!asientos[i, j].Ocupado)
                    {
                        asientos[i, j].Ocupado = true;
                        return true;
                    }
                }
            }
            Console.WriteLine("No hay asientos disponibles.");
            return false;
        }
    }
}

