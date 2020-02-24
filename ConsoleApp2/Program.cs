using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            int a = int.Parse(number1);

            string number2 = Console.ReadLine();
            int b = int.Parse(number2);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
        }
    }
}
