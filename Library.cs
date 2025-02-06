//using System;
//using System.Collections.Generic;


//class Book
//{
//    public string Title { get; }
//    public string Author { get; }

//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }

   
//    public void Display()
//    {
//        Console.WriteLine($"Title: {Title}, Author: {Author}");
//    }
//}

//class Library
//{
//    public string Name { get; }
//    private List<Book> books; 

//    public Library(string name)
//    {
//        Name = name;
//        books = new List<Book>();
//    }

 
//    public void AddBook(Book book)
//    {
//        books.Add(book);
//    }

    
//    public void DisplayBooks()
//    {
//        Console.WriteLine($"\nLibrary: {Name}");
//        if (books.Count == 0)
//        {
//            Console.WriteLine("No books available.");
//            return;
//        }

//        foreach (var book in books)
//        {
//            book.Display();
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
        
//        Library DepartmentLibrary = new Library("Department Library");
//        Library MainLibrary = new Library("Main Library");

//        List<Book> books = new List<Book>();

//        Console.Write("No. of books? ");
//        if (!int.TryParse(Console.ReadLine(), out int bookCount) || bookCount <= 0)
//        {
//            Console.WriteLine("Invalid input!.");
//            return;
//        }

        
//        for (int i = 0; i < bookCount; i++)
//        {
//            Console.WriteLine($"\nBook {i + 1}:");
//            Console.Write("Title: ");
//            string title = Console.ReadLine();
//            Console.Write("Author: ");
//            string author = Console.ReadLine();

//            books.Add(new Book(title, author));
//        }

//        foreach (var book in books)
//        {
//            Console.WriteLine($"\nBook: {book.Title}");
//            Console.WriteLine("Add in library?");
//            Console.WriteLine("1. Department Library");
//            Console.WriteLine("2.Main Library");
//            Console.Write("Enter choice (1/2): ");

//            if (!int.TryParse(Console.ReadLine(), out int choice) || (choice != 1 && choice != 2))
//            {
//                Console.WriteLine("Invalid choice!");
//                continue;
//            }

//            if (choice == 1)
//                DepartmentLibrary.AddBook(book);
//            else
//                MainLibrary.AddBook(book);
//        }

     
//        DepartmentLibrary.DisplayBooks();
//        MainLibrary.DisplayBooks();
//    }
//}
