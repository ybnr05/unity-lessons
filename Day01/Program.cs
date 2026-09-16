using System;

class Book
{
    public string Title;
    public string Author;
    public double Price;
}

class Program
{
    static void Main()
    {
        Book book1 = new Book();
        book1.Title = "Clean Code";
        book1.Author = "Robert Martin";
        book1.Price = 45.99;

        Book book2 = new Book();
        book2.Title = "The Pragmatic Programmer";
        book2.Author = "Andrew Hunt";
        book2.Price = 49.99;

        Book book3 = new Book();
        book3.Title = "Head First C#";
        book3.Author = "Andrew Stellman";
        book3.Price = 39.99;

        Console.WriteLine("=====================");
        Console.WriteLine("BOOK DETAILS");
        Console.WriteLine("=====================");

        Console.WriteLine("Title : " + book1.Title);
        Console.WriteLine("Author: " + book1.Author);
        Console.WriteLine("Price : $" + book1.Price);

        Console.WriteLine();

        Console.WriteLine("Title : " + book2.Title);
        Console.WriteLine("Author: " + book2.Author);
        Console.WriteLine("Price : $" + book2.Price);

        Console.WriteLine();

        Console.WriteLine("Title : " + book3.Title);
        Console.WriteLine("Author: " + book3.Author);
        Console.WriteLine("Price : $" + book3.Price);
    }
}