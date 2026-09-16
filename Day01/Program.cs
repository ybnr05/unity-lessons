using System;

class Book
{
    public string Title;
    public string Author;
    public double Price;

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayBook()
    {
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price : $" + Price);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("Harry Potter", "J.K. Rowling", 45.99);
        Book book2 = new Book("Rich Dad Poor Dad", "Robert Kiyosaki", 49.99);
        Book book3 = new Book("The subtle Art of Not Giving a Fc*k", "Mark Manson", 39.99);

        Console.WriteLine("=====================");
        Console.WriteLine("BOOK DETAILS");
        Console.WriteLine("=====================");

        book1.DisplayBook();
        book2.DisplayBook();
        book3.DisplayBook();
    }
}