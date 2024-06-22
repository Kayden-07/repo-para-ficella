using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gin4_510
{

    public class Copo
    {
        public int col = 0;
        public int fila = 0;

        public Copo(int col, int fila)
        {
            this.col = col;
            this.fila = fila;
        }

    }

    internal class Program
    {
        static TimeSpan trans;
        static DateTime h1 = DateTime.Now;
        static DateTime h2 = DateTime.Now;
        static int fila = 0;
        static int columna = 0;
        static List<Copo> copitos = new List<Copo>();
        static int limite_fila = 20;
        static int limite_col = 11;


        static bool bajar(Copo c)
        {
            bool estado = false;
            if (c.fila < limite_fila)
            {
                estado = true;
            }
            foreach (Copo cop in copitos)
            {
                if (c.col == cop.col && c.fila + 1 == cop.fila)
                {
                    estado = false;
                }
            }
            return estado;
        }

        static bool tetris()
        {
            bool estado = false;
            int llenar = 0;

            foreach (Copo cop in copitos)
            {
                if (cop.fila == limite_fila)
                {
                    llenar++;
                }
            }

            if (llenar == limite_col - 1)
            {
                estado = true;
            }

            return estado;
        }

        static void Main(string[] args)
        {
            Copo a1;
            Random r = new Random();
            columna = r.Next(1, limite_col);
            Console.CursorVisible = false;

            a1 = new Copo(r.Next(1, limite_col), 1);
            copitos.Add(a1);

            while (true)
            {
                h2 = DateTime.Now;
                trans = h2 - h1;

                if (trans.Milliseconds > 100)
                {
                    a1 = new Copo(r.Next(1, limite_col), 1);
                    copitos.Add(a1);
                    foreach (Copo c in copitos)
                    {
                        if (bajar(c))
                        {
                            Console.SetCursorPosition(c.col, c.fila);
                            Console.Write(" ");
                            c.fila++;
                            Console.SetCursorPosition(c.col, c.fila);
                            Console.Write("*");
                        }
                    }
                    if (tetris())
                    {
                        copitos.RemoveAll(c => c.fila == limite_fila);
                        for (int i = 0; i < limite_col - 1; i++)
                        {
                            Console.SetCursorPosition(i, limite_fila);
                            Console.Write(" ");
                        }
                    }
                    h1 = h2;
                }
            }

        }

    }
}

