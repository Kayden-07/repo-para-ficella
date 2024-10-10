using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    internal class Television : Electrodomestico
    {
        const int resolucionEstablecido = 20;
        const bool sintTDTEstablecido = false;
        private int resolucion;
        private bool sintTDT;
        public int Resolucion
        {
            set { resolucion = value; }
        }
        public bool SintTDT
        {
            set { sintTDT = value; }
        }
        public Television()
        {
            this.resolucion = resolucionEstablecido;
            this.sintTDT = sintTDTEstablecido;
        }
        public Television(double precio, double peso) : base(precio, peso)
        {
            this.resolucion = resolucionEstablecido;
            this.sintTDT = sintTDTEstablecido;
        }
        public Television(double precio, double peso, string color, char consumoElectrico, int resolucion, bool sintTDT) : base(precio, peso, color, consumoElectrico)
        {
            this.resolucion = resolucion;
            this.sintTDT = sintTDT;
        }
        public int GetResolucion()
        {
            return resolucion;
        }
        public bool GetSintTDT()
        {
            return sintTDT;
        }
        public override double PrecioFinal()
        {
            double precio = base.PrecioFinal();
            double incrementoResolucion = 0;
            double porcentaje = 0;
            if (resolucion > 40)
            {
                porcentaje = precio * 1.30;
                incrementoResolucion = porcentaje - precio;
            }

            double incrementoSintTDT = 0;
            if (sintTDT == true)
            {
                incrementoSintTDT = 50;
            }
            return precio + incrementoResolucion + incrementoSintTDT;
        }
    }
}
