using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Cadena de prueba");

            // Propiedades Length y Capacity
            Console.WriteLine("Cadena: {0}\nLength: {1}\nCapacity: {2}", builder, builder.Length, builder.Capacity);

            builder.EnsureCapacity(75); // asegura una capacidad de 75
            Console.WriteLine("\nNueva capacidad: {0}", builder.Capacity);

            object[] datos = { "cadena", 1, 0.5, false, 'c', 8 };

            foreach (var dato in datos)
            {
                builder.Append(dato + " ");
            }

            Console.WriteLine(builder.ToString());
            builder.Insert(0, "Inserta al principio");

            Console.WriteLine(builder);
        }
    }
}
