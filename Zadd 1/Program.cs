 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadd_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę: ");
            a=Convert.ToInt32(Console.ReadLine());
            if (a % 2==0)
                Console.WriteLine("Liczba {0} jest parzysta", a);
            else
                Console.WriteLine("Liczba {0} jest nieparzysta", a);
                    Console.ReadKey(true);
        }
    }
}
