using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8
{
    internal class Persona
    {
        protected static Random random = new Random();
        private string nombre, sexo;
        private int edad;
        private bool falta;
        private static List<string> nombresDisponibles = new List<string>
        {
            "Juan", "María", "Pedro", "Ana", "Carlos", "Lucía", "José", "Laura", "Miguel", "Elena"
        };

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public bool Falta
        {
            get { return falta; }
            set { falta = value; }
        }
        public Persona() 
        {
            this.sexo = ObtenerSexo();
            this.Nombre = GenerarNombreAleatorio();
            this.falta = SaberFalta();
            this.edad = random.Next(12, 19);
        }
        private string ObtenerSexo()
        {
            int NumSexo = random.Next(0, 2);
            if (NumSexo == 0)
            {
                return "hombre";
            }
            else
            {
                return "mujer";
            }
        }
        public virtual bool SaberFalta()
        {
            return random.Next(0, 5) == 0;
        }
        private string GenerarNombreAleatorio()
        {
            int nombreAleat = random.Next(nombresDisponibles.Count);
            return nombresDisponibles[nombreAleat];
        }
    }
}
