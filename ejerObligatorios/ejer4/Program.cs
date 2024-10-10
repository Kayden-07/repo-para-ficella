using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalTelevisiones = 0;
            double totalLavadoras = 0;
            double totalElectrodomesticos = 0;

            Electrodomestico[] productos = new Electrodomestico[10]; // creo array de 10 posiciones
            productos[0] = new Electrodomestico(120, 3, "neGro", 'D');
            productos[1] = new Lavadora(40, 4, "Blanco", 'F', 12);
            productos[2] = new Television (400, 40, "Rojo", 'D', 50, true);
            productos[3] = new Lavadora(45, 5, "Gris", 'E', 15);
            productos[4] = new Television(300, 30, "Azul", 'C', 42, false);
            productos[5] = new Electrodomestico(150, 2, "Blanco", 'B');
            productos[6] = new Lavadora(60, 6, "Negro", 'A', 18);
            productos[7] = new Television(500, 50, "Verde", 'A', 60, true);
            productos[8] = new Electrodomestico(200, 5, "Rojo", 'C');
            productos[9] = new Lavadora(70, 7, "Azul", 'B', 20);

            foreach (Electrodomestico i in productos)
            {
                Console.WriteLine(i.PrecioFinal());
                double precio = i.PrecioFinal();
                if (i is Television)
                {
                    totalTelevisiones += precio;
                }
                else if (i is Lavadora) //comparo si es de tipo Lavadora
                {
                    totalLavadoras += precio;
                }
                totalElectrodomesticos += precio;
            }
            Console.WriteLine("Precio total Televisiones: " + totalTelevisiones);
            Console.WriteLine("Precio total Lavadoras: " + totalLavadoras);
            Console.WriteLine("Precio total Electrodomésticos: " + totalElectrodomesticos);
            Console.ReadKey();
        }
    }
}
