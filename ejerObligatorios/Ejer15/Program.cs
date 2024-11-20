using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen(3, 2);

            Bebidas agua1 = new AguaMineral(1, 1.5, 100, "Agua Natural", "Fuente A");
            Bebidas agua2 = new AguaMineral(2, 2, 120, "Agua Natural", "Fuente B");
            Bebidas soda1 = new Azucarada(3, 1, 150, "Coca-Cola", 10.5, true);
            Bebidas soda2 = new Azucarada(4, 0.5, 110, "Fanta", 8, false);

            almacen.AgregarProducto(agua1);
            almacen.AgregarProducto(agua2);
            almacen.AgregarProducto(soda1);
            almacen.AgregarProducto(soda2);

            Console.WriteLine("Informacion de todos los productos en el almacen:");
            almacen.MostrarInfo();

            double precioTotal = almacen.CalcularPrecioTotal();
            Console.WriteLine($"El precio total del almacen es: {precioTotal}");

            double precioMarca = almacen.CalcularPrecioPorMarca("Coca-Cola");
            Console.WriteLine($"El precio total de productos con la marca 'Coca-Cola' es: {precioMarca}");

            double precioEstanteria = almacen.CalcularPrecioPorEstanteria(1); 
            Console.WriteLine($"El precio total de la estanteria 1 (columna 1) es: {precioEstanteria}");

            Console.WriteLine("Eliminar el producto con ID 3:");
            almacen.EliminarProducto(3); 

            Console.WriteLine("Informacion de todos los productos despues de eliminar:");
            almacen.MostrarInfo();

            Console.ReadKey();
        }
    }
}
