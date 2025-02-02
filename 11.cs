using System;

class Program
{
    static void Main()
    {
        Book book = new Book("123-456-789", "C# Programming", "John Doe");
        book.SetAuthor("Jane Doe");

        Console.WriteLine("ISBN: " + book.ISBN);
        Console.WriteLine("Title: " + book.GetTitle());
        Console.WriteLine("Author: " + book.GetAuthor());

        EBook ebook = new EBook("987-654-321", "Advanced C#", "Mike Ross", "PDF");
        ebook.DisplayEBookDetails();
    }
}

class Book
{
    public string ISBN;
    protected string Title;
    private string Author;

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public string GetTitle()
    {
        return Title;
    }
}

class EBook : Book
{
    private string Format;

    public EBook(string isbn, string title, string author, string format) : base(isbn, title, author)
    {
        Format = format;
    }

    public void DisplayEBookDetails()
    {
        Console.WriteLine("EBook - ISBN: " + ISBN + ", Title: " + Title + ", Format: " + Format);
    }
}
