using System;
using System.Collections.Generic;

namespace Lecture5homeworkLibrary
{
    class Program
    {
        // I've used help for that one as I cannot do it myself.
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>();

            string command;

            do
            {
                command = Console.ReadLine().Trim();

                if (command.ToLower().StartsWith("add "))
                {
                    string arguments = command.Substring(4);
                    int separator = arguments.LastIndexOf(' ');
                    string title = arguments.Substring(0, separator);
                    int pages = int.Parse(arguments.Substring(separator + 1));
                    Book book = new Book(title, pages);
                    library.Add(book);
                }
                else if (command.ToLower().StartsWith("remove "))
                {
                    string title = command.Substring(7);
                    library.RemoveAll(book => book.Title == title);
                }
                else if (command.ToLower().StartsWith("rent "))
                {
                    string title = command.Substring(5);
                    Book book = library.Find(book => book.Title == title);
                    book.Available = false;
                }
                else if (command.ToLower().StartsWith("return "))
                {
                    string title = command.Substring(7);
                    Book book = library.Find(book => book.Title == title);
                    book.Available = true;
                }
                else if (command.ToLower() == "display all")
                {
                    foreach (var book in library)
                    {
                        Console.WriteLine(book);
                    }
                }
                else if (command.ToLower() == "display available")
                {
                    foreach (var book in library.FindAll(book => book.Available))
                    {
                        Console.WriteLine(book);
                    }
                }
                else if (command.ToLower() == "display unavailable")
                {
                    foreach (var book in library.FindAll(book => !book.Available))
                    {
                        Console.WriteLine(book);
                    }
                }
            } while (command.ToLower() != "end");

            library.Sort((book1, book2) => book2.Available.CompareTo(book1.Available));
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }

    public class Book
    {
        public string Title;
        public int Pages;
        public bool Available;

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Available = true;
        }

        public override string ToString()
        {
            return $"'{Title}' ({Pages} pages) - Available: {Available}";
        }
    }
}
