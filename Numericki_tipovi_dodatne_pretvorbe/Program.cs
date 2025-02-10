using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numericki_tipovi_dodatne_pretvorbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer tipovi:");
            Console.WriteLine("=============================");

            //byte
            byte byte1 = 255;
            //byte byte2 = -128;
            sbyte signed_byte1 = -128;
            sbyte signed_byte2 = 127;

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            //short
            short short1 = -32768;
            short short2 = 32767;
            //short short3 = 35000;

            ushort ushort1 = 65535;
            //ushort ushort2 = -32000;

            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);

            //int
            int i = -2147483648;
            int j = 2147483647;
            //int k = 4294967295;

            uint uint1 = 4294967295;
            //uint uint2 = -1;

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);

            int hex = 0x2F;
            int bin = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(bin);

            //long
            long long1 = -9223372036854775808;
            long long2 = 9223372036854775807;

            ulong ulong1 = 1844672036854775808;
            //ulong ulong2 = 182233720368547758080ul;

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);

            Console.WriteLine();
            Console.WriteLine("Decimalni tipovi:");
            Console.WriteLine("=============================");

            //float
            float float1 = 123456.5F;
            float float2 = 1.123456F;
            Console.WriteLine(float1);
            Console.WriteLine(float2);

            float float3 = 1.123456789f;
            Console.WriteLine(float3);

            //double
            double double1 = 12345678912345.5;
            double double2 = 1.123456789123456;
            Console.WriteLine(double1);
            Console.WriteLine(double2);

            double double3 = 1.12345678912345678912345;
            Console.WriteLine(double3);

            //decimal
            decimal decimal1 = 123456789123456789123456789.5m;
            decimal decimal2 = 1.123456789123456789123456789123m;
            Console.WriteLine(decimal1);
            Console.WriteLine(decimal2);

            decimal decimal3 = 1.123456789123456789123456789123456789m;
            Console.WriteLine(decimal3);
        }
    }
}
