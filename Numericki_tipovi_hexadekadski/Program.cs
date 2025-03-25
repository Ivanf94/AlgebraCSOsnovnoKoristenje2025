using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numericki_tipovi_hexadekadski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32("A7",16);

            Console.WriteLine(i);

            i = 1015;
            Console.WriteLine(i.ToString("X")); // 0x35202B3A
            string oktalni = Convert.ToString(i, 8);
            Console.WriteLine(oktalni);
        }
    }
}
