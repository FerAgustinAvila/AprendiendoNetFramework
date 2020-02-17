using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo rectangulo
            Rectangulo rect = new Rectangulo();
            rect.Base = 10;
            rect.Altura = 5;

            int area = rect.CalcularArea();

            Console.WriteLine($"Rectangulo: {rect.Base} x {rect.Altura} = {area} ");
            

            Rectangulo rect2 = new Rectangulo { Base = 3, Altura = 8 };
            int area2 = rect2.CalcularArea();

            Console.WriteLine($"Rectangulo: {rect2.Base} x {rect2.Altura} = {area2} ");
            Console.Read();
        }
    }
}
