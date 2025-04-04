using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanieee_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, an, i;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine()); ;
            i = 0;
                while (++i <=n)
            {
                an = 2 * i - 1;
                    Console.WriteLine("a({0})={1}",i ,an);
            }
            Console.ReadKey(true);
        }
    }
}
