using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadddd_1
{
    internal class Program
    {
        static int suma(int a, int b)
        {
            return a + b;
        }

      
        static void Main(string[] args)
        {
            Console.WriteLine("2+5={0}", suma(2, 5));
            Console.ReadKey(true); 
    }
}