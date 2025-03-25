using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ponavljanje_oruzje.Models;

namespace Ponavljanje_oruzje.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oruzje o = new Oruzje();
            Oruzje ho = new HladnoOruzje();
            Oruzje p = new Pistolj();

            Pistolj sf = new Pistolj() 
            { 
                Naziv = "SF19", 
                Proizvodjac = "HS Produkt", 
                Kapacitet = 19, 
                Kategorija=Kategorija_pistolja.Production 
            };

            o = sf;
            VatrenoOruzje vo = sf;
            Console.WriteLine(o);
            Console.WriteLine(vo);
            Console.WriteLine(sf);
        }
    }
}
