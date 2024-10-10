using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3
{
    internal class Program
    {
        public class Password
        {
            private const int longitudEstablecida = 8;
            private int longitud;
            private string contrasena;

            public int Longitud { get { return longitud; } set { longitud = value; } }
            public string Contrasena { get { return contrasena;} }

            public Password()
            {
                this.Longitud = longitudEstablecida;
                this.contrasena = GenerarPassword(longitud);
            }
            public Password(int longitud)
            {
                this.Longitud = longitud;
                this.contrasena = GenerarPassword(longitud);
            }
            

            public string GenerarPassword(int longitud)
            {

                int digitoMax = (int)Math.Pow(10, longitud) - 1; //el Math.Pow es para hace potencia
                int digitoMin = (int)Math.Pow(10, longitud -1); // 10 a la (8 - 1) es igual a 10000000 (8 caracteres)

                Random numeroRandom = new Random();
                int contrasenaRandom = numeroRandom.Next(digitoMin, digitoMax);

                return contrasenaRandom.ToString();
            }
        }
        static void Main(string[] args)
        {
            Password password = new Password();
            Console.WriteLine(password.Contrasena);
            Console.ReadKey();
        }
    }
}
