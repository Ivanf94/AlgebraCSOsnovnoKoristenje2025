using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_rekurzija_faktorijele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzivna funkcija: ispis faktorijela broja:");
            Console.WriteLine("=================================================");
            Console.WriteLine();

            Console.Write("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}!={1}",broj, Faktorijela(broj));

            Console.WriteLine("For funkcija: ispis faktorijela broja:");
            Console.WriteLine("=================================================");
            Console.WriteLine();

            Console.WriteLine("{0}!={1}", broj, Faktorijela2(broj));
        }

        static double Faktorijela(double broj)
        {
            if (broj <= 1) return 1;
            return broj * Faktorijela(broj-1);
        }

        static double Faktorijela2(double broj)
        {
            double rez = 1;
            for (int i = 1; i <= broj; i++) rez = rez * i;
            return rez;
            //long faktorijel = 1;
            //for(int i = broj; i >=1; i--)
            //    faktorijel *= i;

            //return faktorijel;
        }

    }
}
