using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_todo_lista
{
    internal class Lista : List<StavkaListe>
    {
        public Lista() { }

        public void Dodaj(string naslov, string opis)
        {
            int broj_zadataka = this.Count;
            this.Add(new StavkaListe(broj_zadataka + 1, naslov, opis, false));
        }

        public void NovaStavkaListe()
        {
            Console.Write("Unesite naslov zadatka: ");
            string naslov = Console.ReadLine();

            Console.Write("Unesite opis zadatka: ");
            string opis = Console.ReadLine();

            Dodaj(naslov, opis);
        }

        public void IspisListe()
        {
            Console.WriteLine("Broj     |       Naslov      |       Opis        |       Gotovo");
            Console.WriteLine("================================================================");
            Console.WriteLine();
            foreach(var zadatak in this)
            {
                Console.Write($"{zadatak.Broj}      {zadatak.Naslov}        {zadatak.Opis}          ");
                if (zadatak.Gotovo) Console.Write("Gotovo");
                else Console.Write("U tijeku");
                Console.WriteLine();
                Console.WriteLine("===============================================================");
            }
            Console.WriteLine("Ukupno " + this.Count + " zadataka u listi");
        }
    }
}
