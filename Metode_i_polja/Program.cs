using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_i_polja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Primjer metode s poljima:");
            Console.WriteLine();

            string[] podaci = new string[3];

            Unos(podaci);

            Ispis(podaci);
        }

        public static void Unos(string[] podaci)
        {
            for (int i = 0; i < podaci.Length; i++)
            {
                Console.Write("Molimo unesite {0}. ime: ", i + 1);
                podaci[i] = Console.ReadLine();
            }
        }

        public static void Ispis(string[] podaci)
        {
            foreach(string s in podaci)
            {
                Console.WriteLine("Pozdravlja vas "+s);
            }
        }
    }
}
