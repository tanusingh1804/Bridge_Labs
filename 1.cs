using System;

class Program
{
    static void Main()
    {
        Book myBook = new Book("C Sharp Programming", "John Doe", 39.99);
        Console.WriteLine("Title: " + myBook.Title + ", Author: " + myBook.Author + ", Price: " + myBook.Price);
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
    }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
}
