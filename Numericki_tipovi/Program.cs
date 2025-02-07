using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numericki_tipovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cjelobrojni tipovi:
            byte bajt = 134;
            Console.WriteLine($"{bajt} {byte.MinValue} {byte.MaxValue}");

            short kratki_broj = 345;
            Console.WriteLine($"{kratki_broj} {short.MinValue} {short.MaxValue}");
            ushort kratki_broj_bez_predznaka = 24543;
            Console.WriteLine($"{kratki_broj_bez_predznaka} {ushort.MinValue} {ushort.MaxValue}");

            int broj = 12421;
            uint broj_bez_predznaka = 24312;
            Console.WriteLine($"{broj} {int.MinValue} {int.MaxValue}");
            Console.WriteLine($"{broj_bez_predznaka} {uint.MinValue} {uint.MaxValue}");

            broj = int.MaxValue;
            broj = broj + 7;
            Console.WriteLine(broj);

            long veliki_broj = 12421;
            ulong veliki_broj_bez_predznaka = 24312;
            Console.WriteLine($"{veliki_broj} {long.MinValue} {long.MaxValue}"); 
            Console.WriteLine($"{veliki_broj_bez_predznaka} {ulong.MinValue} {ulong.MaxValue}");

            Console.WriteLine();
            //Decimalni podatkovni tipovi:
            float float_broj = 5.66f;
            double double_broj = 134.56;
            decimal decimal_broj = 1234567.890123456789M;
            Console.WriteLine($"{float_broj} {float.MinValue} {float.MaxValue} {float.Epsilon}");
            Console.WriteLine($"{double_broj} {double.MinValue} {double.MaxValue} {double.Epsilon}");
            Console.WriteLine($"{decimal_broj} {decimal.MinValue} {decimal.MaxValue}");

            float test = 80000000002;
            Console.WriteLine($"{test}");
            test = test + 10;
            Console.WriteLine($"{test}");

            double test2 = 80000000002;
            Console.WriteLine($"{test2}");
            test2 = test2 + 10;
            Console.WriteLine($"{test2}");

            Console.WriteLine();
            Console.WriteLine();
            // Pretvaranje (type-casting)

            //Implicitno (automatski)
            int imp_broj = 11;
            double imp_u_dec = imp_broj;
            Console.WriteLine(imp_broj);
            Console.WriteLine(imp_u_dec);
            //imp_broj = imp_u_dec;

            //Eksplicitno (ručno)
            double eks_broj = 14.69;
            int pretvori_u_int = (int)eks_broj;
            Console.WriteLine(eks_broj);
            Console.WriteLine(pretvori_u_int);

            //Metode pretvorbe preko Convert
            int broj1 = 13;
            long broj2 = 1234567890123456;
            float broj3 = 7.54f;
            double broj4 = 14.09865;
            decimal broj5 = 4456.9946872364163M;
            // Convert zaokruzi broj, dok eksplicitno nije
            Console.WriteLine(Convert.ToString(broj1));
            Console.WriteLine(Convert.ToDouble(broj2));
            Console.WriteLine(Convert.ToInt32(broj3));
            Console.WriteLine(Convert.ToString(broj4));
            Console.WriteLine(Convert.ToInt64(broj5));

            string s1 = "100";
            string s2 = "10.10";
            string s3 = "dvadeset i sedam";
            Console.WriteLine(Convert.ToInt32(s1));
            Console.WriteLine(Convert.ToDouble(s1));
            Console.WriteLine(Convert.ToDouble(s2));
            //Console.WriteLine(Convert.ToInt32(s3));
        }
    }
}