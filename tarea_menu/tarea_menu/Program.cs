using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gin5_510
{

    class MenuPrincipal   //--------------------------------------------------------------------------
    { 
        List<Menu> menu = new List<Menu>(); // Lista para almacenar objetos Menu
        int posMenu = 0;
        int columna = 1;

        public void derecha()
        {
            for (int i = 0; i <= posMenu; i++) //recorre todos los menús hasta el actual
            {
                columna += menu[i].nombreMenu.Length; //suma la longitud del nombre de cada menú a la variable columna para calcular donde empieza el siguiente menú
            }

            menu[posMenu].posItem = 0; // restablece el elemento posItem dentro del menú actual al primer elemento para que al pasar al siguiente menú se resalte el primer elemento
            if (posMenu < menu.Count - 1)
            {
                posMenu++;
            }
            else
            {
                posMenu = 0;
            }
            this.dibujar();
        }

        public void izquierda()
        {
            menu[posMenu].posItem = 0;

            if (posMenu > menu.Count - 1)
            {
                posMenu--;
            }
            else
            {
                posMenu = menu.Count - 1;
            }
            this.dibujar();
        }

        public void arriba()
        {
            if (menu[posMenu].posItem > 0)
            {
                menu[posMenu].posItem--;
            }
            else
            {
                menu[posMenu].posItem = menu[posMenu].items.Length - 1;  // Si es igual o menor a 0 , vuelve al último elemento del menú actual
            }
            this.dibujar();
        }

        public void abajo()
        {
            if (menu[posMenu].posItem < menu[posMenu].items.Length - 1) // Verifica si la posición actual dentro del menú es menor que el último elemento
            {
                menu[posMenu].posItem++;
            }
            else
            {
                menu[posMenu].posItem = 0; // Si es igual o mayor que el último elemento, vuelve al primer elemento del menú actual
            }
            this.dibujar();
        }

        public MenuPrincipal(Dictionary<string, string[]> menus)
        {
            int posMenu = 0;
            foreach (var subMenu in menus) // Recorre cada submenú del diccionario
            {
                menu.Add(new Menu(posMenu++, subMenu.Key, subMenu.Value)); //aca le paso los valores a la clase Menu
            }
        }

        public void dibujar()
        {
            Console.Clear(); // Limpia la consola antes de dibujar el menú
            int fila = 1;

            Console.SetCursorPosition(columna, fila++);

            Console.WriteLine(menu[posMenu].nombreMenu); // Muestra el nombre del menú actual
            int pos = 0;

            foreach (string item in menu[posMenu].items) // Recorre las opciones del menú actual
            {
                if (menu[posMenu].posItem == pos) // Verifica si la opción actual es la seleccionada
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                pos++;
                Console.SetCursorPosition(columna, fila++);
                Console.Write(item);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }

    class Menu //-----------------------------------------------------------
    {
        public string[] items;
        public string nombreMenu;
        public int posItem;

        public Menu(int posMenu, string nombreMenu, string[] opciones)
        {
            this.items = opciones;
            this.nombreMenu = nombreMenu;
            this.posItem = posMenu;
        }
    }

    internal class Program  //---------------------------------------------------------------
    {
        static void Main(string[] args)
        {
            MenuPrincipal menu; //declaro una variable de tipo MenuPrincipal
            ConsoleKeyInfo tecla; //declaro una variable de tipo ConsoleKey

            string[] menu1 = { "Nuevo Archivo", "Modificar Archivo", "Listar Archivo", "Salir" };
            string[] menu2 = { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" };
            string[] menu3 = { "Nuevo hola", "Modificar hola", "Eliminar hola", "Listar holas", "Salir" };

            var menus = new Dictionary<string, string[]> { //creo un nuevo diccionario y lo guardo en menus, DICCIONARIO: este permite asociar un nombre a un dato
                    { "Archivo", menu1 }, { "Editar", menu2 }, {"hola", menu3}
                };

            menu = new MenuPrincipal(menus); //creo un objeto MenuPrincipal y le guardo lo que esta en menus
            menu.dibujar();

            while (true)
            {
                tecla = Console.ReadKey(); //devuelve la tecla que tocaste
                switch (tecla.Key)
                {
                    case ConsoleKey.RightArrow:
                        menu.derecha();
                        break;

                    case ConsoleKey.LeftArrow:
                        menu.izquierda();
                        break;

                    case ConsoleKey.UpArrow:
                        menu.arriba();
                        break;

                    case ConsoleKey.DownArrow:
                        menu.abajo();
                        break;
                }
            }

        }
    }
}







