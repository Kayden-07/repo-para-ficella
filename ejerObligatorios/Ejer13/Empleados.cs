using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer13
{
    public abstract class Empleados //abstract: clase base para otras clases, no puede ser instanciada directamente
    {
        private string nombre;
        private int edad, salario;
        protected const int plus = 300; //protected: xpara que sea accesible en las clases hijas, pero no desde fuera de la herencia
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Empleados (string nombre, int edad, int salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }
        public abstract void PonerPlus();
    }

    public class Comercial : Empleados
    {
        private double comision;
        public double Comision
        {
            get { return comision;}
            set { comision = value; }
        }
        public Comercial (string nombre, int edad, int salario, double comision) : base (nombre, edad, salario)
        {
            this.comision = comision;
        }
        public override void PonerPlus()
        {
            if (Edad > 30 && comision > 200)
            {
                Salario += plus;
            }
        }

    }
    public class Repartidor : Empleados
    {
        private string zona;
        public string Zona
        {
            get { return zona; }
            set { zona = value; }
        }
        public Repartidor (string nombre, int edad, int salario, string zona) : base (nombre, edad, salario)
        {
            this.zona = zona;
        }
        public override void PonerPlus()
        {
            if (Edad < 25 && zona == "zona 3")
            {
                Salario += plus;
            }
        }
    }
}
