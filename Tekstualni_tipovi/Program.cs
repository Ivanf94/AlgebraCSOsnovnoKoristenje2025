using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tekstualni_tipovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas je lijep i sunčan dan!";
            Console.WriteLine(recenica);

            string abeceda = "ABCČĆDDŽĐEFGHIJKLLJMNNJOPRSŠTUVZŽ";
            Console.WriteLine("Dužina teksta varijable abeceda je " + abeceda.Length);

            string uredi_slova = "Bok, jesi za pivu?";
            Console.WriteLine(uredi_slova.ToUpper());
            Console.WriteLine(uredi_slova.ToLower());

            string ime = "Nikola";
            string prezime = "Tesla";
            string ime_prezime = ime + " " + prezime;
            Console.WriteLine(ime_prezime);

            //char

            char slovo1 = 's';
            char slovo2 = 'r';
            char slovo3 = 'i';
            char slovo4 = 'j';
            char slovo5 = 'e';
            char slovo6 = 'd';
            char slovo7 = 'a';
            char slovo8 = '!';

            Console.WriteLine("Danas je " + slovo1 + slovo2 + slovo3 + slovo4 + slovo5 + slovo6 + slovo7 + slovo8);
            Console.WriteLine();

            int zbroj = slovo1 + slovo2 + slovo3 + slovo4 + slovo5 + slovo6 + slovo7 + slovo8;
            Console.WriteLine(zbroj);
            string spoji_slova = slovo1 + "" + slovo2 + "" + slovo3 + "" + slovo4 + "" + slovo5 + "" + slovo6 + "" + slovo7 + "" + slovo8;
            Console.WriteLine("Danas je "+spoji_slova);

            string spoji_s_metodom = string.Concat(slovo1, slovo2, slovo3, slovo4, slovo5, slovo6, slovo7, slovo8);
            Console.WriteLine("Danas je "+spoji_s_metodom);

            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("Pretvorba u tip string:");
            Console.WriteLine("=============================");
            Console.WriteLine();

            int cijeli_broj = 13;
            double decimalni_broj = 2.15;
            bool kisa_pada = true;
            Console.WriteLine(cijeli_broj.ToString());
            Console.WriteLine(decimalni_broj.ToString());
            Console.WriteLine(kisa_pada.ToString());

            Console.WriteLine();

            string x = "22", y = "32";
            string zbroj2 = x + y;
            Console.WriteLine("Zbroj je " + zbroj2);

            int pretvori_x = Convert.ToInt32(x);
            int pretvori_y = Convert.ToInt32(y);
            int novi_zbroj = pretvori_x + pretvori_y;
            Console.WriteLine("Točan zbroj je " + novi_zbroj);

            Console.WriteLine();

            char i = '1'; //49
            char j = '8'; //56

            int zbroj_znakova = i + j;
            Console.WriteLine("Zbroj znakova je " + zbroj_znakova);

            int pretvori_i = (int)Char.GetNumericValue(i);
            int pretvori_j = (int)Char.GetNumericValue(j);
            int novi_zbroj_znakova = pretvori_i + pretvori_j;
            Console.WriteLine("Točan zbroj znakova je " + novi_zbroj_znakova);

            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("Pomocne metode string-a:");
            Console.WriteLine("=============================");
            Console.WriteLine();

            Console.WriteLine(recenica);
            Console.WriteLine(recenica.ToUpper());
            Console.WriteLine(recenica.ToLower());

            Console.WriteLine(recenica.Substring(0,5));
            Console.WriteLine(recenica.Substring(6));
            Console.WriteLine(recenica.Length);

            Console.WriteLine(recenica.Substring(0, recenica.Length-1));
            Console.WriteLine(recenica[recenica.Length-1]);
            Console.WriteLine(recenica.Last());

            Console.WriteLine(recenica.Substring(0, 1));
            Console.WriteLine(recenica[0]);
            Console.WriteLine(recenica.First());

            Console.WriteLine(recenica.IndexOf("."));
            Console.WriteLine(recenica.IndexOf(" "));
            Console.WriteLine(recenica.IndexOf(" ", 6));

            Console.WriteLine(recenica.Replace("Danas", "Sutra"));
            Console.WriteLine(recenica.Replace(" ","\t"));
            Console.WriteLine(recenica.Replace(" ","\n"));
            Console.WriteLine(recenica.Replace("a","b"));
            string[] rijeci = recenica.Split(' ');
            foreach(var rijec in rijeci) {  Console.WriteLine(rijec); }

            Console.WriteLine(recenica.Insert(8, " jako"));
            Console.WriteLine(recenica.PadLeft(8));
            Console.WriteLine(recenica.PadLeft(30));
            Console.WriteLine(recenica.Remove(9, 8));
            Console.WriteLine(recenica.Replace("lijep i", ""));
        }
    }
}