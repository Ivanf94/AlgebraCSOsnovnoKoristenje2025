using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numericki_tipovi_implicitno_eksplicitno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iCijeliBroj = 1;
            long lVelikiBroj = 2;
            double dDoubleBroj = 3.456;
            long lJakoVelikiBroj = 9999999999;

            Console.WriteLine("Implicitna pretvorba");
            Console.WriteLine("==========================");

            lVelikiBroj = iCijeliBroj;
            Console.WriteLine(lVelikiBroj);

            dDoubleBroj = lVelikiBroj;
            Console.WriteLine(dDoubleBroj);

            //iCijeliBroj = lVelikiBroj;
            Console.WriteLine(iCijeliBroj);

            //lVelikiBroj = dDoubleBroj;
            Console.WriteLine(lVelikiBroj);

            lVelikiBroj = 2;
            dDoubleBroj = 3.456;
            Console.WriteLine();
            Console.WriteLine("Eksplicitna pretvorba");
            Console.WriteLine("==========================");

            iCijeliBroj = (int)lVelikiBroj;
            Console.WriteLine(iCijeliBroj);

            iCijeliBroj = (int)dDoubleBroj;
            Console.WriteLine(iCijeliBroj);

            iCijeliBroj = (int)lJakoVelikiBroj;
            Console.WriteLine(lJakoVelikiBroj);
            Console.WriteLine(iCijeliBroj);
        }
    }
}
