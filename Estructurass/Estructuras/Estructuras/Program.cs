using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);

            Console.WriteLine("Módulo vector 1: {0}", v1.CalcularModulo());
            Console.WriteLine("Módulo vector 2: {0}", v2.CalcularModulo());

            Vector resultado = v1.Suma(v2);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(resultado);
        }
    }
}
