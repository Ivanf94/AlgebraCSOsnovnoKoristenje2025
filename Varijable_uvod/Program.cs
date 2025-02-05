using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string varijabla_string;
            int varijabla_broj;
            double varijabla_decimalni_broj;
            bool varijabla_logicka;

            //Console.WriteLine(varijabla_string);
            //Console.WriteLine(varijabla_broj);
            //Console.WriteLine(varijabla_decimalni_broj);
            //Console.WriteLine(varijabla_logicka);


            string moje_ime = "Danijel";
            int cijeli_broj;
            cijeli_broj = 3;
            double decimalni_broj = 5.4;
            bool tocno = true;
            char znak = 'A';

            Console.WriteLine($"Moje ime je {moje_ime}");
            Console.WriteLine("Cijeli broj: "+cijeli_broj);
            Console.WriteLine("Decimalni broj je {0}", decimalni_broj);
            Console.WriteLine("Iskaz je "+tocno);
            Console.WriteLine("Uneseni znak "+znak);

            decimalni_broj = 3.14;
            Console.WriteLine("Nova vrijednost decimalni broj je "+decimalni_broj);
        }
    }
}
