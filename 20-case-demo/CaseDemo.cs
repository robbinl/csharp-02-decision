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
            int num1 = int.Parse(Console.ReadLine());

            if (num1 == 1)
                Console.WriteLine("One");
            else if (num1 == 2)
                Console.WriteLine("Two");
            else if (num1 == 3)
                Console.WriteLine("Three");
            else
                Console.WriteLine("Invalid 1.");

            // Determine the number entered.
            switch (num1)
            {
                case int num when num == 1:
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
