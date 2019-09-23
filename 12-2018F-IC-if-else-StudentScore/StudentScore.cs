using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2018F_IC_if_else_StudentScore
{
    /*
   * Purpose: Display the appropriate letter grade for a percentage score on test.
   * 
   * Input: The student's score as a percent, in a number from (0-100)
   * 
   * Process: Get input from user.
   *          Use if-statements to determine letter grade.
   *
   * Output: The student's letter grade.
   *         
   * Written By: Robbin Law
   * Date Modified: 2019.09.19
   * */
    class Program
    {
        static void Main(string[] args)
        {
            // Get user Input
            Console.WriteLine("Enter student's grade % (0-100):");
            int grade = int.Parse(Console.ReadLine());

            // Store our letter grade in a char.
            string letterGrade;
            char letterGradeChar;
            // Calculate our letter grade with If statements.
            if (grade > 100)
                {
                letterGradeChar = 'X';
                letterGrade = "X";
                }
            else if (grade >= 80 && grade <= 100)
                letterGrade = "A";
            else if (grade >= 70 && grade <= 79)
                letterGrade = "B";
            else if (grade >= 60 && grade <= 69)
                letterGrade = "C";
            else if (grade >= 50 && grade <= 59)
                letterGrade = "D";
            else if (grade >= 0 && grade <= 49)
                letterGrade = "F";
            else
                letterGrade = "X";

            // If we have an invalid letter grade, let the user know.
            if (letterGrade == "X")
                Console.WriteLine("Invalid score entered.");
            else
                Console.WriteLine($"The letter Grade is:  {letterGrade}");
        }
    }
}
