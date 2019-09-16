using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StormLevel
{
    class StormLevel
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Wind speed in mph as an integer: ");
            int speed = int.Parse(Console.ReadLine());

            if (speed >= 74 && speed <= 95)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 1");
            else if (speed >= 96 && speed <= 110)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 2");
            else if (speed >= 111 && speed <= 130)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 3");
            else if (speed >= 131 && speed <= 155)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 4");
            else if (speed > 155)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 5");
        }
    }
}
