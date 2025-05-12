using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaddd_4
{
    internal class Program
    {
        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą:");
            int liczba = Convert.ToInt32(Console.ReadLine());
            int cyfer = ile_cyfr(liczba);
            Console.WriteLine("Liczba ma {0} cyfr", ile_cyfr(liczba));
            Console.ReadKey(true);
        }
    }
}

