using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    internal class Serie
    {
        private const int temporadasEstablecido = 3;
        private const bool entregadoEstablecido = false;
        private const string tituloEstablecido = "Sin titulo";
        private const string generoEstablecido = "Sin genero";
        private const string creadorEstablecido = "Anonimo";
        private string titulo, genero, creador;
        private int numTemporadas;
        private bool entregado;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Creador
        {
            get { return creador; }
            set { creador = value; }
        }
        public int NumTemporadas
        {
            get { return numTemporadas; }
            set { numTemporadas = value; }
        }
        public Serie()
        {
            this.numTemporadas = temporadasEstablecido;
            this.entregado = entregadoEstablecido;
            this.titulo = tituloEstablecido;
            this.genero = generoEstablecido;
            this.creador = creadorEstablecido;
        }
        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.genero = generoEstablecido;
            this.numTemporadas = temporadasEstablecido;
            this.entregado = entregadoEstablecido;
        }
        public Serie(string titulo, string creador, string genero, int numTemporadas)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.genero = genero;
            this.numTemporadas = numTemporadas;
            this.entregado = entregadoEstablecido;
        }
        public void Entregar()
        {
            entregado = true;
        }
        public void Devolver()
        {
            entregado = false;
        }
        public bool IsEntregado()
        {
            return entregado;
        }
        public int CompareTo(int NumTemporadas)
        {
            return this.NumTemporadas.CompareTo(NumTemporadas);
        }
    }
}
