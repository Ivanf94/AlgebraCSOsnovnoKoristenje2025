using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_static
{
    internal class StaticnaMetoda
    {
        public static bool Prost(int broj)
        {
            if(broj<=0) return false;
            for (int i = 2; i < broj; i++)
                if (broj % i == 0) return false;
            return true;
        }

        public bool Savrsen(int broj)
        {
            int sum = 1;
            for(int i = 2; i < broj; i++)
            {
                if (broj % i == 0) sum += i;
            }
            if (sum == broj) return true;
            return false;
        }
    }
}
