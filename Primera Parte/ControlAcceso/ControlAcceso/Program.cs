using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OtroNamespace;

namespace ControlAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase obj = new MiClase();
            obj.MetodoPublico();
            obj.MetodoInternal();
            //obj.MetodoProtected();
            //obj.MetodoPrivado();

            Console.Read();
        }
    }
}
