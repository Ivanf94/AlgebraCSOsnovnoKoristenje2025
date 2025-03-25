using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StaticnaKlasa stat = new StaticnaKlasa();

            Console.WriteLine(StaticnaKlasa.Zbroj(11,4));
            Console.WriteLine(StaticnaKlasa.Kub(3.14));

            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("Primjer kada je klasa obična, no ima i statične metode");
            Console.WriteLine();

            Console.WriteLine("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (StaticnaMetoda.Prost(broj))
            {
                Console.WriteLine("Broj je prost :)");
            }
            else
            {
                Console.WriteLine("Broj nije prost :(");
            }

            StaticnaMetoda sm = new StaticnaMetoda();
            if (sm.Savrsen(broj))
            {
                Console.WriteLine("Broj je savršen");
            }
            else Console.WriteLine("Broj NIJE savršen");

            //sm.Prost(broj);
        }
    }
}
