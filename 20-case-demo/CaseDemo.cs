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

            // Determine the number entered.
            switch (num)
            {
                case 1:
                    Console.WriteLine("ONE ONE ONE");
                    break;

                case 2:
                    Console.WriteLine("Two Two Two.");
                    break;

                case 3:
                    Console.WriteLine("That's a THREE baby!!!");
                    break;

                default:
                    Console.WriteLine("Way to mess it all up budday.");
                    break;
            }
        }
    }
}
