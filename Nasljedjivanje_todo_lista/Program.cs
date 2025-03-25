using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_todo_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista moja_lista = new Lista();
            moja_lista.Dodaj("Trava", "Daj pokosi i očisti dvorište!");

            while (true)
            {
                moja_lista.NovaStavkaListe();
                Console.WriteLine();
                Console.Write("Želite li dalje unositi? (d=da, n=ne): ");
                string odgovor = Console.ReadLine();
                if (odgovor.ToLower() != "d") break;
            }
            Console.WriteLine();
            moja_lista.IspisListe();
        }
    }
}
