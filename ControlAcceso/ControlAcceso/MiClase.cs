using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroNamespace
{
    class MiClase
    {
        // Puede ser visto por cualquier clase
        public void MetodoPublico()
        {
            Console.WriteLine("Llamando a método público");
        }

        // Puede ser visto desde esta clase o cualquier clase
        // que herede de MiClase
        protected void MetodoProtected()
        {
            Console.WriteLine("Llamando a método protected");
        }

        // Puede ser visto por cualquier clase dentro del mismo assembly
        internal void MetodoInternal()
        {
            Console.WriteLine("Llamando a método internal");
        }

        // Puede ser visto solo por esta clase
        private void MetodoPrivado()
        {
            Console.WriteLine("Llamando a método privado");
        }
    }
}
