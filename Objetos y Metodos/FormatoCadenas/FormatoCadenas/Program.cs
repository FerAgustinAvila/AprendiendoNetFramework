using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatoCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            int naranjas = 8;
            int platanos = 2;
            int manzanas = 6;
            string resultado = string.Format("Hay {0} plátanos, {1} naranjas y {2} manzanas.",
                platanos, naranjas, manzanas);
            Console.WriteLine(resultado);

            Console.WriteLine("Pi: {0:0.00}", Math.PI);

            // Ajustar dato con 10 caracteres de espacio
            Console.WriteLine(">{0, 10}<", 5);
            // Ajustar dato con 10 caracteres de espacio a la izquierda
            Console.WriteLine(">{0, -10}<", 5);

            // Distintos formatos
            int dato = 126;
            Console.WriteLine("Número: {0:N}", dato);
            Console.WriteLine("Científico: {0:E}", dato);
            Console.WriteLine("Moneda: {0:C}", dato);
            Console.WriteLine("Porcentaje: {0:P}", dato);
            Console.WriteLine("Hexadecimal: {0:X}", dato);
        }
    }
}
