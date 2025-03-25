using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_public
{
    public class Korisnik
    {
        public string Ime;
        public string Adresa;
        public int Godine;

        public void IspisDetalja()
        {
            Console.WriteLine("Ime i prezime: "+Ime);
            Console.WriteLine("Adresa stanovanja: "+Adresa);
            Console.WriteLine("Starost: "+Godine);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikatora pristupa public");
            Console.WriteLine("=======================================");
            Console.WriteLine();

            Korisnik k = new Korisnik();
            k.Ime = "Nikola Tesla";
            k.Adresa = "New York";
            k.Godine = 82;

            k.IspisDetalja();
        }
    }
}
