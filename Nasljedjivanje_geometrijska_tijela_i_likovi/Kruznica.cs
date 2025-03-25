using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrijska_tijela_i_likovi
{
    internal class Kruznica
    {
        private double radius;
        
        public double Radius
        {
            get 
            { 
                if (radius < 0) return 0.00;
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Promjer
        {
            get { return Radius * 2; }
        }

        public double Opseg
        {
            get { return Promjer * Math.PI; }
        }

        public double Povrsina
        {
            get { return Opseg / 2 * Radius; }
        }
    }
}