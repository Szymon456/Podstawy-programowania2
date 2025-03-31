using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniee_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tab = new int[1000];
            int i, suma, n;
            Console.Write("Podaj ilość elemntów tablicy gdzie n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (i = 0; i < n; i++) suma += tab[i]; 
            {
                Console.Write("Suma wpisanych liczb wynosi: {0}",suma);
            }
            Console.ReadKey(true);
        }
    }
}
