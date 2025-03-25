using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_uvod
{
    enum StrucnaSprema
    {
        SSS,
        VŠS,
        VSS,
        NKV,
        PKV
    }

    enum Spol
    {
        Muski = 0,
        Zenski = 1,
        Nepoznato = 1000
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Ivo", "Ivić", Spol.Muski);

            o.Spol = Spol.Nepoznato;
            Console.WriteLine("Spol: "+o.Spol);
            Console.WriteLine("Vrijednost enumeracije: "+(int)o.Spol);

            switch (o.Spol)
            {
                case Spol.Muski:
                    Console.WriteLine("Muško je");
                    break;
                case Spol.Zenski:
                    Console.WriteLine("Žena");
                    break;
                case Spol.Nepoznato:
                    Console.WriteLine("Nebinaran ili tko zna šta...");
                    break;
                default:
                    Console.WriteLine("Ni sam ne zna šta je...");
                    break;
            }

            o.Sprema = StrucnaSprema.PKV;
            Console.WriteLine(o.Sprema);
            Console.WriteLine((int)o.Sprema);
        }
    }
}
