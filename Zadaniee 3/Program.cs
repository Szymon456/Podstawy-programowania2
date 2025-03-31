using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniee_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i, n, j, tmp;
            Console.Write("Podaj ilość elemntów tablicy gdzie n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
                for ( j=i+1; j<n; j++)
                    if (tab[i] > tab[j])
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; }
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.ReadKey(true);

        }
    }
}
