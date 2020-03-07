using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2homework
{
    class SchoolGrades
    {
        public static void sG()
        {
            Console.Write("Input the grade: ");
            string input = Console.ReadLine().ToUpper();

            if (input == "E")
            {
                Console.WriteLine("You have chosen: Excellent");
            }
            else if (input == "V")
            {
                Console.WriteLine("You have chosen: Very Good");
            }
            else if (input == "G")
            {
                Console.WriteLine("You have chosen: Good");
            }
            else if (input == "A")
            {
                Console.WriteLine("You have chosen: Average");
            }
            else if (input == "F")
            {
                Console.WriteLine("You have chosen: Fail");
            }
            else
            {
                Console.WriteLine("Invalid input! Please select a grade from the following: E, V, G, A or F");
            }


            //switch (input)
            //{
            //    case "E":
            //    case "e":
            //        Console.WriteLine("You have chosen: Excellent");
            //        break;
            //    case "V":
            //        Console.WriteLine("You have chosen: Very Good");
            //        break;
            //    case "G":
            //        Console.WriteLine("You have chosen: Good");
            //        break;
            //    case "A":
            //        Console.WriteLine("You have chosen: Average");
            //        break;
            //    case "F":
            //        Console.WriteLine("You have chosen: Fail");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid input! Please select a grade from the following: E, V, G, A or F");
            //        break;
            //}
        }
    }
}
