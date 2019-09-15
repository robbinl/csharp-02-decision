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

            char foodGrade = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (foodGrade)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("30c per lb.");
                    break;

                case 'b':
                case 'B':
                    Console.WriteLine("20c per lb.");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("15c per lb.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}
