using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_prosti_brojevi_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();
            char[] znakovi = recenica.ToCharArray();

            for(int i = 1; i < recenica.Length; i++)
                for(int j = 0; j < recenica.Length - 1; j++)
                {
                    if (znakovi[j] > znakovi[j + 1])
                    {
                        char znak = znakovi[j];
                        znakovi[j] = znakovi[j + 1];
                        znakovi[j + 1] = znak;
                    }
                }

            for (int i = 0; i < znakovi.Length; i++)
                Console.Write(znakovi[i] + " ");
        }
    }
}
