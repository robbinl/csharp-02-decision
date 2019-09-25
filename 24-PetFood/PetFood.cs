using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PetFood
{
    class PetFood
    {
        static void Main(string[] args)
        {
            // Prompt the user for a grade of pet food.
            Console.WriteLine("Our pet food is available in three grades.");
            Console.WriteLine("A, B, and C. Which do you want pricing for? ");
            //char foodGrade = char.Parse(Console.Read());

            string foodGrade = Console.ReadLine().ToUpper();
            Console.WriteLine("Please enter a char");
            char foodGradeChar = char.Parse(Console.ReadLine());

            switch (foodGradeChar)
            {
                case 'A':
                    Console.WriteLine(foodGradeChar);
                    break;
                default:
                    Console.WriteLine("Hey");
                    break;
            }

            switch (foodGrade)
            {
                
                case "A":
                    Console.WriteLine("30c per lb.");
                    break;

                
                case "B":
                    Console.WriteLine("20c per lb.");
                    break;
                
                case "C":
                    Console.WriteLine("15c per lb.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}
