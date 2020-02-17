using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioCalificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de calificaciones a ingresar: ");
            int num = int.Parse(Console.ReadLine());

            int[] calificaciones = new int[num];

            double suma = 0;
            for(int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write("Calificación {0}: ", i + 1);
                calificaciones[i] = int.Parse(Console.ReadLine());
                suma += calificaciones[i];
            }

            double promedio = suma / calificaciones.Length;
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.Read();
        }
    }
}
