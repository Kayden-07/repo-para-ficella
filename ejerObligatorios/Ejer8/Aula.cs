using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8
{
    internal class Aula
    {
        public List<Estudiante> estudiantes = new List<Estudiante>();
        private int identificador, maxEstudiante, cantEstudiantes, aprobadosHombres = 0, aprobadosMujeres = 0;

        private string destinacion;
        public Profesor profesor;
        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
        public int MaxEstudiante
        {
            get { return maxEstudiante; }
            set { maxEstudiante = value; }
        }
        public string Destinacion
        {
            get { return destinacion; }
            set { destinacion = value; }
        }
        public Aula (int identificador, int maxEstudiante ,string destinacion)
        {
            this.identificador = identificador;
            this.maxEstudiante = maxEstudiante;
            this.destinacion = destinacion;
        }
        public void EmpezarDia()
        {
            profesor = new Profesor();

            for (int i = 1; i <= this.maxEstudiante; i++)
            {
                Estudiante estudiante = new Estudiante();
                estudiantes.Add(estudiante);
            }   
        }
        public bool SePuedeClase ()
        {
            if (profesor.SaberFalta())
            {
                Console.WriteLine("El profesor faltó, no hay clases");
                return false;
            }
            if (profesor.MateriaAsig != this.destinacion)
            {
                Console.WriteLine("El profesor no es de la materia, no puede dar clases");
                return false;
            }
            int estudiantePresentes = 0;
            foreach (Estudiante estudiante in estudiantes)
            {
                if (!estudiante.SaberFalta())
                {
                    estudiantePresentes++;
                }
            }
            if (estudiantePresentes < (maxEstudiante / 2))
            {
                Console.WriteLine("Falta mas de la mitad de estudiantes, no hay clases");
                return false;
            }
            else
            {
                foreach (Estudiante aprobados in estudiantes)
                {
                    if (aprobados.Sexo == "mujer" && aprobados.Calificacion >= 6)
                    {
                        aprobadosMujeres++;
                    }
                    if (aprobados.Sexo == "hombre" && aprobados.Calificacion >= 6)
                    {
                        aprobadosHombres++;
                    }
                }
                Console.WriteLine("Hay " + aprobadosMujeres + " mujeres aprobadas");
                Console.WriteLine("Hay " + aprobadosHombres + " hombres aprobados");
                return true;
            }
        }
    }
}
