using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer16
{
    internal class Contacto
    {
        private string nombre, telefono;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public Contacto(string nombre, string telefono) 
        { 
            this.nombre = nombre;
            this.telefono = telefono;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Telefono: {Telefono}";
        }
    }
}
