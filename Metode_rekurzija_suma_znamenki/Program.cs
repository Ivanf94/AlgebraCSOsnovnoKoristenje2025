using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_rekurzija_suma_znamenki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzivna funkcija: računanje sume znamenki broja:");
            Console.WriteLine("======================================================");
            Console.WriteLine();

            Console.WriteLine("Unesite broj: ");
            long broj = long.Parse(Console.ReadLine());

            Console.WriteLine("Suma znamenki broja {0} iznosi {1}", broj, SumaZnamenki(broj));
        }

        private static long SumaZnamenki(long broj)
        {
            if (broj == 0) return 0;
            return broj % 10 + SumaZnamenki(broj/10);
        }

        private static long SumaZnamenki2(long broj)
        {
            long sum = 0;
            while(broj > 0)
            {
                sum += broj % 10;
                broj /= 10;
            }
            return sum;
        }
    }
}
