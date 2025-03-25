using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_provjera_prostih_brojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provjera je li broj prost:");
            Console.WriteLine("==================================");
            Console.WriteLine();

            Console.Write("Unesite broj: ");
            int n = int.Parse(Console.ReadLine());

            if(Prost(n)) Console.WriteLine(n+ " je prost...");
            else Console.WriteLine(n+" nije prost broj!");

            Console.WriteLine();
            Console.WriteLine("Ispis prostih brojeva do 100:");
            Console.WriteLine("==================================");
            Console.WriteLine();

            for (int i = 0; i <= 100; i++)
            {
                if (Prost(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Ispis prostih brojeva do 100:");
            Console.WriteLine("==================================");
            Console.WriteLine();

            Console.Write("Unesite broj: ");
            n = int.Parse(Console.ReadLine());

            if(SavrseniBroj(n)) Console.WriteLine(n + " je savršen.");
            else Console.WriteLine(n + " nije savršen.");

            int broj = 1, brojac = 5;
            while (true)
            {
                if (SavrseniBroj(broj))
                {
                    Console.Write(broj + " ");
                    brojac--;
                }
                if (brojac == 0) break;
                broj++;
            }
        }

        public static bool Prost(int broj)
        {
            if (broj < 0) broj *= (-1);
            if (broj == 0) return false;
            for (int i = 2; i < broj; i++)
                if (broj % i == 0) return false;
            return true;
        }

        public static bool SavrseniBroj(int broj)
        {
            int suma = 0;
            for (int i = 1; i < broj; i++)
                if (broj % i == 0) suma += i;

            if (broj == suma) return true;
            return false;
        }
    }
}
