using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Crear un programa que permita al usuario ingresar una lista de tareas y 
             * organizarlas por orden de prioridad.*/   
            
            List<string> tareas = new List<string>();
            string descripcion, accion, prioridad;

            Console.Write("Queres ingresar o ver tareas?: ");
            accion = Console.ReadLine();

            if (accion == "ingresar")
            {
                Console.Write("Escribi la tarea: ");
                descripcion = Console.ReadLine();
                Console.Write("Esta tarea tiene prioridad alta, baja o media?: ");
                prioridad = Console.ReadLine();
                if (prioridad == "alta")
                {

                }
            }
            

        }
    }
}
