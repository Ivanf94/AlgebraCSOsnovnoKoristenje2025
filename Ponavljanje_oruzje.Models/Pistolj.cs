using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_oruzje.Models
{
    public enum Kategorija_pistolja
    {
        Revolver,
        Production,
        Standard,
        Classic,
        Open,
        Kubura
    }
    public class Pistolj : VatrenoOruzje
    {
        private Kategorija_pistolja kategorija;
        public Kategorija_pistolja Kategorija
        {
            get { return kategorija; }
            set { kategorija = value; }
        }

        public override int Godina_proizvodnje 
        {
            get => base.Godina_proizvodnje;
            set
            {
                if (value < 1636) throw new Exception("Ne postoje tako stari pištolji!");
                base.Godina_proizvodnje = value;
            }
        }

        public override string ToString()
        {
            return string.Format(Kategorija.ToString() + " " + Naziv + ", proizveo " + Proizvodjac);
        }

        public string Ispis()
        {
            return "Dobar dan.";
        }
    }
}