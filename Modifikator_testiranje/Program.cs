using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_testiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Modifikator_pristupa_public.Korisnik k = new Modifikator_pristupa_public.Korisnik();
            k.Ime = "Ivo";

            Modifikator_pristupa_internal.MITEST m = new Modifikator_pristupa_internal.MITEST();
            //Modifikator_pristupa_internal.Korisnik k1;
        }
    }
}
