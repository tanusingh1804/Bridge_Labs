using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        int[,] marks = new int[numStudents, 3]; // To store marks for Physics, Chemistry, Maths
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nEnter marks for Student " + (i + 1) + ":");

            for (int j = 0; j < 3; j++)
            {
                string subject = j == 0 ? "Physics" : (j == 1 ? "Chemistry" : "Maths");
                while (true)
                {
                    Console.Write(subject + ": ");
                    if (int.TryParse(Console.ReadLine(), out marks[i, j]) && marks[i, j] >= 0)
                        break;
                    Console.WriteLine("Invalid input. Marks must be a non-negative number.");
                }
            }

            // Calculate percentage
            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            // Determine grade
            if (percentages[i] >= 80)
                grades[i] = 'A';
            else if (percentages[i] >= 70)
                grades[i] = 'B';
            else if (percentages[i] >= 60)
                grades[i] = 'C';
            else if (percentages[i] >= 50)
                grades[i] = 'D';
            else if (percentages[i] >= 40)
                grades[i] = 'E';
            else
                grades[i] = 'R';
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        Console.WriteLine("-------------------------------------------------------------");

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine((i + 1) + "\t" + marks[i, 0] + "\t" + marks[i, 1] + "\t\t" + marks[i, 2] + "\t" +
                              percentages[i].ToString("0.00") + "\t\t" + grades[i]);
        }
    }
}
