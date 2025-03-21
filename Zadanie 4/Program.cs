using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i, n, k;
                Console.Write("Podaj liczbe naturalna n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe naturalna k:");
            k = Convert.ToInt32(Console.ReadLine());

            for (i=1; i<=n; i++)
            { for (j = 1; j <= k; j++)
                    Console.Write("*");
                        Console.WriteLine("");
                    }
            Console.ReadKey(true);
        }
    }
}
