using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadd_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj liczbę a: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if((a>=b)&&(a>=c))
                    Console.WriteLine("Liczba {0} jest największa", a);
                else if ((b>=c) && (b>=a))
                    Console.WriteLine("Liczba {0} jest największa", b);
                else
                Console.WriteLine("Liczba {0} jest największa)", c);

            if ((a<=b)&& (a<=c))
                    Console.WriteLine("Liczba {0} jest najmniejsza", a);
            else if ((b<=c) && (b<=a))
                    Console.WriteLine("Liczba {0} jest najmniejsza",b);
            else
                Console.WriteLine("Liczba {0} jest najmniejsza", c);
            Console.ReadKey(true);
        }
    }
}
