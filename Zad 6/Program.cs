using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a, b, suma, różnica, iloczyn,iloraz;
            Console.Write("Podaj a: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b: ");
            b=Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            iloczyn = a * b;
            różnica = a - b;
            iloraz = a / b;
            Console.WriteLine("Suma= {0}", suma);
            Console.WriteLine("Iloczyn= {0}", iloczyn);
            Console.WriteLine("Różnica= {0}", różnica);
            Console.WriteLine("Iloraz={0}", iloraz);
            Console.ReadKey(true);


        }
    }
}
