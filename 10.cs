using System;

class BMICalculator
{
    static void Main()
    {
        double[,] teamData = new double[10, 3]; // 10 members, 3 columns (weight, height, BMI)
        string[] bmiStatus = new string[10]; // Stores BMI status of each person

        // Input data for the team
        InputData(teamData);

        // Calculate BMI for each person
        CalculateBMI(teamData);

        // Determine BMI status for each person
        DetermineBMIStatus(teamData, bmiStatus);

        // Display the results
        DisplayResults(teamData, bmiStatus);
    }

    // Method to input weight and height for each person
    public static void InputData(double[,] teamData)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter details for person " + (i + 1) + ":");
            Console.Write("Weight (kg): ");
            teamData[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height (cm): ");
            teamData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }
    }

    // Method to calculate BMI for each person and populate the BMI column in the array
    public static void CalculateBMI(double[,] teamData)
    {
        for (int i = 0; i < 10; i++)
        {
            teamData[i, 2] = CalculateIndividualBMI(teamData[i, 0], teamData[i, 1]);
        }
    }

    // Helper method to calculate individual BMI
    public static double CalculateIndividualBMI(double weight, double height)
    {
        // Convert height from cm to meters
        double heightInMeters = height / 100;
        // BMI formula: BMI = weight (kg) / (height (m))^2
        return weight / (heightInMeters * heightInMeters);
    }

    // Method to determine BMI status for each person
    public static void DetermineBMIStatus(double[,] teamData, string[] bmiStatus)
    {
        for (int i = 0; i < 10; i++)
        {
            bmiStatus[i] = GetBMIStatus(teamData[i, 2]);
        }
    }

    // Helper method to determine BMI status
    public static string GetBMIStatus(double bmi)
    {
        if (bmi < 18.5)
        {
            return "Underweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            return "Normal";
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            return "Overweight";
        }
        else
        {
            return "Obese";
        }
    }

    // Method to display the results
    public static void DisplayResults(double[,] teamData, string[] bmiStatus)
    {
        Console.WriteLine("\nBMI and Status of each person:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": Weight = " + teamData[i, 0] + " kg, Height = " + teamData[i, 1] + " cm, BMI = " + teamData[i, 2].ToString("0.00") + ", Status = " + bmiStatus[i]);
        }
    }
}
