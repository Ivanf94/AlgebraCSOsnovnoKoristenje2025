using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_nekretnine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PopisNekretnina nekretnine = new PopisNekretnina();
            nekretnine.KreirajNovuNekretninu();
            Console.WriteLine();
            nekretnine.PrikaziNekretninu();
        }
    }
}
