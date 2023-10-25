using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_25_feladat
{
    internal class Bolygok
    {
        public string Bolygo;
        public int HoldakSzama;
        public double Arany;

        public Bolygok(string r)
        {
            var v = r.Split(';');
            Bolygo = v[0];
            HoldakSzama = int.Parse(v[1]);
            Arany = double.Parse(v[2].Replace('.',',')); 
        }
    }
}
