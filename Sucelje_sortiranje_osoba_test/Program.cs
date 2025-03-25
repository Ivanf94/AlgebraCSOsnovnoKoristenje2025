using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelje_sortiranje_osoba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = { 13, 7, 3, 7, 2, 897, 54, 43, 55, 667, 123 };
            Osoba[] osobe =
            {
                new Osoba(){Ime="Nikola", Prezime="Tesla", DatumRodjenja = new DateTime(1856,7,10) },
                new Osoba(){Ime="Danijel", Prezime="Pobi", DatumRodjenja = new DateTime(1984,9,28) },
                new Osoba(){Ime="Thomas", Prezime="Edison", DatumRodjenja = new DateTime(1847,2,11) },
                new Osoba(){Ime="Nives", Prezime="Celzijus", DatumRodjenja = new DateTime(1981,12,18) },
                new Osoba(){Ime="Luka", Prezime="Modrić", DatumRodjenja = new DateTime(1985,9,9) },
                new Osoba(){Ime="John", Prezime="Wayne", DatumRodjenja = new DateTime(1907,5,26) },
                new Osoba(){Ime="Ozzy", Prezime="Osbourne", DatumRodjenja = new DateTime(1948,12,3) },
                new Osoba(){Ime="Mladen", Prezime="Grdović", DatumRodjenja = new DateTime(1958,7,28) },
                new Osoba(){Ime="Donald", Prezime="Trump", DatumRodjenja = new DateTime(1946,6,14) },
                new Osoba(){Ime="Christopher", Prezime="Lee", DatumRodjenja = new DateTime(1922,5,27) }
            };

            Console.WriteLine("Brojevi nesortirano: ");
            foreach (var b in brojevi) Console.Write(b + " ");
            Console.WriteLine();
            Array.Sort(brojevi);
            Console.WriteLine("Brojevi sortirano: ");
            foreach (var b in brojevi) Console.Write(b + " ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Osobe nesortirano: ");
            foreach (var o in osobe) Console.WriteLine(o);
            Console.WriteLine();
            Array.Sort(osobe);
            Console.WriteLine("Osobe sortirano: ");
            foreach (var o in osobe) Console.WriteLine(o);
            Console.WriteLine();
        }
    }
}