using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Propiedades
{
    /// <summary>
    /// Propiedades
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();

            cuenta.Saldo = -5;
            Console.WriteLine("Saldo despues de primera asignacion: {0}", cuenta.Saldo);
        }
    }
}
