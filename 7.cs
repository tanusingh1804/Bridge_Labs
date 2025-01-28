using System;

public class StudentVoteChecker
{
    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            Console.WriteLine("Invalid age: " + age);
            return false;
        }
        return age >= 18;
    }
}

class Program7
{
    static void Main()
    {
        StudentVoteChecker checker = new StudentVoteChecker();
        int[] ages = new int[10];

        Console.WriteLine("Enter the ages of 10 students:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter age for student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            bool canVote = checker.CanStudentVote(ages[i]);
            Console.WriteLine("Student " + (i + 1) + " (Age: " + ages[i] + ") - Can Vote: " + (canVote ? "Yes" : "No"));
        }
    }
}
