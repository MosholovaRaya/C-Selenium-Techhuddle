using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture4homework
{
    class Arrays
    {
        public static void Ex1()
        {
            Console.Write("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());
         
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i+1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            foreach (var item in numbers)
            {
                sum = sum + item;
            }
            Console.WriteLine("The sum of the elements in the array is: " +sum);
        }
        public static void Ex2()
        {
            Console.Write("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            List<int> duplicates = new List<int>();

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i]==numbers[j] && !duplicates.Contains(numbers[i]))
                    {
                        duplicates.Add(numbers[i]);
                    }
                }
            }
            Console.WriteLine("The number of duplicate elements in the array is: " +duplicates.Count);  
        }
        public static void Ex3()
        {
            Console.Write("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            List<int> uniques = new List<int>();

            foreach (var item in numbers)
            {
                if(!uniques.Contains(item))
                {
                    uniques.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ", uniques));
        }
        public static void Ex4()
        {

            Console.Write("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            foreach (var item in numbers)
            {
                if(item<minValue)
                {
                    minValue = item;
                }
                if (item>maxValue)
                {
                    maxValue = item;
                }
            }
            Console.WriteLine("The minimum element in the array is: " + minValue);
            Console.WriteLine("The maximum elemrnt in the array is: " + maxValue);
        }
        public static void Ex5()
        {
            Console.Write("Enter numbers if elements in the array: ");
            int n = int.Parse(Console.ReadLine());


            string[] sentence = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                sentence[i] = Console.ReadLine();
            }

            sentence[^1] = "Raya";

            Console.WriteLine(string.Join(" ", sentence));
        }
        public static void Ex6()
        {

        }

    }
}
