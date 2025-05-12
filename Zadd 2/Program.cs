using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadd_2
{
    internal class Program
    {
        static long fib(long n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę do obliczenia n-tego wyrazu ciągu Fibonacciego:");
            long n = long.Parse(Console.ReadLine());
            long wynik = fib(n);
            Console.WriteLine($"n-ty wyraz ciągu Fibonacciego wynosi {wynik}");
            Console.ReadKey();
        }
    }
}
