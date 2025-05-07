using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg
{
    internal class CSim
    {
        public int numero { get; set; }
        public double credito { get; set; }
        public List<CTel> chiamate = new List<CTel>();
        public CSim(int n,double c)
        {
            numero = n;
            credito = c;
        }
        public void aggiungiCall(int numero,int durata)
        {
            credito -= durata * 0.01;
            chiamate.Add(new CTel(numero,durata));
        }
        public string mostra()
        {
            string tot = "";
            foreach(var c in chiamate)
            {
                tot += $"\n{c.numero} {c.durata}";
            }
            return tot;
        }
        public int minuti()
        {
            int somma = 0;
            foreach(var c in chiamate)
            {
                somma += c.durata;
            }
            return somma;
        }
        public string dati()
        {
            string tot = "";
            tot = $"{numero} - {credito}";
            return tot;
        }
    }
}
