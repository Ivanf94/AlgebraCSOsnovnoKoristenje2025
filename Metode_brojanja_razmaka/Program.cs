using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_brojanja_razmaka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojanje razmaka u rečenici");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();
            Console.WriteLine("\"{0}\" sadrži {1} razmaka",recenica,PrebrojRazmake(recenica));
        }

        static int PrebrojRazmake(string rec)
        {
            int brojac = 0;
            foreach (char c in rec)
                if (c == ' ') brojac++;

            return brojac;
        }
    }
}
