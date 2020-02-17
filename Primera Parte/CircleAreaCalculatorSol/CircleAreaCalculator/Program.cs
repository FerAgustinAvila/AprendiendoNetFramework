using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            double radius = 0;
            double circleArea = 0;
            string userData = String.Empty;

            Console.WriteLine("Proporcione el radio de tu circulo: ");
            userData = Console.ReadLine();

            if( double.TryParse(userData, out radius ))
            {
                circleArea = PI * Math.Pow(radius, 2);
                Console.WriteLine($"El área de tu círculo es: {circleArea.ToString()}");
                Console.Read();
            }
            else
            {
                Console.WriteLine("El dato proporcionado no es válido!");
                Console.Read();
            }
        }
    }
}
