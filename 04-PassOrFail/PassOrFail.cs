using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PassOrFail
{
    class PassOrFail
    {
        static void Main(string[] args)
        {
            /* Prompt for and read in the user's CPSC1012 percentage for
             *  1) In-Class Exercises (30% weight)
             *  2) Quiz               (20% weight)
             *  3) Core Portfolio     (25% weight)
             *  4) Advanced Portfolio (25% weight)
             *  
             *  Display a message indicating if the student has passed cpsc1012.
             */


            const double exerciseWeight = 30;
            const double quizWeight = 20;
            const double coreWeight = 25;
            const double advancedWeight = 25;

            Console.Write("Enter in users's In-Class Exercise score in %: ");
            double exerciseScore = double.Parse(Console.ReadLine());
            double exWeightVal = exerciseWeight * (exerciseScore / 100);

            Console.Write("Enter in users's Quiz score in %: ");
            double quizScore = double.Parse(Console.ReadLine());
            double quizWeightVal = quizWeight * (quizScore / 100);

            Console.Write("Enter in users's Core Portfolio score in %: ");
            double coreScore = double.Parse(Console.ReadLine());
            double coreWeightVal = coreWeight * (coreScore / 100);

            Console.Write("Enter in users's Advanced Core Portfolio score in %: ");
            double advancedScore = double.Parse(Console.ReadLine());
            double advWeightVal = advancedWeight * (advancedScore / 100);

            double weightTotal = exWeightVal + quizWeightVal + coreWeightVal + advWeightVal;

            if (weightTotal >= 50 && (exerciseScore >= 50) && (quizScore >= 50) && (coreScore >= 50))
            {
                Console.WriteLine("Student has passed!");
            }
            else
            {
                Console.WriteLine("Student FAIL.");
            }
        }
    }
}
