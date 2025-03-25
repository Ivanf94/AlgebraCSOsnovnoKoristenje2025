using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_godisnja_doba
{
    public enum GodisnjaDoba
    {
        Proljeće,
        Ljeto,
        Jesen,
        Zima
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GodisnjaDoba doba = GodisnjaDoba.Jesen;
            Console.WriteLine($"Vrijednost {doba} je {(int)doba}");

            var b = (GodisnjaDoba)1;
            Console.WriteLine(b);

            var c = (GodisnjaDoba)5;
            Console.WriteLine(c);
        }
    }
}
