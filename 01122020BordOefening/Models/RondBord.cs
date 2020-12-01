using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01122020BordOefening.Models
{
    public class RondBord : Bord
    {
        public double diameter;
     
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public RondBord(string materiaal, string kleur, double diameter): base(materiaal, kleur)
        {
            Diameter = diameter;
        }

        public override double oppervlakte()
        {
            return ((Diameter/2)*(Diameter / 2))*3.14 ;
        }

        public override string ToString()
        {
            string s = $"Materiaal: {Materiaal}  Kleur: {Kleur}  Diameter{Diameter}";

            return s;
        }
    }
}
