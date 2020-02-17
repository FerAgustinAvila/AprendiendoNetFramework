using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Carlos", 38);
            p.Saludar();            

            Empleado e = new Empleado("John", 29, "Ventas", 10000);
            e.Saludar();
            e.Trabajar();
            Console.WriteLine(e);

            Estudiante es = new Estudiante("Jane", 18, 9.5, "8");
            es.Saludar();
            es.IrAClase();
            es.Estudiar();
        }
    }
}
