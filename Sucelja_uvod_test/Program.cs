using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transakcija t = new Transakcija();
            t.Konekcija();
            t.NapraviTransakciju();

            ITransakcije trans = new Transakcija();
            trans.NapraviTransakciju();
        }

        interface ITransakcije
        {
            void NapraviTransakciju();
        }

        class KonekcijaBazaPodataka
        {
            public void Konekcija()
            {
                Console.WriteLine("Spoji se na bazu podataka.");
            }
        }

        class Transakcija : KonekcijaBazaPodataka, ITransakcije
        {
            public void NapraviTransakciju()
            {
                Console.WriteLine("Transakcija u tijeku...");
            }
        }
    }
}
