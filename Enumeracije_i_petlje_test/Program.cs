using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_i_petlje
{
    internal class Program
    {
        enum DaniUTjednu { Ponedjeljak = 1, Utorak, Srijeda, Četvrtak, Petak, Subota, Nedjelja }
        enum MjeseciUGodini { Siječanj, Veljača, Ožujak, Travanj, Svibanj, Lipanj, Srpanj, Kolovoz, Rujan, Listopad, Studeni, Prosinac}
        enum Boje { Žuta, Narančasta, Crvena, Zelena, Plava, Crna}
        static void Main(string[] args)
        {
            Console.WriteLine("Čitanje vrijednosti nabrajanja: ");
            foreach(int i in Enum.GetValues(typeof(Boje)))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Čitanje naziva nabrajanja: ");
            foreach(string i in Enum.GetNames(typeof(Boje)))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(DaniUTjednu.Petak.ToString());
            Console.WriteLine(MjeseciUGodini.Svibanj.ToString());
            Console.WriteLine(Boje.Crna.ToString());
        }
    }
}
