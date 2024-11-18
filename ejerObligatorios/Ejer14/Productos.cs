using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    public abstract class Productos
    {
        private string nombre;
        private double precio;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Productos (string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public virtual double Calcular(int cantidad) //Virtual: permite que un método de la clase base sea sobrescrito en una clase hija
        {
            return Precio * cantidad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Precio: {Precio}";
        }
    }

    public class Perecedero : Productos
    {
        private int diasCaduca;
        public int DiasCaduca
        {
            get { return diasCaduca; }
            set { diasCaduca = value; }
        }
        public Perecedero (string nombre, double precio, int diasCaduca) : base(nombre, precio)
        {
            this.diasCaduca = diasCaduca;
        }
        public override double Calcular(int cantidad) //Override: permite modificar el método virtual de la clase base en la clase hija
        {
            double precioTotal = base.Calcular(cantidad); // Usa la lógica de la clase base

            if (diasCaduca == 1)
            {
                precioTotal = precioTotal / 4;
            }
            else if (diasCaduca == 2)
            {
                precioTotal = precioTotal / 3;
            }
            else if (diasCaduca == 3)
            {
                precioTotal = precioTotal / 2;
            }

            return precioTotal;
        }
        public override string ToString()
        {
            return base.ToString() + $", Días a caducar: {diasCaduca}";
        }
    }

    public class NoPerecedero : Productos
    {
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public NoPerecedero(string nombre, double precio, string tipo) : base(nombre, precio)
        {
            this.tipo = tipo;
        }
        public override string ToString()
        {
            return base.ToString() + $", Tipo: {tipo}";
        }
    }
}
