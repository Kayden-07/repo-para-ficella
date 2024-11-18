using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer15
{
    public abstract class Bebidas
    {
        private int id;
        private double litros, precio;
        private string marca;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Litros 
        { 
            get { return litros; } 
            set { litros = value; } 
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public Bebidas(int id, double litros, double precio, string marca) 
        { 
            this.id = id;
            this.litros = litros;
            this.precio = precio;
            this.marca = marca;
        }
        public virtual double CalcularPrecio() //Virtual: permite que un método de la clase base sea sobrescrito en una clase hija
        {
            return this.precio;
        }
        public override string ToString()
        {
            return $"ID: {id}, Marca: {marca}, Precio: {precio}, Litros: {litros}";
        }

    }

    public class AguaMineral : Bebidas
    {
        private string origen;
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
        public AguaMineral(int id, double litros, double precio, string marca, string origen) : base(id, litros, precio, marca)
        {
            this.origen = origen;
        }
        public override string ToString()
        {
            return base.ToString() + $", Origen: {origen}";
        }
    }

    public class Azucarada : Bebidas
    {
        private double porcentajeAzucar;
        private bool tienePromo;
        public double PorcentajeAzucar
        {
            get { return porcentajeAzucar; }
            set { porcentajeAzucar = value; }
        }
        public bool TienePromo
        {
            get { return tienePromo; }
            set { tienePromo = value; }
        }
        public Azucarada(int id, double litros, double precio, string marca, double porcentajeAzucar, bool tienePromo) : base(id, litros, precio, marca)
        {
            this.tienePromo = tienePromo;
            this.porcentajeAzucar = porcentajeAzucar;
        }
        public override double CalcularPrecio() 
        {
            if (tienePromo)
            {
                return Precio * 0.9;
            }
            else
            {
                return Precio;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", Tiene promo: {tienePromo}, Porcentaje de Azucar: {porcentajeAzucar}%";
        }
    }
}
