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
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(($"Abs({2 * (number1 - number2)}) = {Math.Abs(2 * (number1 - number2))}"));
               
            }

            else
            {
                Console.WriteLine(($"Abs({number1 - number2}) = {Math.Abs(number1 - number2)}"));
            }

        }

        public static void Ex3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

           
            Console.WriteLine(a == 20 || a + b == 20);
            
                  
        }
        public static void Ex4()
        {
            int a = int.Parse(Console.ReadLine());
                   
            Console.WriteLine((80 <= a && a <= 120) || (180 <= a && a <= 220));
          
         }

        public static void Ex5()
        {
            Console.Write("Input first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input operation: ");
            string operation = Console.ReadLine();

            Console.Write("Input second number: ");
            int b = int.Parse(Console.ReadLine());

            if (operation == "+")
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
           
            else if (operation == "-")
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }

            else if (operation == "*")
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }

            else if (operation == "/")
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
        }

        public static void Ex6()
        {
            Console.Write("Input any day from the week as number from 1 to 7: ");
            int day = int.Parse(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("The selected day is: Monday");
            }

            else if (day == 2)
            {
                Console.WriteLine("The selected day is: Tuesday");
            }

            else if (day == 3)
            {
                Console.WriteLine("The selected day is: Wednesday");

            }

            else if (day == 4)
            {
                Console.WriteLine("The selected day is: Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("The selected day is: Friday");
            }

            else if (day == 6)
            {
                Console.WriteLine("The selected day is: Saturday");
            }

            else if (day == 7)
            {
                Console.WriteLine("The selected day is: Sunday");
            }

            else
            {
                Console.WriteLine("Error: please input only integer from 1 to 7!");
            }
        }
    }
}
