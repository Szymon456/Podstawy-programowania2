using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    internal class Program
    {
        static int czy_pierwsza(int liczba)
        {
            if (liczba < 2) return 0;
            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0) return 0;
            }
            return 1;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Sprawdzanie czy liczba jest pierwsza");
            {
                Console.WriteLine("Podaj liczbę całkowitą:");
                int liczba = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Czy liczba jest pierwsza: {0}", czy_pierwsza(liczba));
                Console.ReadKey(true);

            }
        }
    }
}
