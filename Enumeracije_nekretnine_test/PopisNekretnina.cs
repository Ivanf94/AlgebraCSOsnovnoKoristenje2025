using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_nekretnine
{
    public enum VrstaNekretnine
    {
        Nepoznato,
        SamohranaObitelj,
        GradskaKuca,
        Garsonjera
    }
    internal class PopisNekretnina
    {
        private Nekretnina nekretnina;
        private VrstaNekretnine vrsta;

        public Nekretnina ListaNekretnina
        {
            get { return nekretnina; }
            set { nekretnina = value; }
        }

        public VrstaNekretnine Vrsta
        {
            get { return vrsta; }
            set { vrsta = value; }
        }

        public PopisNekretnina()
        {
            nekretnina = new Nekretnina();
        }

        public void KreirajNovuNekretninu()
        {
            Console.WriteLine("*** Kreiranje nekretnine ***");
            Console.WriteLine();

            Console.WriteLine("Vrsta nekretnine: ");
            Console.WriteLine("1.   Samohrana obitelj");
            Console.WriteLine("2.   Gradska kuća");
            Console.WriteLine("3.   Garsonjera");
            Console.WriteLine("4.   Ne znam");
            Console.Write("Unesite vrstu nekretnine: ");
            int vrsta_nekretnine = int.Parse(Console.ReadLine());
            if (vrsta_nekretnine < 1 || vrsta_nekretnine >= 4) vrsta_nekretnine = 0;

            Console.WriteLine();

            Console.Write("Broj nekretnine #: ");
            ListaNekretnina.Broj_nekretnine = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Stanje nekretnine: ");
            Console.WriteLine("1. Izvrsno");
            Console.WriteLine("2. Dobro (mogući manji radovi)");
            Console.WriteLine("3. Potrebni radovi");
            Console.WriteLine("4. Loše stanje (potrebni veliki radovi ili obnova)");
            Console.WriteLine("5. Nepoznato");
            Console.Write("Unesite stanje nekretnine: ");
            int stanje = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (stanje == 1) ListaNekretnina.Stanje = StanjeNekretnine.Izvrsno;
            else if (stanje == 2) ListaNekretnina.Stanje = StanjeNekretnine.Dobro;
            else if (stanje == 3) ListaNekretnina.Stanje = StanjeNekretnine.PotrebniRadovi;
            else if (stanje == 4) ListaNekretnina.Stanje = StanjeNekretnine.Lose;
            else ListaNekretnina.Stanje = StanjeNekretnine.Nepoznato;

            Vrsta = (VrstaNekretnine)vrsta_nekretnine;

            Console.Write("Koliko soba? ");
            ListaNekretnina.Sobe = int.Parse(Console.ReadLine());
            Console.Write("Koliko kupaonica? ");
            ListaNekretnina.Kupaonice = float.Parse(Console.ReadLine());
            Console.Write("Godina izgradnje: ");
            ListaNekretnina.Izgradjeno = int.Parse(Console.ReadLine());
            Console.Write("Vrijednost: ");
            ListaNekretnina.Vrijednost = decimal.Parse(Console.ReadLine());
        }

        public void PrikaziNekretninu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine(" ****  Popis svojstava nekretnine **** ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nekretnine #:        "+ListaNekretnina.Broj_nekretnine);
            Console.WriteLine("Vrsta nekretnine:    "+Vrsta);
            Console.WriteLine("Stanje:              "+ListaNekretnina.Stanje);
            Console.WriteLine("Sobe:                "+ListaNekretnina.Sobe);
            Console.WriteLine("Kupaonice:           "+ListaNekretnina.Kupaonice);
            Console.WriteLine("Godina izgradnje:    "+ListaNekretnina.Izgradjeno);
            Console.WriteLine("Tržišna vrijednost:  "+ListaNekretnina.Vrijednost);
            Console.WriteLine("=========================================");
        }
    }
}