using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_nekretnine
{
    public enum StanjeNekretnine
    {
        Nepoznato,
        Izvrsno,
        Dobro,
        PotrebniRadovi,
        Lose
    }
    
    internal class Nekretnina
    {
        private string broj_nekretnine;
        private StanjeNekretnine stanje;
        private int broj_soba;
        private float broj_kupaonica;
        private int godina_gradnje;
        private decimal vrijednost;

        public Nekretnina() { }

        public string Broj_nekretnine
        {
            get { return broj_nekretnine; }
            set
            {
                if (broj_nekretnine == "") broj_nekretnine = "N/A";
                else broj_nekretnine = value;
            }
        }

        public StanjeNekretnine Stanje
        {
            get { return stanje; }
            set { stanje = value; }
        }

        public int Sobe
        {
            get
            {
                if (broj_soba <= 1) return 1;
                return broj_soba;
            }
            set { broj_soba = value; }
        }

        public float Kupaonice
        {
            get { return broj_kupaonica; }
            set { broj_kupaonica = value; }
        }

        public int Izgradjeno
        {
            get { return godina_gradnje; }
            set { godina_gradnje = value; }
        }

        public decimal Vrijednost
        {
            get { return vrijednost; }
            set { vrijednost = value; }
        }
    }
}