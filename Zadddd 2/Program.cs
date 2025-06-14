using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadddd_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Podaj a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b = ");
            b = Convert.ToInt32(Console.ReadLine());
            while (a <= b)
            {
                if (a % 2 == 0) Console.Write("{0}, ", a);
                a++;
            }
            Console.ReadKey(true); // pauza

        }
    }
}
