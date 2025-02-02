using System;

class Program
{
    static void Main()
    {
        Book myBook = new Book("The Alchemist", "Paulo Coelho", 20.99);
        Console.WriteLine("Book Available: " + myBook.IsAvailable);

        myBook.BorrowBook();
        Console.WriteLine("Book Available: " + myBook.IsAvailable);
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    private bool isAvailable;

    public bool IsAvailable
    {
        get { return isAvailable; }
        private set { isAvailable = value; }
    }

    public Book()
    {
        isAvailable = true;
    }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
        isAvailable = true;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book is already borrowed.");
        }
    }
}
