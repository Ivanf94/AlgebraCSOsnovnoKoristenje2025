using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista_brojeva = new ArrayList();

            lista_brojeva.Add(10);
            lista_brojeva.Add(15);
            lista_brojeva.Add(11.7);
            lista_brojeva.Add(1234567890123);

            Console.WriteLine(lista_brojeva[0]);
            Console.WriteLine(lista_brojeva[2]);

            Console.WriteLine();
            Console.WriteLine();

            var lista_razlicith_tipova = new ArrayList();

            lista_razlicith_tipova.Add(10);
            lista_razlicith_tipova.Add("Automobil");
            lista_razlicith_tipova.Add(false);
            lista_razlicith_tipova.Add(null);

            var pi = Math.PI;

            var razliciti_podaci2 = new ArrayList() {"Nikola", "Tesla", "Teslina ulica bb", 89, 0987654321, 5.21, null, true };
            razliciti_podaci2.Add("bla bla bla");

            Console.WriteLine(razliciti_podaci2[1]);
            Console.WriteLine(razliciti_podaci2[3]);
            Console.WriteLine(razliciti_podaci2[4]);

            razliciti_podaci2.Remove(null);
            razliciti_podaci2.RemoveAt(1);
            razliciti_podaci2.RemoveRange(2, 3);

            Console.WriteLine();
            Console.WriteLine();

            List<int> brojevi = new List<int>();

            brojevi.Add(1);
            brojevi.Add(12);
            brojevi.Add(163);
            //brojevi.Add("2");

            Console.WriteLine(brojevi[0]);
            Console.WriteLine(brojevi[2]);

            List<string> tekstovi = new List<string>();
            List<bool> sudovi = new List<bool>();
            List<int> vi = new List<int>();
        }
    }
}
