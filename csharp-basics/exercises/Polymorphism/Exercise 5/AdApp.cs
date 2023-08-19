using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class AdApp
    {
        static void Main(string[] args)
        {
            Program[] programs = new Program[]
            {
            new Hoarding(100, 7, true),
            new NewspaperAd(10, 30),
            new TVCommercial(50, 60, true),
            new Poster(20, 2.5, 100, 0.1)
            };

            foreach (var program in programs)
            {
                Console.WriteLine($"Total Cost: {program.CalculateCost()}");
            }
        }
    }
}