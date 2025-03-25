using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_internal
{
    public class MITEST { }
    class Korisnik
    {
        internal string Ime;
        internal string Adresa;
        internal int Godine;

        internal void IspisDetalja()
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
            Console.WriteLine("Primjer modifikatora pristupa internal");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Korisnik k = new Korisnik();
            k.Ime = "Toma";
            k.Adresa = "Birc";
            k.Godine = 93;
            k.IspisDetalja();
        }
    }
}
