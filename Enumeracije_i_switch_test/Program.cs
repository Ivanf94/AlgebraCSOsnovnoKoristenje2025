using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_i_switch
{
    enum Razina
    {
        Nisko,
        Srednje,
        Visoko
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Razina vodostaj = Razina.Srednje;
            switch (vodostaj)
            {
                case Razina.Nisko:
                    Console.WriteLine("Zatvaraj branu!");
                    break;
                case Razina.Srednje:
                    Console.WriteLine("Normalan tok!");
                    break;
                case Razina.Visoko:
                    Console.WriteLine("Otvaraj branu, moguća poplava!");
                    break;
            }
        }
    }
}
