using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8
{
    internal class Estudiante : Persona
    {

        private int calificacion;


        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public Estudiante() : base() 
        {
            this.calificacion = random.Next(1, 11);
        }
        public override bool SaberFalta()
        {
            return random.Next(0, 2) == 0; // 50% de faltar
        }
    }
}

