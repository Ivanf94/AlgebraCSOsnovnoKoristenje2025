using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_nasumicne_poruke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj prikaza nasumičnih poruka: ");
            int broj = int.Parse(Console.ReadLine());
            IspisNasumicnihPoruka(broj);
        }

        private static void IspisNasumicnihPoruka(int broj)
        {
            string[] naslovi = new string[]
            {
                "Izvrsni proizvod",
                "Tako sjajan proizvod",
                "Uvijek koristim taj proizvod :)",
                "Najbolji proizvod u svojoj kategoriji",
                "Iznimni proizvod",
                "Ne mogu živjeti bez ovog proizvoda!"
            };
            string[] opisi = new string[]
            {
                "Sad se osjećam dobro",
                "Uspio sam s ovim proizvodom poboljšati život :)",
                "Čini čuda, sretan sam zbog rezultata :)",
                "Ne mogu vjerovati, ali sad se osjećam odlično.",
                "Isprobajte sami, vrlo sam zadovoljan :)",
                "Osjećam se sjajno :D"
            };
            string[] autori = new string[]
            {
                "Mato",
                "Ivo",
                "Ana",
                "Martina",
                "Katarina",
                "Iva",
                "Anica",
                "Eva",
                "Adam"
            };
            string[] gradovi = new string[]
            {
                "Zagreb",
                "Split",
                "Rijeka",
                "Osijek",
                "Vinkovci",
                "Dubrovnik"
            };

            Random rand = new Random();
            for(int i = 0; i < broj; i++)
            {
                Console.WriteLine("{0} {1} {2} - {3}", 
                    naslovi[rand.Next(naslovi.Length)],
                    opisi[rand.Next(opisi.Length)],
                    autori[rand.Next(autori.Length)],
                    gradovi[rand.Next(gradovi.Length)]);
            }
        }
    }
}
