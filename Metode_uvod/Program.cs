using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("Primjer jednostavne metode");
            Console.WriteLine();

            MojaMetoda();

            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("Primjer jednostavne metode s parametrom:");
            Console.WriteLine();

            MojaMetoda();
            MojaMetodaSParametrom();
            MojaMetodaSParametrom("Đuro");

            Console.WriteLine("Ja nisam metoda");
            MojaMetoda();

            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("Primjer jednostavne metode s unosom iz konzole:");
            Console.WriteLine();

            Console.Write("Kako se zovete: ");
            string ime = Console.ReadLine();
            DobroDosli(ime);
        }

        static void MojaMetoda()
        {
            Console.WriteLine("Dobar dan i dobrodošli :)");
        }

        static void MojaMetodaSParametrom(string ime = "polaznici")
        {
            Console.WriteLine($"Dobar dan i dobrodošli {ime}!");
        }

        static void DobroDosli(string ime)
        {
            Console.WriteLine("Hvala i dobrodošli {0}", ime);
        }
    }
}
