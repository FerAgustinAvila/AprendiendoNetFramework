using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparacionObjetos
{
    class Producto : IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        public int CompareTo(Producto other)
        {
            //if (Precio > other.Precio) return 1;
            //if (Precio == other.Precio) return 0;
            //return -1;

            return Precio.CompareTo(other.Precio);
        }
    }
}
