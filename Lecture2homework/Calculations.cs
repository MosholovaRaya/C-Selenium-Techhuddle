using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2homework
{
    class Calculations
    {
    public static void Ex1a()
        {
            string number1 = Console.ReadLine();
            int a = int.Parse(number1);

            string number2 = Console.ReadLine();
            int b = int.Parse(number2);

            string number3 = Console.ReadLine();
            int c = int.Parse(number3);

            Console.WriteLine(a+b*c);
        }
     public static void Ex1b()
        {

            string number1 = Console.ReadLine();
            int a = int.Parse(number1);

            string number2 = Console.ReadLine();
            int b = int.Parse(number2);

            string number3 = Console.ReadLine();
            int c = int.Parse(number3);

            Console.WriteLine((a + b) % 7);
        }
        public static void Ex1c()
        {
            string number1 = Console.ReadLine();
            int a = int.Parse(number1);

            string number2 = Console.ReadLine();
            int b = int.Parse(number2);

            string number3 = Console.ReadLine();
            int c = int.Parse(number3);

            string number4 = Console.ReadLine();
            int d = int.Parse(number4);


            Console.WriteLine(a + b * c / 11);
        }
        public static void Ex1d()
        {
            string number1 = Console.ReadLine();
            double a = double.Parse(number1);

            string number2 = Console.ReadLine();
            double b = double.Parse(number2);

            string number3 = Console.ReadLine();
            double c = double.Parse(number3);

            string number4 = Console.ReadLine();
            double d = double.Parse(number4);

            string number5 = Console.ReadLine();
            double e = double.Parse(number5);

            string number6 = Console.ReadLine();
            double f = double.Parse(number6);
          
            Console.WriteLine(a + b / c * d - e % f);
        }
       
        public static void Ex2()
        {
            string number1 = Console.ReadLine();
            int a = int.Parse(number1);

            string number2 = Console.ReadLine();
            int b = int.Parse(number2);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }

        public static void Ex3()
        {
            string number1 = Console.ReadLine();
            double a = double.Parse(number1);

            string number2 = Console.ReadLine();
            double b = double.Parse(number2);

            string number3 = Console.ReadLine();
            double c = double.Parse(number3);

            Console.WriteLine(a * b * c);
    
        }
        public static void Ex4()
        {

        }
    }
}
