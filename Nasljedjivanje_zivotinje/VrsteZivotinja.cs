using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nasljedjivanje_zivotinje.Vrste;

namespace Nasljedjivanje_zivotinje
{
    internal class VrsteZivotinja
    {
        public static Zivotinja PronadjiZivotinju(string vrsta, string naziv, int godine, string spol)
        {
            switch (vrsta)
            {
                case "pas":
                    return new Pas(naziv, godine, spol);
                case "macka":
                    return new Macka(naziv, godine, spol);
                case "zmija":
                    return new Zmija(naziv, godine, spol);
                case "cimpanza":
                    return new Cimpanza(naziv, godine, spol);
                default:
                    throw new ArgumentException("Nepoznata vrsta!");
            }
        }
    }
}
