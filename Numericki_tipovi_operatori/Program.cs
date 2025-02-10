using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numericki_tipovi_operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, rez;
            float rez2;

            x = 7;
            y = 5;

            rez = x + y;
            Console.WriteLine("x + y = {0}", rez);

            rez = x - y;
            Console.WriteLine("x - y = {0}", rez);

            rez = x * y;
            Console.WriteLine("x * y = {0}", rez);

            rez = x / y;
            Console.WriteLine("x / y = {0}", rez);

            rez2 = (float)x / y;
            Console.WriteLine("x / y = {0}", rez2);

            rez = x % y;
            Console.WriteLine("x % y = {0}", rez);

            rez += x; //rez=rez+x1;
            Console.WriteLine(rez);
        }
    }
}
