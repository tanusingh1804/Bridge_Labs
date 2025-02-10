using System;
using System.Collections.Generic;

// Abstract Class
public abstract class LibraryItem
{
    public int ItemId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public abstract int GetLoanDuration();
}

// Subclasses
public class Book : LibraryItem
{
    public override int GetLoanDuration()
    {
        return 14;  // 2 weeks
    }
}

public class Magazine : LibraryItem
{
    public override int GetLoanDuration()
    {
        return 7;  // 1 week
    }
}

// Interface
public interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Main Program
public class Program
{
    public static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book { ItemId = 1, Title = "C# Basics", Author = "John Doe" },
            new Magazine { ItemId = 2, Title = "Tech News", Author = "Jane Smith" }
        };

        foreach (var item in items)
        {
            Console.WriteLine("Item: " + item.Title + ", Loan Duration: " + item.GetLoanDuration() + " days");
        }
    }
}
