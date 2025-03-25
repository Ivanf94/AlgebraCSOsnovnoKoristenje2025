using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelje_racun_banke
{
    internal interface IRacunBanke
    {
        void Isplata(decimal unos);
        void Uplata(decimal unos);
        string IspisSaldo();
        decimal Saldo { get; }
    }
}
