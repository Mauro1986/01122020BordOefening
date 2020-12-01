using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01122020BordOefening.Models
{
    public class VierkantBord : Bord
    {
        public double zijde;

        public double Zijde
        {
            get { return zijde; }
            set { zijde = value; }
        }

        public VierkantBord(string materiaal, string kleur, double zijde) : base(materiaal, kleur)
        {
            Zijde = zijde;
        }

        public override double oppervlakte()
        {
           return Zijde * Zijde;
        }

        public override string ToString()
        {
            string s = $"Materiaal: {Materiaal}  Kleur: {Kleur}  Zijde:{Zijde}";

            return s;
        }
    }
}
