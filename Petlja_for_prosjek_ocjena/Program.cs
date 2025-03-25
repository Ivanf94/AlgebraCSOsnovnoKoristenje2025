using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_prosjek_ocjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj predmeta: ");
            int predmeta = int.Parse(Console.ReadLine());

            bool nedovoljan = false;
            int suma = 0, ocjena;

            for(int i = 0; i < predmeta; i++)
            {
                Console.Write("Unesite ocjenu za {0}. predmet: ", i + 1);
                ocjena = int.Parse(Console.ReadLine());

                if(ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Neispravna ocjena, pokušajte ponovo");
                    i--;
                }
                else
                {
                    //OVO JE PRVI PRIMJER ZA PREDAVANJE 17.2.
                    // OVAJ NJEGOV KOD PO MENI NEMA SMISLA, PO OVOME ISPADA SVAKI PUT KAD SE ZADNJI PREDMET
                    // UNESE KAO 1 DA ĆE CILI PROSJEK OCJENA BITI NEDOVOLJAN
                    if (ocjena == 1) nedovoljan = true;
                    suma += ocjena;
                }
            }

            if(nedovoljan) Console.WriteLine("Uspjeh je nedovoljan!");
            else
            {
                Console.WriteLine("Prosjek za {0} predmeta je {1}", predmeta, Math.Round(((double)suma/predmeta),2));
            }
        }
    }
}
