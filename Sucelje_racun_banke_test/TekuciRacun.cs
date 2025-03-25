using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelje_racun_banke
{
    internal class TekuciRacun : IRacunBanke
    {
        private decimal stanje_na_racunu;

        public decimal Saldo
        {
            get { return stanje_na_racunu; }
        }

        public string IspisSaldo()
        {
            return string.Format("Trenutno na tekućem računu se nalazi {0,6:C}", stanje_na_racunu);
        }

        public void Isplata(decimal iznos)
        {
            if(stanje_na_racunu >= iznos)
                stanje_na_racunu -= iznos;
            else
                Console.WriteLine("Nedovoljno sredstava na računu za izvršiti isplatu!");
        }
        public void Uplata(decimal iznos)
        {
            stanje_na_racunu += iznos;
        }
    }
}
