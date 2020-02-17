using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable que se usara para guardar el mensaje proporcionadao por el usuario
            string message = String.Empty;
            Console.WriteLine("Proporcione un mensaje, por favor: ");
            message = Console.ReadLine();
            if( message != String.Empty)
            {
                Console.WriteLine("El mensaje recibido es: '" + message + "'. ");
            }
            else
            {
                Console.WriteLine("No se recibió mensaje");
            }

            Console.Read();
        }
    }
}
