using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9
{
    internal class Espectador
    {
        private Random random = new Random();
        private string nombre;
        private int edad, dinero;
        private static List<string> nombresDisponibles = new List<string>
        {
            "Juan", "María", "Pedro", "Ana", "Carlos", "Lucía", "José", "Laura", "Miguel", "Elena"
        };
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }
        public Espectador() 
        {
            this.nombre = GenerarNombreAleatorio();
            this.edad = random.Next(7, 21);
            this.dinero = random.Next(100, 170);
        }
        private string GenerarNombreAleatorio()
        {
            int nombreAleat = random.Next(nombresDisponibles.Count);
            return nombresDisponibles[nombreAleat];
        }
    }
}
