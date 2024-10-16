using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aula aula1 = new Aula(1, 26, "matematica");
            aula1.EmpezarDia();
            aula1.SePuedeClase();

            Console.ReadKey();
        }
    }
}
