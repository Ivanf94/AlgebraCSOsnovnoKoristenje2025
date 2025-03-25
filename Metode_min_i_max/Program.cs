using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_min_i_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metode za zamjenu najvećeg i najmanjeg broja u polju");
            Console.WriteLine("=============================");
            Console.WriteLine();

            //MOJA VERZIJA, NA VIDEU MALO DRUGACIJE
            int[] brojevi = new int[10];
            Unos(brojevi);
            Ispis(brojevi);
            Zamjena(brojevi);
            Ispis(brojevi);
        }

        public static void Unos(int[] brojevi)
        {
            Console.WriteLine("Unesite {0} brojeva.", brojevi.Length);
            for(int i = 0; i < brojevi.Length; i++)
            {
                Console.Write("Unesite {0}. broj: ", i + 1);
                brojevi[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void Ispis(int[] brojevi)
        {
            foreach(int broj in brojevi)
            {
                Console.Write(broj + " ");
            }
            Console.WriteLine();
        } 

        public static void Zamjena(int[] brojevi)
        {
            int min = 0, max = 0, temp;
            for(int i = 1; i < brojevi.Length; i++)
            {
                if (brojevi[i] < brojevi[min]) min = i;
                if (brojevi[i] > brojevi[max]) max = i;
            }

            temp = brojevi[min];
            brojevi[min] = brojevi[max];
            brojevi[max] = temp;
        }
    }
}
