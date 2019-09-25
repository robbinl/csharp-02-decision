using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_case_demo
{
    class CaseDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1, 2, or 3: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
                Console.WriteLine("One");
            else if (num == 2)
                Console.WriteLine("Two");
            else if (num == 3)
                Console.WriteLine("Three");
            else
                Console.WriteLine("Invalid 1.");

            // Determine the number entered.
            switch (num)
            {
                case 1:
                    Console.WriteLine("One One");
                    break;

                case 2:
                    Console.WriteLine("Two Two");
                    break;

                case 3:
                    Console.WriteLine("Three Three");
                    break;

                default:
                    Console.WriteLine("Invalid 2.");
                    break;
            }
        }
    }
}
