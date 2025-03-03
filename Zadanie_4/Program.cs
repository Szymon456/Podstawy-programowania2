using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Podaj a=");
            a =Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole={0}", a*b);
            Console.WriteLine("Obwód={0}", 2 * a + b * 2);
            Console.ReadKey(true);
        }
    }
}
