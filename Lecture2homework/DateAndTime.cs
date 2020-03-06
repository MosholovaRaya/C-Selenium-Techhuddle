using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2homework
{
    class DateAndTime
    {
        public static void Ex1()
        {
       
            int year = int.Parse(Console.ReadLine());
            
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        public static void Ex2()
        {

        }
    }
}

