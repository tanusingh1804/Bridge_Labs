using System;

public interface Worker
{
    void PerformDuties();
}

public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

public class Chef : Person, Worker
{
    public Chef(string name, int id) : base(name, id) { }

    public void PerformDuties()
    {
        Console.WriteLine("Cooking food");
    }
}

public class Waiter : Person, Worker
{
    public Waiter(string name, int id) : base(name, id) { }

    public void PerformDuties()
    {
        Console.WriteLine("Serving food");
    }
}

public class Program
{
    public static void Main()
    {
        Chef chef = new Chef("John", 1);
        chef.PerformDuties();
    }
}
