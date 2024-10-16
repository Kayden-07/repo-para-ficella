using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    internal class Raices
    {
        private double a, b, c, discriminante;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b; 
            this.c = c;
            discriminante = Math.Pow(b, 2) - 4 * a * c;
        }
        public void ObtenerRaices ()
        {
            if (this.discriminante > 0)
            {
                double raiz1 = (-b + Math.Sqrt(this.discriminante)) / (2 * a); //Math.Sqr() es par calcular la raiz cuadrada
                double raiz2 = (-b - Math.Sqrt(this.discriminante)) / (2 * a);
                Console.WriteLine("Las dos soluciones son:");
                Console.WriteLine("Raíz 1: " + raiz1);
                Console.WriteLine("Raíz 2: " + raiz2);
            } 
        }
        public void ObtenerRaiz ()
        {
            if (this.discriminante == 0)
            {
                double raizUnica = -b / (2 * a);
                Console.WriteLine("La unica raiz es: " + raizUnica);
            } 
        }
        public double getDiscriminante()
        {
            return discriminante;
        }
        public bool tieneRaices()
        {
            return getDiscriminante() > 0;
        }
        public bool tieneRaiz()
        {
            return getDiscriminante() == 0;
        }
        public void calcular()
        {
            if (this.discriminante < 0)
            {
                Console.WriteLine("No tiene solución real");
            }
            else if (this.discriminante == 0)
            {
                this.ObtenerRaiz();
            }
            else
            {
                this.ObtenerRaices();
            }
        }
    }
}
