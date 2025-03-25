using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_private_protected
{
    class Korisnik
    {
        private protected string Ime;
        private protected string Adresa;
        private protected int Godine;

        private protected void IspisDetalja()
        {
            Console.WriteLine("Ime i prezime: " + Ime);
            Console.WriteLine("Adresa stanovanja: " + Adresa);
            Console.WriteLine("Starost: " + Godine);
        }
    }
    internal class Program : Korisnik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikator private protected");
            Console.WriteLine("=======================================");
            Console.WriteLine();

            Korisnik k = new Korisnik();

            //k.Ime = "Neznam";
            //k.Adresa = "Nema";
            //k.Godine = -100;
            //k.IspisDetalja();

            Program p = new Program();

            p.Ime = "Tomislav";
            p.Adresa = "Knin";
            p.Godine = 56;
            p.IspisDetalja();
        }
    }
}
