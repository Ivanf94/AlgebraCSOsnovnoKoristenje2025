using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelje_sortiranje_osoba
{
    internal class Osoba : IComparable
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is Osoba)
            {
                var osoba = obj as Osoba;
                if (this.Prezime.CompareTo(osoba.Prezime) != 0)
                    return this.Prezime.CompareTo(osoba.Prezime);
                else if (this.Ime.CompareTo(osoba.Ime) != 0)
                    return this.Ime.CompareTo(osoba.Ime);
                else return this.DatumRodjenja.CompareTo(osoba.DatumRodjenja);
            }
            else return 1;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Prezime, Ime, DatumRodjenja.ToShortDateString());
        }
    }
}