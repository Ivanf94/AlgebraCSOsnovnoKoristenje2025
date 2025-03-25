using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_i_kolekcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Metoda s kolekcijom za ispis riječi obrnuto:");
            Console.WriteLine();

            List<string> rijeci = new List<string>();
            for(int i = 0; i < 4; i++)
            {
                Console.Write("Unesite {0} riječ: ",i+1);
                rijeci.Add(Console.ReadLine());
            }
            MojeRijeciNaopako(rijeci);

            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("Metoda s kolekcijom za ispis brojeva obrnuto:");
            Console.WriteLine();

            List<int> brojevi = new List<int>();
            for(int i = 0; i < 4; i++)
            {
                Console.Write("Unesite {0} broj: ", i + 1);
                brojevi.Add(int.Parse(Console.ReadLine()));
            }

            MojiBrojeviNaopako(brojevi);
        }

        public static void MojiBrojeviNaopako(List<int> popis_brojeva)
        {
            foreach(int broj in popis_brojeva)
            {
                int n = broj, obrnuto = 0;
                while (n != 0)
                {
                    obrnuto *= 10;
                    obrnuto += n % 10;
                    n = n / 10;
                }
                Console.WriteLine("Broj {0} naopako izgleda {1}", broj, obrnuto);
            }
        }

        public static void MojeRijeciNaopako(List<string> popis_rijeci)
        {
            foreach (string rijec in popis_rijeci) Console.WriteLine(rijec.Reverse().ToArray());
            //string.Concat(string.Concat(rijec.Reverse().ToArray()); NIJE POTREBNO SPAJATI NAZAD U STRING
        }
    }
}
