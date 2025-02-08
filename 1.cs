using System;

// Superclass: Animal
public class Animal
{
    // Attributes
    public string Name;
    public int Age;

    // Constructor to initialize name and age
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to make a generic sound
    public virtual void MakeSound()
    {
        // This is a general sound for any animal
        Console.WriteLine("Animal makes a sound");
    }
}

// Subclass: Dog (inherits from Animal)
public class Dog : Animal
{
    // Constructor for Dog, reusing Animal's constructor
    public Dog(string name, int age) : base(name, age)
    {
    }

    // Overriding the MakeSound method to provide Dog-specific behavior
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Subclass: Cat (inherits from Animal)
public class Cat : Animal
{
    // Constructor for Cat, reusing Animal's constructor
    public Cat(string name, int age) : base(name, age)
    {
    }

    // Overriding the MakeSound method to provide Cat-specific behavior
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Subclass: Bird (inherits from Animal)
public class Bird : Animal
{
    // Constructor for Bird, reusing Animal's constructor
    public Bird(string name, int age) : base(name, age)
    {
    }

    // Overriding the MakeSound method to provide Bird-specific behavior
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

// Main Program to demonstrate polymorphism
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of each animal
        Animal myDog = new Dog("Buddy", 3);
        Animal myCat = new Cat("Whiskers", 2);
        Animal myBird = new Bird("Tweety", 1);

        // Calling MakeSound() on each instance
        myDog.MakeSound();  // Outputs: Dog barks
        myCat.MakeSound();  // Outputs: Cat meows
        myBird.MakeSound(); // Outputs: Bird chirps
    }
}
