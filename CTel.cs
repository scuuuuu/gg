using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg
{
    internal class CTel
    {
        public int numero { get;set; }
        public int durata { get; set; }
        public CTel(int n, int d) 
        {
            numero = n;
            durata = d;
        }
    }
}
