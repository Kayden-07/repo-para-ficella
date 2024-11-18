using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer15
{
    internal class Almacen
    {
        private Bebidas[,] estanterias;
        public Almacen(int filas, int columnas) 
        {
            estanterias = new Bebidas[filas, columnas];
        }
        public double CalcularPrecioTotal()
        {
            double total = 0;
            foreach (var bebida in estanterias)
            {
                if (bebida != null)
                {
                    total += bebida.CalcularPrecio();
                }
            }
            return total;
        }
        public double CalcularPrecioPorMarca(string marca)
        {
            double total = 0;
            foreach (var bebida in estanterias)
            {
                if (bebida != null && bebida.Marca == marca)
                {
                    total += bebida.CalcularPrecio();
                }
            }
            return total;
        }
        public double CalcularPrecioPorEstanteria(int columna)
        {
            double total = 0;
            for (int i = 0; i < estanterias.GetLength(0); i++) //GetLength(0): devuelve la cantidad de filas
            {
                if (estanterias[i, columna] != null)    
                {
                    total += estanterias[i, columna].CalcularPrecio();
                }
            }
            return total;
        }
        public bool AgregarProducto(Bebidas producto)
        {
            // ve si el producto ya existe
            for (int i = 0; i < estanterias.GetLength(0); i++) //GetLength(0): devuelve la cantidad de filas
            {
                for (int j = 0; j < estanterias.GetLength(1); j++) //GetLength(1): devuelve la cantidad de columnas
                {
                    if (estanterias[i, j] != null && estanterias[i, j].ID == producto.ID)
                    {
                        Console.WriteLine("El producto con este ID ya existe");
                        return false;
                    }
                }
            }

            // busca primera posicion libre para agregar producto
            for (int i = 0; i < estanterias.GetLength(0); i++)
            {
                for (int j = 0; j < estanterias.GetLength(1); j++)
                {
                    if (estanterias[i, j] == null)
                    {
                        estanterias[i, j] = producto;
                        Console.WriteLine("Producto agregado");
                        return true;
                    }
                }
            }
            return false;
        }
        public void EliminarProducto(int id)
        {
            for (int i = 0; i < estanterias.GetLength(0); i++)
            {
                for (int j = 0; j < estanterias.GetLength(1); j++)
                {
                    if (estanterias[i, j] != null && estanterias[i, j].ID == id)
                    {
                        estanterias[i, j] = null;
                        Console.WriteLine($"Producto con ID {id} eliminado");
                        return; // frena la busqueda despues de eliminar
                    }
                }
            }
            Console.WriteLine($"No se encontro producto con ID {id}");
        }
        public void MostrarInfo()
        {
            for (int i = 0; i < estanterias.GetLength(0); i++)
            {
                for (int j = 0; j < estanterias.GetLength(1); j++)
                {
                    if (estanterias[i, j] != null)
                    {
                        Console.WriteLine(estanterias[i, j]);
                    }
                    else
                    {
                        Console.WriteLine($"Estantería [{i},{j}]: Vacía");
                    }
                }
            }
        }
    }
}
