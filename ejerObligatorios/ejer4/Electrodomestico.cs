using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    public class Electrodomestico
    {
        private double precio, peso;
        private string color;
        private char consumoElectrico;

        const string colorEstablecido = "blanco";
        const char consumoEstablecido = 'F';
        const double precioEstablecido = 100;
        const double pesoEstablecido = 5;

        public double Precio { get { return precio; } set { precio = value; } }
        public string Color { get { return color; } set { color = value; } }
        public char ConsumoElectrico { get { return consumoElectrico; } set { consumoElectrico = value; } }
        public double Peso { get { return peso; } set { peso = value; } }

        public Electrodomestico()
        {
            this.precio = precioEstablecido;
            this.Color = colorEstablecido;
            this.ConsumoElectrico = consumoEstablecido;
            this.Peso = pesoEstablecido;
        }
        public Electrodomestico(double precio, double peso) : this()
        {
            this.precio = precio;
            this.peso = peso;
        }
        public Electrodomestico(double precio, double peso, string color, char consumoElectrico)
        {
            this.peso = peso;
            this.color = ComprobarColor(color);
            this.consumoElectrico = ComprobarConsumoEnergetico(consumoElectrico);
            this.precio = precio;
        }

        private char ComprobarConsumoEnergetico(char letra)
        {
            string letras = "ABCDEF";
            for (int i = 0; i < letras.Length; i++)
            {
                if (letra == letras[i])
                {
                    return letras[i];
                }
            }
            return consumoEstablecido;
        }

        private string ComprobarColor(string color)
        {
            string[] coloresDisponibles = { "blanco", "negro", "rojo", "azul", "gris" };
            for (int i = 0; i < coloresDisponibles.Length; i++)
            {
                if (color.ToLower() == coloresDisponibles[i])
                {
                    return color.ToLower(); //.ToLower() vuelve todo minusculas
                }
            }
            return colorEstablecido;
        }

        public virtual double PrecioFinal()
        {
            double incrementoConsumo = 0;
            if (consumoElectrico == 'A')
            {
                incrementoConsumo = 100;
            }
            else if (consumoElectrico == 'B')
            {
                incrementoConsumo = 80;
            }
            else if (consumoElectrico == 'C')
            {
                incrementoConsumo = 60;
            }
            else if (consumoElectrico == 'D')
            {
                incrementoConsumo = 50;
            }
            else if (consumoElectrico == 'E')
            {
                incrementoConsumo = 30;
            }
            else if (consumoElectrico == 'F')
            {
                incrementoConsumo = 10;
            }

            double incrementoPeso = 0;

            if (peso >= 0 && peso <= 19)
            {
                incrementoPeso = 10;
            }
            else if (peso >= 20 && peso <= 49)
            {
                incrementoPeso = 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                incrementoPeso = 80;
            }
            else if (peso >= 80)
            {
                incrementoPeso = 100;
            }
            return precio + incrementoPeso + incrementoConsumo;
        }
    }
}

