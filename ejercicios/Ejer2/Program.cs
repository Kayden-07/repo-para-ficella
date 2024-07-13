using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Crear un programa que simule un cajero automático, permitiendo al usuario hacer depósitos, 
             * retiros y consultar su saldo.*/

            float deposito, retirar, saldo_total = 0;
            string accion, pregunta = "no";

            do {

                Console.Write("Quire depositar, retirar o consultar su saldo?: ");
                accion = Console.ReadLine();

                if (accion == "depositar")
                {
                    Console.Write("Cuanto quiere depositar?: ");
                    deposito = float.Parse(Console.ReadLine());
                    saldo_total += deposito;
                } 
                else if (accion == "retirar")
                {
                    Console.Write("Cuanto quiere retirar?: ");
                    retirar = float.Parse(Console.ReadLine());
                    saldo_total -= retirar;
                }
                else if (accion == "saldo")
                {
                    Console.WriteLine("Usted tiene: " + saldo_total + " pesos");
                }
                Console.Write("Quiere hacer mas consultasl(si/no)?: ");
                pregunta = Console.ReadLine();
            } while (pregunta == "si");

            Console.ReadKey();
        }
    }
}
