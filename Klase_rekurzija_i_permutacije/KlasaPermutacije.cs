using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_rekurzija_i_permutacije
{
    internal class KlasaPermutacije
    {
        public void ZamjeniDvaBroja(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void IspisiPermutaciju(int[] lista, int k, int m)
        {
            int i;
            if (k == m)
            {
                for(i = 0; i <=m; i++)
                {
                    Console.Write("{0}", lista[i]);
                }
                Console.Write(" ");
            }
            else
            {
                for(i = k; i <=m; i++)
                {
                    ZamjeniDvaBroja(ref lista[k], ref lista[i]);
                    IspisiPermutaciju(lista, k + 1, m);
                    ZamjeniDvaBroja(ref lista[k], ref lista[i]);
                }
            }
        }
    }
}
