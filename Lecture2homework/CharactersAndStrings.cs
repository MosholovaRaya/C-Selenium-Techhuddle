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
    }
}
