using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    internal interface Entregable
    {
        void Entregar();
        void Devolver();
        bool IsEntregado();
        int CompareTo(int a);
    }
}
