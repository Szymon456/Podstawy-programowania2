using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int n, i;

            Console.WriteLine("Podaj liczbę elementów n:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę {0}:", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey(true);
        }
    }
}
