using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_brojevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte broj = 128;
            Console.WriteLine($"{broj}  {byte.MinValue}  {byte.MaxValue}");
            //broj = 765;

            short broj2 = -300;
            Console.WriteLine($"{broj2}  {short.MinValue}  {short.MaxValue}");

            ushort broj22 = 123;
            Console.WriteLine($"{broj22}  {ushort.MinValue}  {ushort.MaxValue}");
        }
    }
}
