using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.Write("Input month here: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Input year here: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(DateTime.DaysInMonth(year, month));
        }
        public static void Ex3()
        {
            DateTime now = DateTime.Now;

            // like this it shows the current time in a more simple format: Console.WriteLine(now.ToString("F"));

            Console.WriteLine("year= {0}", now.Year);
            Console.WriteLine("month= {0}", now.Month);
            Console.WriteLine("day= {0}", now.Day);
            Console.WriteLine("hour= {0}", now.Hour);
            Console.WriteLine("minute= {0}", now.Minute);
            Console.WriteLine("cecond= {0}", now.Second);
            Console.WriteLine("millisecond= {0}", now.Millisecond);
        }
        public static void Ex4()
        {
            Console.WriteLine("Input day here (d/M/yyyy): ");

            DateTime input = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine($"The day of the week for {input:d/M/yyyy} is {input.DayOfWeek}");

            //represents the current day of the week: DayOfWeek weekDay = DateTime.Today.DayOfWeek;

            //Console.WriteLine(weekDay);

        }
        public static void Ex5()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Today = " + now.ToString("F"));

            DateTime afterFourtyDays = DateTime.Now.AddDays(40);
            Console.WriteLine(afterFourtyDays.DayOfWeek);

        }
        public static void Ex6()
        {
            DateTime timeUTC = DateTime.FromFileTimeUtc(DateTime.Now.ToFileTime());

            Console.WriteLine(timeUTC);

        }
        public static void extraEX()
        {
            Console.WriteLine("Input first date here (d/M/yyyy): ");
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Input second date here (d/M/yyyy): ");
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                Console.WriteLine($"{date1:d/M/yyyy} is earlier than {date2:d/M/yyyy}");
            }
            else if (result == 0)
            {
                Console.WriteLine($"{date1:d/M/yyyy} is the same as {date2:d/M/yyyy}");
            }
            else
            {
                Console.WriteLine($"{date1:d/M/yyyy} is later than {date2:d/M/yyyy}");
            }
        }

    }
      
}

