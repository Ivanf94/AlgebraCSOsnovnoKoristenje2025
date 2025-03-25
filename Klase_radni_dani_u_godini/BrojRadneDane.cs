using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_radni_dani_u_godini
{
    internal class BrojRadneDane
    {
        public int PronadjiRadneDane(DateTime pocetak, DateTime kraj)
        {
            int radnih_dana = 0;

            for(DateTime i = pocetak; i <= kraj; i = i.AddDays(1))
            {
                if(JeRadniDan(i))
                    radnih_dana++;
            }

            return radnih_dana;
        }

        public bool JeRadniDan(DateTime dan)
        {
            if (dan.DayOfWeek == DayOfWeek.Saturday || dan.DayOfWeek == DayOfWeek.Sunday)
                return false;

            DateTime[] praznici =
            {
                new DateTime(1,1,1),
                new DateTime(1,1,6),
                new DateTime(1,5,1),
                new DateTime(1,5,30),
                new DateTime(1,6,22),
                new DateTime(1,8,5),
                new DateTime(1,8,15),
                new DateTime(1,11,1),
                new DateTime(1,12,24),
                new DateTime(1,12,25),
                new DateTime(1,12,26)
            };

            for(int i = 0; i < praznici.Length; i++)
            {
                if (dan.Month == praznici[i].Month && dan.Day == praznici[i].Day)
                    return false;
            }

            return true;
        }
    }
}
