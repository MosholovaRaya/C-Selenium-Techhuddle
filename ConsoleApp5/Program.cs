using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int a = int.Parse(number);

            if (a % 2 == 0)
            {
                Console.WriteLine("True");
}
            else
            {
                Console.WriteLine("False");
           }
          
        }
    }
}
