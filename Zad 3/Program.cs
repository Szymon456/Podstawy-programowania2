using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b , c;
            Console.Write("Podaj liczbę nr 1:");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 2:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 3:");
            c = Convert.ToDouble(Console.ReadLine());
            if ((a<=b) && (a<=c))
                    Console.WriteLine("Liczba {0} jest najmniejsza", a);
            else if ((b<=c) && (b<=a))
                    Console.WriteLine("Liczba {0} jest najmnijesza", b);
            else
                Console.WriteLine( "Liczba {0} jest najmnijesza", c);

            if ((a >= b) && (a >= c))
                Console.WriteLine("Liczba {0} jest największa", a);
            else if ((b >= c) && (b >= a))
                Console.WriteLine("Liczba {0} jest największa", b);
            else
                Console.WriteLine("Liczba {0} jest największa", c);
            Console.ReadKey(true);


        }
    }
}
