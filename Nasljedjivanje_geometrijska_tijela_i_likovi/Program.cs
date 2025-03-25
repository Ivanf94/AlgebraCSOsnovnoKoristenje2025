using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrijska_tijela_i_likovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var krug = new Kruznica();
            krug.Radius = 13.47;

            Console.WriteLine("Karakteristike kruga: ");
            Console.WriteLine("Radius:     "+krug.Radius);
            Console.WriteLine("Promjer:    "+krug.Promjer);
            Console.WriteLine("Površina:   "+krug.Povrsina);
            Console.WriteLine("Opseg:      "+krug.Opseg);
            Console.WriteLine();

            var lopta = new Kugla();
            lopta.Radius = 13.47;

            Console.WriteLine("Karakteristike lopte: ");
            Console.WriteLine("Radius:     " + lopta.Radius);
            Console.WriteLine("Promjer:    " + lopta.Promjer);
            Console.WriteLine("Površina:   " + lopta.Povrsina);
            Console.WriteLine("Opseg:      " + lopta.Opseg);
            Console.WriteLine("Volumen:    " + lopta.Volumen);
            Console.WriteLine();
        }
    }
}
