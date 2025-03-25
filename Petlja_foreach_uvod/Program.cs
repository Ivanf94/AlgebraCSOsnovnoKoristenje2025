using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Primjer jednostavne foreach petlje s poljima:");
            Console.WriteLine();

            string[] automobili = { "Volva", "Honda", "Ford", "Mazda" };
            foreach(string auto in automobili)
            {
                Console.WriteLine(auto);
            }
            Console.WriteLine();
            for(int i= 0; i < automobili.Length; i++)
            {
                Console.WriteLine(automobili[i]);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Primjer foreach petlje za brojanje muškaraca i žena:");

            char[] spolovi = { 'm', 'ž','m','m','m','ž','ž','m','m','ž' };
            int m = 0, z = 0;
            foreach(char spol in spolovi)
            {
                if (spol == 'm') m++;
                if (spol == 'ž') z++;
            }
            Console.WriteLine("Broj muškaraca je " + m);
            Console.WriteLine("Broj žena je " + z);

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Primjer foreach petlje s kolekcijom:");
            Console.WriteLine();

            List<int> brojevi = new List<int>() { 5, -8, 3, 13, 9, 17, 0, 4, 36, -34 };
            int sum = 0;
            foreach(int broj in brojevi)
            {
                sum += broj;
            }
            Console.WriteLine("Suma="+sum);

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Primjer foreach petlje s naredbom continue:");
            Console.WriteLine();

            List<string> imena = new List<string>() { "Marko", "Ante", "Đuro" };
            foreach(string ime in imena)
            {
                if (ime == "Ante") continue;
                Console.WriteLine(ime);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Primjer foreach petlje s naredbom continue:");
            Console.WriteLine();

            var prezimena = new List<string>() { "Horvat", "Knežević", "Nikolić", "Milanović", "Musk", "Todor"};

            foreach(string prezime in prezimena)
            {
                if (prezime == "Milanović") break;
                Console.WriteLine(prezime);
            }
            Console.WriteLine("Izašli smo iz petlje :)");
        }
    }
}
