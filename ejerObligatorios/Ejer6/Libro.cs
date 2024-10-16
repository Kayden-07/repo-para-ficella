using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6
{
    internal class Libro
    {
        private int isbn, numeroPaginas;
        private string titulo, autor;
        public int ISBN 
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }
        public Libro(string titulo, string autor, int isbn, int numeroPaginas) 
        { 
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.numeroPaginas = numeroPaginas;
        }
        public void DetallesLibro()
        {
            Console.WriteLine("El libro " + this.titulo + " con ISBN " + 
            this.isbn + " creado por el autor " + this.autor + " tiene " + this.numeroPaginas + " paginas");
        }
    }
}
