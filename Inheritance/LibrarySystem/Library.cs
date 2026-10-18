using System;

namespace DotNetTutorials.Inheritance
{
    class LibraryItem
    {
        public string Title;

        public LibraryItem(string title)
        {
            Title = title;
        }

        public void Borrow() 
        {
            Console.WriteLine("Borrowed " + Title);
        }
    }

    class Book : LibraryItem
    {
        public Book(string title) : base(title) { }
    }

    class DVD : LibraryItem
    {
        public DVD(string title) : base(title) { }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Book b = new Book("C# Basics");
            b.Borrow();

            DVD d = new DVD("Inception");
            d.Borrow();
        }
    }
}