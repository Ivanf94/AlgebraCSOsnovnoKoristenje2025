using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRING METODE
            //string recenica = "Danas je lijep i sunčan dan!";

            //Console.WriteLine(recenica.ToUpper());
            //Console.WriteLine(recenica.ToLower());

            //Console.WriteLine(recenica.Substring(0, 7));
            //Console.WriteLine(recenica.Substring(5));
            //Console.WriteLine(recenica.Substring(0, recenica.Length - 1));
            //Console.WriteLine(recenica.Last());

            //Console.WriteLine(recenica[recenica.Length - 1]);
            //Console.WriteLine(recenica.First());

            //Console.WriteLine(recenica.IndexOf("."));
            //Console.WriteLine(recenica.IndexOf("a"));
            //Console.WriteLine(recenica.IndexOf(" ", 5));

            //Console.WriteLine(recenica.Replace(" ", "Sutra"));

            //string[] rijeci = recenica.Split(' ');
            //foreach(var rijec in rijeci)
            //{
            //    Console.WriteLine(rijec);
            //}

            //Console.WriteLine(recenica.Insert(2, " jako"));
            //Console.WriteLine(recenica.PadLeft(10));
            //Console.WriteLine(recenica.PadRight(10));

            //Console.WriteLine(recenica.Remove(2, 2));
            //Console.WriteLine(recenica.Replace("je", ""));

            //RAD S CHAROVIMA
            //char slovo1 = 's';
            //char slovo2 = 'r';
            //char slovo3 = 'i';
            //char slovo4 = 'j';
            //char slovo5 = 'e';
            //char slovo6 = 'd';
            //char slovo7 = 'a';
            //char slovo8 = '!';

            //Console.WriteLine(slovo1+slovo2+slovo3+slovo4+slovo5+slovo6+slovo7+slovo8);
            //string tekst = "" + slovo1 + slovo2 + slovo3 + slovo4 + slovo5 + slovo6 + slovo7 + slovo8;
            //Console.WriteLine(tekst);
            //string spoji_s_metodom = string.Concat(slovo1, slovo2, slovo3, slovo4, slovo5, slovo6, slovo7, slovo8,'g');
            //Console.WriteLine(spoji_s_metodom);
            //Console.WriteLine();

            //int cijeli_broj = 13;
            //Console.WriteLine(cijeli_broj.ToString());
            //double decimalni_broj = 2.15;
            //Console.WriteLine(decimalni_broj.ToString());
            //bool kisa_pada = true;
            //Console.WriteLine(kisa_pada.ToString());
            //Console.WriteLine();

            string x = "22";
            string y = "32";
            string zbroj = x + y;
            Console.WriteLine("Zbroj stringova je " + zbroj);

            int pretvori_x = Convert.ToInt32(x);
            int pretvori_y = Convert.ToInt32(y);
            int novi_zbroj = pretvori_x + pretvori_y;
            Console.WriteLine(novi_zbroj);
            Console.WriteLine();
            Console.WriteLine("bla " + pretvori_x);
            Console.WriteLine();

            char i = 'A';
            char j = '8';
            int zbroj_charova = i + j;
            Console.WriteLine("Zbroj charova je " + (char)zbroj_charova);

            int pretvori_i = (int)Char.GetNumericValue(i);
            Console.WriteLine(pretvori_i);
            int pretvori_j = (int)Char.GetNumericValue(j);
            Console.WriteLine(pretvori_j);
            int zbroj_intova = pretvori_i + pretvori_j;
            Console.WriteLine("Točan zbroj znakova je " + zbroj_intova);

            Console.WriteLine();

            int m = Convert.ToInt32(i);
            int n = Convert.ToInt32(j);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine("Zbroj charova m i n je " + m + n);

            //Console.WriteLine();

            //int m2 = i;
            //int n2 = j;
            //Console.WriteLine(m2);
            //Console.WriteLine(n2);
            //Console.WriteLine("Zbroj charova m2 i n2 je " + m2 + n2);

            //string recenica = "Danas radimo sa stringovima.";
            //string[] rijeci = recenica.Split(' ');
            //for (int g = 0; g < rijeci.Length; g++)
            //{
            //    Console.WriteLine(rijeci[g]);
            //}

            //RAČUNSKE OPERACIJE
            //int a, b;
            //char o;
            //char buffer;
            //Console.Write("Unesite prvi broj: ");
            //a = int.Parse(Console.ReadLine());

            //Console.Write("Unesite operaciju: ");
            //o = Console.ReadKey().KeyChar;
            //buffer = (char)Console.Read();
            //char nextChar = (char)Console.Read();

            //Console.Write("Unesite drugi broj: ");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ovdje je" + buffer + "ispred ovog teksta");

            ////Console.WriteLine("Uneseni " + buffer + " znak je " + o);
            //switch (o)
            //{
            //    case '+':
            //        Console.WriteLine("a + b = " + (a + b));
            //        break;
            //    case '-':
            //        Console.WriteLine("a - b = " + (a - b));
            //        break;
            //    case '*':
            //        Console.WriteLine("a * b = " + (a * b));
            //        break;
            //    case '/':
            //        Console.WriteLine("a / b = " + (a / b));
            //        break;
            //    default:
            //        Console.WriteLine("Unesena je kriva operacija");
            //        break;
            //}

            //HARRY POTTER
            //Console.WriteLine("Hogwards škola");
            //Console.WriteLine("======================");
            //Console.WriteLine();

            //double programiranje, fizika, kemija, ukupno;
            //string ime, prezime, rezultat;
            //double prosjek;

            //Console.Write("Unesite ime učenika: ");
            //ime = Console.ReadLine();
            //Console.Write("Unesite prezime: ");
            //prezime = Console.ReadLine();

            //Console.Write("Unesite bodove iz programiranja: ");
            //programiranje = double.Parse(Console.ReadLine());
            //Console.Write("Unesite bodove iz fizike: ");
            //fizika = double.Parse(Console.ReadLine());
            //Console.Write("Unesite bodove iz kemije: ");
            //kemija = double.Parse(Console.ReadLine());

            //ukupno = programiranje + kemija + fizika;
            //prosjek = ukupno / 3;

            //if(prosjek >= 60)
            //{
            //    rezultat = "Slytherin";
            //}
            //else if(prosjek >= 48)
            //{
            //    rezultat = "Ravenclaw";
            //}
            //else if(prosjek >= 36)
            //{
            //    rezultat = "Hufflepuff";
            //}
            //else
            //{
            //    rezultat = "Gryffindor";
            //}

            //Console.WriteLine();
            //Console.WriteLine("Ime i prezime učenika {0} {1}", ime, prezime);
            //Console.WriteLine("Ukupno ima {0} bodova, odnosno {1}", ukupno, prosjek);
            //Console.WriteLine("Dodijeljen je kući "+ rezultat);

            //TROŠKOVI POSLOVANJA
            //Console.WriteLine("Izračun prihoda i gubitaka");
            //Console.WriteLine("============================");
            //Console.WriteLine();

            //decimal trosak, prodaja, ruc;

            //Console.Write("Unesite cijene troškova: ");
            //trosak = decimal.Parse(Console.ReadLine());
            //Console.Write("Unesite prodajnu cijenu proizvoda: ");
            //prodaja = Convert.ToDecimal(Console.ReadLine());

            //if (trosak > prodaja)
            //{
            //    ruc = trosak - prodaja;
            //    Console.WriteLine("U gubitku smo "+ ruc);
            //}
            //else if(prodaja > trosak)
            //{
            //    ruc = prodaja - trosak;
            //    Console.WriteLine("U dobitku smo "+ ruc);
            //}
            //else
            //{
            //    Console.WriteLine("Na nuli smo");
            //}

            // KVADRATNA JEDNADŽBA
            //Console.WriteLine("Računanje rješenja kvadratne jednadžbe:");
            //Console.WriteLine("===========================================");
            //Console.WriteLine();

            //double a, b, c, d, x1, x2;
            //Console.Write("Unesi a: ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("Unesi b: ");
            //b = double.Parse(Console.ReadLine());
            //Console.Write("Unesi c: ");
            //c = double.Parse(Console.ReadLine());
            //d = b * b - 4 * a * c;

            //if (d == 0)
            //{
            //    x1 = -b / (2 * a);
            //    x2 = x1;
            //    Console.WriteLine("Dvostruko rješenje: x1 = x2 = " + x1);
            //}
            //else if(d > 0)
            //{
            //    x1 = (-b + Math.Sqrt(d)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(d)) / (2 * a);
            //    Console.WriteLine("Prvo rješenje je " + x1 + " a drugo je " + x2);
            //}
            //else
            //{
            //    Console.WriteLine("Jednadžba nema realnih rješenja!");
            //}
        }
    }
}
