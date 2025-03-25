using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_rekurzija_fibbonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzija: Fibbonaccijev niz");
            Console.WriteLine("======================================");
            Console.WriteLine();

            Console.Write("Unesite n: ");
            int n = int.Parse(Console.ReadLine());
            DateTime poc, kraj;

            poc = DateTime.Now;
            Console.WriteLine("Rekurzivno:");
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine($"f({i}) = {Fib(i)}");
            }
            kraj = DateTime.Now;
            Console.WriteLine("Trajanje: " + (kraj-poc).TotalSeconds+ " s");

            Console.WriteLine();
            Console.WriteLine();

            poc = DateTime.Now;
            Console.WriteLine("Nerekurzivno:");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"f({i}) = {Fib2(i)}");
            }
            kraj = DateTime.Now;
            Console.WriteLine("Trajanje: "+(kraj-poc).TotalSeconds+ " s");
        }

        static int Fib(int n)
        {
            if (n <= 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static int Fib2(int n)
        {
            int trenutni = 1, zadnji = 1, predzadnji = 1;
            for(int i = 2; i <= n; i++)
            {
                trenutni = zadnji + predzadnji;
                predzadnji = zadnji;
                zadnji = trenutni;
            }

            return trenutni;
        }
    }
}
