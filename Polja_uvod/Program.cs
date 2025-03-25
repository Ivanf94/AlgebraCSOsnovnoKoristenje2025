using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polja_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = new int[5];
            int[] brojevi2 = new int[] { 1, 3, 5, 7, 9 };
            int[] brojevi3 = { 1, 2, 3, 5, 6, 7 };

            brojevi = new int[6];
            //brojevi = { 2,3,5,6,7,8,9 };

            brojevi = new int[5];
            brojevi[0] = 54;
            brojevi[1] = 43 + 34;
            brojevi[2] = brojevi[0];
            brojevi[4] = 100;
            //brojevi[5] = 200;

            string[] auti = { "Honda", "Subaru", "Lexus", "Infinity" };
            Console.WriteLine(auti[0]);

            Console.WriteLine(auti[2]);
            auti[2] = "Ford";
            Console.WriteLine(auti[2]);

            Console.WriteLine("Broj elemenata "+auti.Length);

            int[,] ploca = new int[8, 7];
            ploca[0,0] = 3;
            ploca[3, 2] = ploca[0, 0];
            Console.WriteLine(ploca[3,2]);
            Console.WriteLine(ploca.GetLength(0) + " " + ploca.GetLength(1));
        }
    }
}
