using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_overloading
{
    internal class Program
    {
        public static int Mnozenje(int prvi, int drugi)
        {
            return prvi * drugi;
        }

        public static int Mnozenje(int a, int b, int c)
        {
            return a * b * c;
        }

        public static int Mnozenje(int a, int b, int c,int d)
        {
            return a * b * c * d;
        }

        public static float Mnozenje(int a, int b, int c, int d, int e)
        {
            return Mnozenje(a, b, c, d) * e;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Množenje dva broja: "+Mnozenje(10,15));
            Console.WriteLine("Množenje tri broja: "+Mnozenje(8,13,20));
            Console.WriteLine("Množenje pet brojeva: " + Mnozenje(3,7,10,3,2));
        }

    }
}
