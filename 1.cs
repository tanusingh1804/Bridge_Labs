using System;

class Program1
{
    static void Main()
    {
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        Console.WriteLine("Enter details for 10 employees:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nEmployee {0}:", i + 1);

            // Taking salary input
            while (true)
            {
                Console.Write("Enter salary: ");
                if (double.TryParse(Console.ReadLine(), out salaries[i]) && salaries[i] > 0)
                    break;
                Console.WriteLine("Invalid salary. Please enter a positive number.");
            }

            // Taking years of service input
            while (true)
            {
                Console.Write("Enter years of service: ");
                if (double.TryParse(Console.ReadLine(), out yearsOfService[i]) && yearsOfService[i] >= 0)
                    break;
                Console.WriteLine("Invalid years of service. Please enter a non-negative number.");
            }
        }

        // Calculating bonuses and new salaries
        for (int i = 0; i < 10; i++)
        {
            double bonusRate = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusRate;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        // Display results
        Console.WriteLine("\nSummary:");
        Console.WriteLine("Total Bonus Payout: {0}", totalBonus);
        Console.WriteLine("Total Old Salary: {0}", totalOldSalary);
        Console.WriteLine("Total New Salary: {0}", totalNewSalary);
    }
}
