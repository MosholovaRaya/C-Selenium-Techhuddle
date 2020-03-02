using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2homework
{
    class Conditions
    {
        public static void Ex1()
        {
          int number1 = int.Parse(Console.ReadLine());
          int number2 = int.Parse(Console.ReadLine());

            if (number1 > 0 && number2 < 0 || number1 < 0 && number2 > 0)
            {
                Console.WriteLine("Check if one is negative and one is positive: True");
            }
      
        else
            {
                Console.WriteLine("Check if one is negative and one is positive: False");
            }

  
        }
            
        public static void Ex2()
        {
          



        }
    }
}
