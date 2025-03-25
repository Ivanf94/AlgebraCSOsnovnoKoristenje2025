using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_protected
{
    class Korisnik
    {
        protected string Ime;
        protected string Adresa;
        protected int Godine;
        
        protected void IspisDetalja()
        {
            Console.WriteLine("Ime i prezime: " + Ime);
            Console.WriteLine("Adresa stanovanja: " + Adresa);
            Console.WriteLine("Starost: " + Godine);
        }
    }

    class Osoba : Korisnik
    {
        public Osoba(string i, string a, int n)
        {
            Ime = i;
            Adresa = a;
            Godine = n;
        }

        public Osoba() { }
    }
    internal class Program : Korisnik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikatora pristupa protected");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            Korisnik k = new Korisnik();
            //CS022 Error
            //k.Ime = "Ante";
            //k.Adresa = "Rijeka";
            //k.Godine = 29;
            //k.IspisDetalja();

            Program p = new Program();

            p.Ime = "Nives Celzijus";
            p.Adresa = "Zagreb";
            p.Godine = 57;

            p.IspisDetalja();

            Osoba o = new Osoba();

            //o.Ime = "Nemere!";
        }
    }
}
