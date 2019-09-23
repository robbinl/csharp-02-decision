using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2018F_IC_if_else_LeapYear
{
    class LeapYear
    {
        /*
       * Purpose: Determine whether or not a year is a leap year
       * 
       * Input: the year in question.
       * 
       * Process: Get input from user.
       *          Use logical operators to determine whether a year is a leap year.
       *
       * Output: Whether the year is a leap year.
       *         
       * Written By: Robbin Law
       * Date Modified: 2019.09.19
       * */
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = false;

            // (if year is divisible by 4 AND the year is not divisible by 100)
            // OR the year is divisible by 400.
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                isLeapYear = true;
            }

            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year!");
            }
            else
            {
                Console.WriteLine($"{year} is NOT a leap year.");
            }
        }
    }
}
