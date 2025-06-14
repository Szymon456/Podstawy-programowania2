using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h,V,l,Pc;
            Console.Write("Podaj promień podstawy stożka: ");
            r= Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość stożka: ");
            h= Convert.ToDouble(Console.ReadLine());
            V = 1.0 / 3 * r * h * Math.PI;
            l = Math.Sqrt(h * h + r * r);
                Pc = Math.PI * r*r + l*Math.PI*r;
            Console.WriteLine("V={0}", V);
                Console.WriteLine("Pc= {0}", Pc);
            Console.ReadKey(true);
        }
    }
}
