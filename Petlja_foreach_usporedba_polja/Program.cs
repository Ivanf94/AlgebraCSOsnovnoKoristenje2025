using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_usporedba_polja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zivotinje = { "Ptica", "Zmija", "Pas", "Riba", "Gušter" };
            Console.WriteLine("Originalni redoslijed:");
            foreach(var zivotinja in zivotinje)
            {
                Console.WriteLine(zivotinja);
            }
            Console.WriteLine();

            Console.WriteLine("Ispis s obrnutim redoslijedom: ");
            foreach(var z in zivotinje.Reverse()) Console.WriteLine(z);
        }
    }
}
