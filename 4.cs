using System;

// Superclass: Book
public class Book
{
    // Attributes of the Book
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    // Constructor to initialize Book attributes
    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    // Method to display Book information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

// Subclass: Author, which inherits from Book
public class Author : Book
{
    // Additional attributes for Author
    public string Name { get; set; }
    public string Bio { get; set; }

    // Constructor to initialize Book and Author attributes
    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear) // Calling the base class constructor
    {
        Name = name;
        Bio = bio;
    }

    // Overriding the DisplayInfo method to include Author details
    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Display Book details
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Author Bio: " + Bio);
    }
}

// Main class to test the implementation
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Author with Book details
        Author author = new Author("The Great Adventure", 2020, "John Doe", "John is a renowned author of adventure novels.");

        // Displaying information about the Book and Author
        author.DisplayInfo();
    }
}
