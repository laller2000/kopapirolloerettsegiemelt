using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo
{
    class Jatek
    {
        //0-1
        public int kod1;
        public int kod2;
        public int donto;

        public int Kod1 { get => kod1; set => kod1 = value; }
        public int Kod2 { get => kod2; set => kod2 = value; }
        public int Donto { get => donto; set => donto=value; }
        public Jatek(int kod1, int kod2)
        {
            Kod1 = kod1;
            Kod2 = kod2;
        }
        public Jatek(string sor)
        {
            string[] adatok=sor.Split('-');
            Kod1 = int.Parse(adatok[0]);
            Kod2 = int.Parse(adatok[1]);
        }
    }
}
