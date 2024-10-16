using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9
{
    internal class Pelicula
    {
        private string titulo, director;
        private int edadMinima, duracion;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public int EdadMinima
        {
            get { return edadMinima; }
            set { edadMinima = value; }
        }
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public Pelicula(string titulo, int duracion, int edadMinima, string director) 
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
        }
    }
}
