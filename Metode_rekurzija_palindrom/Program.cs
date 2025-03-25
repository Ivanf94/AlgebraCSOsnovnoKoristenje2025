using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Metode_rekurzija_palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzivna provjera je li riječ palindrom ili ne:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            string rijec;
            Console.Write("Unesite rijec: ");
            rijec = Console.ReadLine();

            if (Palindrom(rijec)) 
                Console.WriteLine("Riječ je palindrom.");
            else 
                Console.WriteLine("Riječ nije palindrom");

            rijec = "sajgassjfsmvass";
            DateTime poc, kraj;
            poc = DateTime.Now;
            for(int i = 0; i < 100000; i++)
                Palindrom(rijec);
            kraj = DateTime.Now;
            Console.WriteLine("Trajanje: "+(kraj-poc).TotalMilliseconds+" ms");

            poc = DateTime.Now;
            for (int i = 0; i < 100000; i++)
                Palindrom2(rijec);
            kraj = DateTime.Now;
            Console.WriteLine("Trajanje: " + (kraj - poc).TotalMilliseconds + " ms");

            poc = DateTime.Now;
            for (int i = 0; i < 100000; i++)
                Palindrom3(rijec);
            kraj = DateTime.Now;
            Console.WriteLine("Trajanje: " + (kraj - poc).TotalMilliseconds + " ms");
        }

        public static bool Palindrom(string rijec)
        {
            if (rijec.Length <= 1) return true;
            if (rijec[0] != rijec[rijec.Length - 1]) return false;
            return Palindrom(rijec.Substring(1, rijec.Length - 2));
        }

        public static bool Palindrom2(string rijec)
        {
            return rijec == string.Concat(rijec.Reverse().ToArray());
        }

        public static bool Palindrom3(string rijec)
        {
            int len = rijec.Length;
            for(int i = 0; i < len/2; i++)
                if (rijec[i] != rijec[rijec.Length - 1 -i]) return false;
            return true;
        }
    }
}
