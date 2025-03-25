using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_oruzje.Models
{
    public class VatrenoOruzje : Oruzje
    {
        private uint kapacitet;
        private float vrijeme_punjenja;
        public uint Kapacitet
        {
            get { return kapacitet; }
            set { kapacitet = value; }
        }

        public float Vrijeme_punjenja
        {
            get { return vrijeme_punjenja; }
            set { vrijeme_punjenja = value; }
        }

        public VatrenoOruzje() { }
        public VatrenoOruzje(string naziv, string proizvodjac, Domet domet, int godina_proizvodnje, uint kapacitet, float vrijeme_punjenja) 
            : base(naziv, proizvodjac, domet, godina_proizvodnje)
        {
            Kapacitet = kapacitet;
            Vrijeme_punjenja = vrijeme_punjenja;
        }
    }
}
