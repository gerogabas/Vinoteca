using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinoteca
{
    internal class Venta
    {
        DateTime fecha;
        String[] descripcion;
        public double Total { get; private set; }

        public Venta(String[] descripcion, double total)
        {
            Total = total;
            fecha = DateTime.Now;
        }
    }
}
