using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar (double cantidad)
        {
            if (cantidad > 0 && cantidad <= this.cantidad)
            {
                this.cantidad -= cantidad;
            } 
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string accion, nombre;
            double actividad;
            List<Cuenta> cuentas = new List<Cuenta>();
            do
            {
                bool encontrado = false;
                Console.Write("Crear cuenta o entrar a una cuenta?: ");
                accion = Console.ReadLine();

                if (accion == "crear")
                {
                    Console.Write("Titular de la cuenta?: ");
                    nombre = Console.ReadLine();
                    Cuenta c = new Cuenta(nombre, 0);
                    cuentas.Add(c);
                    Console.WriteLine("Cuenta creada con exito");
                }

                if (accion == "entrar")
                {
                    Console.Write("Ingrese el titular de su cuenta: ");
                    nombre = Console.ReadLine();
                    foreach (var c in cuentas) 
                    {
                        if (nombre == c.Titular)
                        {
                            encontrado = true;
                            Console.WriteLine("!Hola " + c.Titular + "¡");
                            Console.WriteLine("Queres ingresar, retirar o cunsultar la plata?: ");
                            accion = Console.ReadLine();
                            if (accion == "ingresar")
                            {
                                Console.WriteLine("Cuanto quiere depositar? ");
                                actividad = double.Parse(Console.ReadLine());
                                c.Ingresar(actividad);
                            }
                            else if (accion == "retirar")
                            {
                                Console.WriteLine("Cuanto quiere retirar? ");
                                actividad = double.Parse(Console.ReadLine());
                                c.Retirar(actividad);
                            }
                            else if (accion == "consultar")
                            {
                                Console.WriteLine("Saldo actual: " + c.Cantidad);
                            }
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Titular incorrecto o no encontrado");
                    }
                }
                Console.WriteLine("¿Desea realizar otra acción? (si/no): ");
                accion = Console.ReadLine();
            } while (accion == "si");
        }
    }
}
