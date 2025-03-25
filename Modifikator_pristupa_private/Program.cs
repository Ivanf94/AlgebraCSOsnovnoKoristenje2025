using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_private
{
    class Korisnik
    {
        private string Ime;
        private string Adresa;
        private int Godine;

        private void IspisDetalja()
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
            Console.WriteLine("Primjer modifikatora pristupa private");
            Console.WriteLine("==============================");
            Console.WriteLine();

            Korisnik k = new Korisnik();

            //CS0122 Error
            //k.Ime = "Ne znam";
            //k.Adresa = "Nema";
            //k.Godine = 20000;
        }
    }
}
