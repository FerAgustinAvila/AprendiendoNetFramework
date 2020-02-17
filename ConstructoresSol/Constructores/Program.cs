using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {

            CuentaBancaria cuenta1 = new CuentaBancaria("00001");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2} ", cuenta1.NoCuenta,
                cuenta1.Usuario, cuenta1.Saldo);

            CuentaBancaria cuenta2 = new CuentaBancaria("00022", "John Doe");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2} ", cuenta2.NoCuenta,
                cuenta2.Usuario, cuenta2.Saldo);


            CuentaBancaria cuenta3 = new CuentaBancaria("00022", "John Doe", 10000);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: ${2} ", cuenta3.NoCuenta,
                cuenta3.Usuario, cuenta3.Saldo);
            Console.Read();
        }
    }
}
