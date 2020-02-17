using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("John", "Doe", 28);
            Persona persona2 = new Persona("Jane", "Doe", 27);

            persona1.Saludar();
            persona2.Saludar();

            persona1.Edad = -10;
            Console.WriteLine(persona1);
        }
    }
}
