using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Item
    {
        string opcion;
    }

    class MenuPrincipal
    {
        List<Menu> menus;
        public MenuPrincipal(Dictionary<string, string[]> menu)
        {
            
        }

        public void dibujar(int columna, int fila)
        {
            bool primerItem = true;
            foreach (string item in items)
            {
                if (primerItem)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    primerItem = false;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(columna, fila++);
                Console.Write(item);
            }
        }
    }

    class Menu
    {
        public string[] items;
        public string nombreMenu;
        public int posMenu;

        public Menu(int posMenu, string nombreMenu, string[] opciones)
        {
            items = opciones;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal menu;

            string[] menu1 = { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir" };
            string[] menu2 = { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" };

            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }
            };


            Console.Clear();
            menu = new MenuPrincipal(menus);
            menu.dibujar(1, 1);


            Console.ReadKey();

        }
    }
}
