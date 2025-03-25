using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
        pocetak:
            Console.Write("Unesite ocjenu: ");
            int ocjena = int.Parse(Console.ReadLine());
            if(ocjena < 1 || ocjena > 5)
            {
                Console.WriteLine("Neispravan unos!");
                goto pocetak;
            }

            while (true)
            {
                Console.Write("Unesite ocjenu: ");
                ocjena = int.Parse(Console.ReadLine());
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Neispravan unos!");
                }
                else break;
            }

            bool globalni_izlazak = false;
            while (true)
            {
                do
                {
                    for (; true;)
                    {
                        while (true)
                        {
                            //kod koji "opali" izlazak iz svih petlji...
                            goto kraj;
                        }
                    }
                } while (true);
            }
            kraj:
                Console.WriteLine();
        }
    }
}
