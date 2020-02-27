using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan";
            string lastName = "Petkov";
            string city = "Sofia";
            string street = "Bul. Bulgaria";
            string house = "N5";

            Console.WriteLine("Name: {0} {1}, Address: {2}, {3} {4}", firstName, lastName, city, street, house);
            Console.WriteLine($"Name: {firstName} {lastName}, Address: {city}, {street} {house}");

            string firstName1 = "Ivan";
            string lastName1 = "Petkov";
            int age = 20;
            string university = "Sofia University";

            Console.WriteLine("Name: {0} {1}, Age: {2}", firstName1, lastName1, age);
            Console.WriteLine("Univerity: {0}", university);
            Console.WriteLine($"Name: {firstName1} {lastName1}, Age: {age}\nUniversity: {university}");


        }
    }
}
