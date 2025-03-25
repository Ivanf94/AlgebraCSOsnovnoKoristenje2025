using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_vozila.Model
{
    public class Automobil : Vozilo
    {
        private decimal ccm;
        public decimal Ccm
        {
            get { return ccm; }
            set { ccm = value; }
        }

        public Automobil() { }

        public Automobil(int ks) : base(ks)
        {
        }

        public override string ToString()
        {
            return string.Format("Naziv: {0}, KS:{1}", this.Naziv, base.Ks);
        }
    }
}
