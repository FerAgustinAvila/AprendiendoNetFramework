using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFechas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fecha y hora actual");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Fecha Personalizada");
            DateTime dt = new DateTime(2017, 2, 3, 10, 20, 30);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);

            Console.WriteLine(dt.AddDays(10));
            Console.WriteLine(dt.AddYears(-2));
            Console.WriteLine(dt.AddMinutes(45));

            Console.Read();
        }
    }
}
