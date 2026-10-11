using System;

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

class MainEntry
{
    static void Main()
    {
        Book b = new Book("C# Basics");
        b.Borrow();

        DVD d = new DVD("Inception");
        d.Borrow();
    }
}