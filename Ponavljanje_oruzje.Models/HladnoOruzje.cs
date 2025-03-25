using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_oruzje.Models
{
    public enum Hvatista
    {
        Jednorucno,
        Dvorucno
    }
    public class HladnoOruzje : Oruzje
    {
        private Hvatista hvatista;
        public Hvatista Hvatiste
        {
            get { return hvatista; }
            set { hvatista = value; }
        }
    }
}
