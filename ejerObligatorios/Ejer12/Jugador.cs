using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer12
{
    internal class Jugador
    {
        private int id;
        private string nombre;
        private bool vivo;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre 
        { 
            get { return nombre; } 
            set { nombre = value; } 
        }
        public bool Vivo 
        {
            get { return vivo; }
            set { vivo = value; } 
        }
        public Jugador(int id) 
        {
            this.id = id;
            this.nombre = "Jugador " + (id + 1); 
            this.vivo = true;
        }
        public bool Disparar(Revolver revolver)
        {
            if (!vivo)
            {
                return false; 
            }

            bool resultado = revolver.Disparar(); 

            if (resultado)
            {
                this.vivo = false;
            }
            return resultado; 
        }
    }
}
