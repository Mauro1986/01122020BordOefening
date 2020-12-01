using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01122020BordOefening.Models;

namespace _01122020BordOefening
{
    class Program
    {
        private static Random random = new Random();
        private const int COUNT = 10;

        static void Main(string[] args)
        {
            Bord[] borden =
            {
            new RondBord("karton", "groen", 30),
            new VierkantBord("porcelijn", "wit", 20),
            new RondBord("plastiek", "blauw", 35),
            new VierkantBord("inox", "zilver", 25),
            };


            Bord[] lijst = new Bord[10];

            for (int i = 0; i < COUNT; i++)
            {
                lijst[i] = borden[random.Next(0, 3)];
            }

            foreach (var item in lijst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
