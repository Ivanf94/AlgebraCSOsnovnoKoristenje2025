using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_oruzje.Models
{
    public enum Domet
    {
        Neposredna_blizina,
        Kratki,
        Srednji,
        Dugi,
        Medjudrzavni,
        Medjukontinentalni,
        MedjuPlanetni
    }
    public class Oruzje
    {
        private string naziv;
        private string proizvodjac;
        private Domet domet;
        private int godina_proizvodnje;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string Proizvodjac
        {
            get { return proizvodjac; }
            set { proizvodjac = value; }
        }

        public Domet Domet
        {
            get { return domet; }
            set { domet = value; }
        }

        public virtual int Godina_proizvodnje
        {
            get { return godina_proizvodnje; }
            set 
            {
                if (value > DateTime.Now.Year) value = DateTime.Now.Year;
                godina_proizvodnje = value; 
            }
        }

        public Oruzje() { }
        public Oruzje(string naziv, string proizvodjac, Domet domet, int godina_proizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            Domet = domet;
            Godina_proizvodnje = godina_proizvodnje;
        }
    }
}