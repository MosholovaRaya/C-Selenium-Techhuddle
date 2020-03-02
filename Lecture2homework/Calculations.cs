using System;

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

            Console.WriteLine(a + b * c);
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
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());

            Console.WriteLine((number1 + number2 + number3 + number4) / 4);

        }
        public static void Ex5()
        {
            double celsius = double.Parse(Console.ReadLine());

            double kelvin = celsius + 273.15;
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Kelvin= " + kelvin);
            Console.WriteLine("Fahrenheit= " + fahrenheit);

        }
        public static void Ex6()
        {
            int a = int.Parse(Console.ReadLine());

            bool multipleOf3 = a % 3 == 0;
            bool multipleOf7 = a % 7 == 0;

            Console.WriteLine(multipleOf3 || multipleOf7);
        }
        public static void Ex7()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            bool lessThan100 = number1 < 100;
            bool greaterThan200 = number2 > 200;

            Console.WriteLine(lessThan100 && greaterThan200);
        }
        public static void Ex8()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(number1, Math.Max(number2, number3)));
            Console.WriteLine("Lowest of three: " + Math.Min(number1, Math.Min(number2, number3)));

        }
        public static void Ex9()
        {
            int number1 = int.Parse(Console.ReadLine());

            int a = (int)(number1 / 100) + 1;

            Console.WriteLine("Current century is: " + a);

        }
        public static void Ex10()
        {
            double radius = double.Parse(Console.ReadLine());

            double surfaceOfsphere = 4 * Math.PI * radius * radius;
            double volumeOfsphere = 4 * Math.PI * radius * radius * radius / 3;

            Console.WriteLine(surfaceOfsphere);
            Console.WriteLine(volumeOfsphere);

        }
        public static void Ex11()
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies in the First Quadrant");
            }

           else if (X < 0 && Y > 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Second Quadrant");
            }

          else  if (X < 0 && Y < 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Third Quadrant");
            }
          
           else if (X > 0 && Y < 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Fourth Quadrant");
            }
          else  if (X == 0 && Y == 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies in the origin point");
            }
         else   if (X > 0 && Y == 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies between First and Fourth Quadrant");
            }

         else if (X < 0 && Y==0 )
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies between Second and Third Quadrant");
            }
         
          else if (X == 0 && Y < 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies between Third and Fourth Quadrant");
            }
          else if (X == 0 && Y > 0)
            {
                Console.WriteLine($"The coordinate point ({X},{Y}) lies between First and Second Quadrant");
            }

        }



    }
}
