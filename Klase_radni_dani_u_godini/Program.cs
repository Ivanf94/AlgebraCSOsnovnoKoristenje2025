using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_radni_dani_u_godini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrojRadneDane radni_dani = new BrojRadneDane();

            Console.Write("Unesite pocetni datum: ");
            DateTime poc = DateTime.ParseExact(Console.ReadLine(), 
                "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Unesite krajnji datum: ");
            DateTime kraj = DateTime.ParseExact(Console.ReadLine(),
                "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Radnih dana u danom periodu: " + radni_dani.PronadjiRadneDane(poc,kraj));
        }
    }
}
