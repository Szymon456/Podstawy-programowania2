using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadd_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, min, max;
            Console.WriteLine("Podaj liczbę nr. 1");
                a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr. 2");
                b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr. 3");
                c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr. 4");
                d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr. 5");
                e = Convert.ToInt32(Console.ReadLine());

            min = a;
            if (b < min) min=b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza", min);

            max = a;
            if (b > max) max=b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
                    Console.WriteLine("Liczba {0} jest największa", max);
            Console.ReadKey(true);
                            


        }
    }
}
