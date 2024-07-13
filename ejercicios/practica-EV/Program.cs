using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_EV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9. Crear un programa que permita al usuario calcular la distancia entre 
             * dos puntos en un plano cartesiano.*/

            Console.Write("Ingrese la coordenada x del primer punto: ");
            double X1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la coordenada y del primer punto: ");
            double Y1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la coordenada x del segundo punto: ");
            double X2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la coordenada y del segundo punto: ");
            double Y2 = double.Parse(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            //Math.Pow es para la potencia
            //Math.Sqrt es para la raiz cuadrada

            Console.Write("La distancia es " + distancia);

            Console.ReadKey();
        }
    }
}
