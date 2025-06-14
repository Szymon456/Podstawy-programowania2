using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaddd_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę: ");
            a= Convert.ToInt32(Console.ReadLine());
            if (a < 0)
                Console.WriteLine("Liczba {0} jest ujemna", a);
            else if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnia", a);
            else 
                    Console.WriteLine("Liczba {0} jest równa 0", a);
                Console.ReadKey(true);
        }
    }
}
