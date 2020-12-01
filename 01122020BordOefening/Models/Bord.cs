using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01122020BordOefening.Models
{
    public class Bord
    {
        public string Materiaal { get; set; }
        public string Kleur { get; set; }

        public Bord(string materiaal, string kleur)
        {
            Materiaal = materiaal;
            Kleur = kleur;
        }

        public virtual double oppervlakte()
        {
            return 0.00;
        }

        public override string ToString()
        {
            string s = $"Materiaal: {Materiaal}  Kleur: {Kleur}";

            return s;
        }
    }
}
