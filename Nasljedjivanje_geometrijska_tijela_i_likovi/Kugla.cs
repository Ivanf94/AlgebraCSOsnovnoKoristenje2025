using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrijska_tijela_i_likovi
{
    internal class Kugla : Kruznica
    {
        new public double Povrsina
        {
            get { return 4 * base.Povrsina; }
        }

        public double Volumen
        {
            get { return 4 * base.Povrsina * Radius / 3; }
        }
    }
}