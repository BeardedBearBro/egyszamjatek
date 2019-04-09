using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca201904091
{
    class Jatekos
    {
        public string nev;
        public int[] tippek;

        public Jatekos(string sor)
        {
            var t = sor.Split(' ');
            this.nev = t[0];
            this.tippek = new int[t.Length - 1];

            for (int i = 0; i < this.tippek.Length; i++)
            {
                tippek[i] = int.Parse(t[i + 1]);

            }
        }
    }
}