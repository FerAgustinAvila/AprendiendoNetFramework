using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = new int[list.Length];

            // Genera una copia del arreglo list
            Array.Copy(list, temp, list.Length);

            Console.Write("Arreglo Original: ");
            MostrarArreglo(list);
            Console.Write("Arreglo copia: ");
            MostrarArreglo(temp);

            // invierte el arreglo
            Array.Reverse(temp);
            Console.Write("Arreglo invertido: ");
            MostrarArreglo(temp);

            // ordenar el arreglo
            Array.Sort(list);
            Console.Write("Arreglo ordenado");
            MostrarArreglo(list);    
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int i in arreglo)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
