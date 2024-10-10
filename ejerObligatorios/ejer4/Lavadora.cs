using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    public class Lavadora : Electrodomestico
    {
        const double cargaEstablecido = 5;
        private double carga;
        public double Carga
        {
            set { carga = value; }
        }
        public Lavadora()
        {
            this.carga = cargaEstablecido;
        }
        public Lavadora(double precio, double peso) : base(precio, peso)
        {
            this.carga = cargaEstablecido;
        }
        public Lavadora(double precio, double peso, string color, char consumoElectrico, double carga) : base(precio, peso, color, consumoElectrico)
        {
            this.carga = carga;
        }
        public double GetCarga()
        {
            return carga;
        }
        public override double PrecioFinal()
        {
            double precio = base.PrecioFinal();
            if (carga > 30)
            {
                return precio + 50;
            }
            return precio;
        }
    }
}
