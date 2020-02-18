using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int mes = rnd.Next(1, 13); // crea un número entre 1 y 12
            int dado = rnd.Next(1, 7); // crea un número entre 1 y 6
            double probabilidad = rnd.NextDouble();

            // Llenar un arreglo con números aleatorios
            int[] arreglo = new int[5];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(0, 101);
            }

            foreach (var num in arreglo)
            {
                Console.WriteLine(num);
            }
        }
    }
}
