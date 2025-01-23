using System;

 class Program
{
   static void Main(string[] args)
    {
        Console.WriteLine("Enter the countdown value:");
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }

        Console.WriteLine("Launch!");
    }
}