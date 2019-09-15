using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Seasons
{
    class Seasons
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the name of a season.
            Console.WriteLine("Enter the name of a season: ");
            string season = Console.ReadLine().ToLower();

            string spanish = "";

            switch (season)
            {
                case "spring":
                    spanish = "La Primavera";
                    break;
                case "summer":
                    spanish = "El Verano";
                    break;

                case "autumn":
                case "fall":
                    spanish = "El Otoño";
                    break;

                case "winter":
                    spanish = "El Invierno";
                    break;

                default:
                    spanish = "Incorrect Input";
                    break;
            }
            Console.WriteLine(spanish);
        }
    }
}
