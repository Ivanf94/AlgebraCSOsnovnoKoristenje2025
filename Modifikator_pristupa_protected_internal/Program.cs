using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_protected_internal
{
    class Korisnik
    {
        protected internal string Ime;
        protected internal string Adresa;
        protected internal int Godine;

        protected internal void IspisDetalja()
        {
            Console.WriteLine("Ime i prezime: " + Ime);
            Console.WriteLine("Adresa stanovanja: " + Adresa);
            Console.WriteLine("Starost: " + Godine);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikatora pristupa protected internal");
            Console.WriteLine("====================================================");
            Console.WriteLine();

            Korisnik k = new Korisnik();
            k.Ime = "Netko";
            k.Adresa = "Nepoznata";
            k.Godine = 22;
            k.IspisDetalja();
        }
    }
}
