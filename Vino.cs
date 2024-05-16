using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinoteca
{
    internal class Vino : IComparable
    {
        public int Id { get; private set; }
        public int Cantidad { get; set; }
        public string Bodega { get; private set; }
        public string Nombre { get; private set; }
        public string Tipo { get; private set; }
        public double Precio { get; set; }


        public Vino(int id, int cant, string bodega, string nombre, string tipo, double precio)
        {
            Id = id;
            Cantidad = cant;
            Bodega=bodega;
            Nombre=nombre;
            Tipo=tipo;
            Precio=precio;
        }

        public int CompareTo(Object other)
        {
            Vino v = (Vino)other;
            return Id.CompareTo(v.Id);
        }
    }
}
