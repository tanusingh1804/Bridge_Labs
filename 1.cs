using System;

class Program1
{
    public static void Main()
    {
        int[] ages = new int[10];

        Console.WriteLine("Enter the ages of 10 students:");
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
            {
                Console.WriteLine("Invalid age: " + ages[i]);
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine("The student with age " + ages[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("The student with age " + ages[i] + " cannot vote.");
            }
        }
    }
}
