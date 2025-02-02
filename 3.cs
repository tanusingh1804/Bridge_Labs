using System;

class Program
{
    static void Main()
    {
        Person person1 = new Person("Alice", 25);
        Person person2 = new Person(person1);

        Console.WriteLine("Original Person: " + person1.Name + ", Age: " + person1.Age);
        Console.WriteLine("Copied Person: " + person2.Name + ", Age: " + person2.Age);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }
}
