using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PollutionLevel
{
    class PollutionLevel
    {
        static void Main(string[] args)
        {
            const double CUTOFF = 50.0;
            double level1,
                   level2,
                   level3,
                   average;

            Console.WriteLine("Enter First Pollution level reading:");
            level1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Pollution level reading:");
            level2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Pollution level reading:");
            level3 = double.Parse(Console.ReadLine());

            average = (level1 + level2 + level3) / 3;

            // Check for hazardous condition.
            if (average >= CUTOFF)
                Console.WriteLine("HAZARDOUS CONDITION!!1");
            else
                Console.WriteLine("Nah it's safe.");
        }
    }
}
