using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Podaj a: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Obwód: {0}", 2 * a+2 * b);
            Console.WriteLine("Pole: {0}", a * b);
            Console.ReadKey(true);

        }
    }
}
