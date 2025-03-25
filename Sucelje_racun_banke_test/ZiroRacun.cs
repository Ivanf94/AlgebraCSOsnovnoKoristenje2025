using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelje_racun_banke
{
    internal class ZiroRacun : IRacunBanke
    {
        private decimal stanje;
        public decimal Saldo
        {
            get { return stanje; }
        }

        public string IspisSaldo()
        {
            return string.Format("Trenutno na žiro računu se nalazi {0,6:C}", stanje);
        }

        public void Isplata(decimal iznos)
        {
            if (stanje >= iznos)
                stanje -= iznos;
            else
                Console.WriteLine("Nedovoljno sredstava na računu za izvršiti isplatu!");
        }

        public void Uplata(decimal iznos)
        {
            stanje += iznos;
        }
    }
}