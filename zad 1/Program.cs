using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    internal class Program
    {
        static long silnia(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * silnia(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę do obliczenia silni:");
            int n = int.Parse(Console.ReadLine());
            long wynik = silnia(n);
            Console.WriteLine($"Silnia z {n} wynosi {wynik}");
            Console.ReadKey();
        }
    }
}

