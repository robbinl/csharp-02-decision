using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_2018F_IC_case_SalesTax
{
    /*
   * Purpose: Determine the price of an item after tax in any province.
   * 
   * Input: 
   *    - Item Price
   *    - Name of Province
   * 
   * Process: Get input from user.
   *          Use switch to determine appropriate tax rate.
   *          Calculate Sales Tax and Final Price
   *
   * Output: Display Item Price
   *         Display Sales Tax
   *         Display Final Price
   *         
   * Written By: Robbin Law
   * Date Modified: 2019.09.19
   * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Sale Total (before tax): ");
            double beforeTax = double.Parse(Console.ReadLine());
            Console.Write("Enter your province: ");
            string provinceStr = Console.ReadLine();

            double taxRate;
            switch (provinceStr.ToLower())
            {
                case "british columbia":
                case "bc":
                    taxRate = 0.12;
                    break;

                case "saskatchewan":
                case "sk":
                    taxRate = 0.11;
                    break;

                case "manitoba":
                case "mb":
                case "ontario":
                case "on":
                    taxRate = 0.13;
                    break;

                case "quebec":
                case "qc":
                    taxRate = 0.14975;
                    break;

                case "newfoundland and labrador":
                case "newfoundland":
                case "nl":
                case "new brunswick":
                case "nb":
                case "nova scotia":
                case "ns":
                case "prince edward island":
                case "pe":
                    taxRate = 0.15;
                    break;

                case "alberta":
                case "ab":
                case "yukon":
                case "yt":
                case "northwest territories":
                case "nt":
                case "nunavut":
                case "nu":
                    taxRate = 0.05;
                    break;

                default:
                    taxRate = -1;
                    break;
            }

            double salesTax;
            double finalPrice;

            if (taxRate < 0) // Check for invalid Input
            {
                Console.WriteLine("Invalid Input.");
            }
            else
            {
                salesTax = beforeTax * taxRate;
                finalPrice = beforeTax + salesTax;

                Console.WriteLine($"Item Price: {beforeTax:C}");
                Console.WriteLine($"Sales Tax: {salesTax:C}");
                Console.WriteLine($"Price for item in {provinceStr}: {finalPrice:C}");
            }
        }
    }
}
