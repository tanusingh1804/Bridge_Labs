using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the employee's salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter the employee's years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

        double bonus = 0;

        if (yearsOfService > 5)
        {
            bonus = salary * 0.05; // 5% bonus
        }

        Console.WriteLine("Bonus amount: " + bonus);
    }
}