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

    public void DisplayDetails()
    {
        Console.WriteLine("Book Title " + Title);
        Console.WriteLine("Author " + Author);
        Console.WriteLine("Price " + Price);
    }

    static void Main()
    {
        Book book = new Book("The Alchemist", "Paulo Coelho", 299);
        book.DisplayDetails();
    }
}
