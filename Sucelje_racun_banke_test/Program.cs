using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelje_racun_banke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = "Mario";
            string prezime = "Marić";

            Console.WriteLine("==============================");
            Console.WriteLine(ime+" "+prezime);
            Console.WriteLine("==============================");
            IRacunBanke tekuci = new TekuciRacun();
            IRacunBanke ziro = new ZiroRacun();

            Console.WriteLine("Tekući račun:");
            tekuci.Uplata(250);
            Console.WriteLine(tekuci.IspisSaldo());
            tekuci.Uplata(500);
            Console.WriteLine(tekuci.IspisSaldo());
            tekuci.Isplata(1000);
            Console.WriteLine(tekuci.IspisSaldo());
            tekuci.Isplata(400);
            Console.WriteLine(tekuci.IspisSaldo());

            Console.WriteLine();
            Console.WriteLine("Žiro račun:");
            ziro.Uplata(550);
            Console.WriteLine(ziro.IspisSaldo());
            ziro.Isplata(700);
            Console.WriteLine(ziro.IspisSaldo());
            ziro.Isplata(125);
            Console.WriteLine(ziro.IspisSaldo());
        }
    }
}
