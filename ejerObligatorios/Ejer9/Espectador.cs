using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9
{
    internal class Espectador
    {
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
            GeneracionAleatoria();
        }
        private void GeneracionAleatoria()
        {
            //La generacion aleatoria me la explico muriel
            var guia = Guid.NewGuid();
            var SoloNumeros = new String(guia.ToString().Where(Char.IsDigit).ToArray()); 
            var semilla = int.Parse(SoloNumeros.Substring(0,4)); 
            Random random = new Random(semilla);
            int nombreAleat = random.Next(nombresDisponibles.Count);
            nombre = nombresDisponibles[nombreAleat];
            edad = random.Next(7, 21);
            dinero = random.Next(100, 170);
        }
    }
}
