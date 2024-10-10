using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    internal class Videojuego
    {
        private const double horasEstimadasEstablecido = 10;
        private const bool entregadoEstablecido = false;
        private const string tituloEstablecido = "Sin titulo";
        private const string generoEstablecido = "Sin genero";
        private const string companiaEstablecido = "Sin compañia";
        private string titulo, genero, compania;
        private double horasEstimadas;
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
        public string Compania
        {
            get { return compania; }
            set { compania = value; }
        }
        public double HorasEstimadas
        {
            get { return horasEstimadas; }
            set { horasEstimadas = value; }
        }
        public Videojuego()
        {
            this.titulo = tituloEstablecido;
            this.genero = generoEstablecido;
            this.compania = companiaEstablecido;
            this.horasEstimadas = horasEstimadasEstablecido;
            this.entregado = entregadoEstablecido;
        }
        public Videojuego(string titulo, double horasEstimadas)
        {
            this.titulo = titulo;
            this.genero = generoEstablecido;
            this.compania = companiaEstablecido;
            this.horasEstimadas = horasEstimadas;
            this.entregado = entregadoEstablecido;
        }
        public Videojuego(string titulo, double horasEstimadas, string genero, string compania)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.compania = compania;
            this.horasEstimadas = horasEstimadas;
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
        public int CompareTo(int horasEstimadas)
        {
            return this.horasEstimadas.CompareTo(horasEstimadas);
        }
    }
}
