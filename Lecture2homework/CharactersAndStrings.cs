using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2homework
{
    class CharactersAndStrings
    {
        public static void Ex1()
        {
            Console.Write("Input original string here: ");
            string s = Console.ReadLine();

            if (s.Length <= 1)
            {
                Console.WriteLine("Minimum string lenght of 2 is required.");
            }
            else
            {
                string firstChar = s[0].ToString();
                string lastChar = s[^1].ToString();
                string mid = s[1..^1];

                Console.WriteLine(lastChar + mid + firstChar);
            }
        }
        public static void Ex2()
        {
            string s = Console.ReadLine();

            if (s.Length < 1)
            {
                Console.WriteLine("Min string lenght of 1 is required.");
                return;
            }
            
            string firstLetter = s[0].ToString();       
           
            s = s.Insert(0, firstLetter);
            s = s.Insert(s.Length, firstLetter);

            Console.WriteLine(s);                 
        }

        public static void Ex3()
        {
            char[] chars = Console.ReadLine().ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(chars);
        }
    }
}
