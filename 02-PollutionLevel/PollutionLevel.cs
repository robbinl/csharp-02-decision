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

            Console.Write("Enter First Pollution level reading (10 to 100): ");
            level1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Pollution level reading (10 to 100):");
            level2 = double.Parse(Console.ReadLine());
            Console.Write("Enter Third Pollution level reading (10 to 100): ");
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
