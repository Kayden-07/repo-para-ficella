using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Productos[] productos = new Productos[]
             {
                new Perecedero("Leche", 1200, 2),
                new Perecedero("Yogurt", 900, 1),
                new Perecedero("Queso", 1400, 3),
                new NoPerecedero("Arroz", 1500, "Alimento seco"),
                new NoPerecedero("Lata de Tomate", 1500, "Conserva")
             };

            int cantidad = 5;
            double precioTotal = 0;

            foreach (Productos producto in productos)
            {
                double precioProducto = producto.Calcular(cantidad);
                Console.WriteLine($"Producto: {producto.Nombre}, Precio total por {cantidad} unidades: {precioProducto}");
                precioTotal += precioProducto;
            }

            Console.WriteLine($"Precio total de todos los productos (5 unidades de cada uno): {precioTotal}");
            Console.ReadKey();
        }
    }
}
