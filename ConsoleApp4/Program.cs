using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string radius = Console.ReadLine();
            int a = int.Parse(radius);
      
            Console.WriteLine(Math.PI * a * a);

        }
    }
}
