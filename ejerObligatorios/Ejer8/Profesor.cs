using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8
{
    internal class Profesor : Persona
    {
        private string materiaAsig;
        public string MateriaAsig
        {
            get { return materiaAsig; }
            set { materiaAsig = value; }
        }

        public Profesor () : base ()
        {
            base.Edad = random.Next(25, 60);
            this.MateriaAsig = ObtenerMateria();
        }
        private string ObtenerMateria()
        {
            int quemateria = random.Next(0, 3);
            if (quemateria == 0)
            {
                return "matematica";
            }
            else if (quemateria == 1)
            {
                return "filosofia";
            }
            else
            {
                return "fisica";
            }
        }
        public override bool SaberFalta()
        {
            return random.Next(0, 5) == 0; 
        }
    }
}
