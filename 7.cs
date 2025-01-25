using System;

class Program6
{
    static void Main()
    {
        // Ask for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Create a 2D array to store height, weight, and BMI
        double[,] personData = new double[numPersons, 3];
        // Create an array to store weight status
        string[] weightStatus = new string[numPersons];

        // Loop through each person to get their details
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ":");

            // Get height (ensure it's a positive number)
            while (true)
            {
                Console.Write("Enter height in meters: ");
                if (double.TryParse(Console.ReadLine(), out personData[i, 0]) && personData[i, 0] > 0)
                    break;
                Console.WriteLine("Invalid input. Height must be a positive number.");
            }

            // Get weight (ensure it's a positive number)
            while (true)
            {
                Console.Write("Enter weight in kilograms: ");
                if (double.TryParse(Console.ReadLine(), out personData[i, 1]) && personData[i, 1] > 0)
                    break;
                Console.WriteLine("Invalid input. Weight must be a positive number.");
            }

            // Calculate BMI and store in the 2D array
            personData[i, 2] = personData[i, 1] / (personData[i, 0] * personData[i, 0]);

            // Determine the weight status based on BMI
            if (personData[i, 2] <= 18.4)
                weightStatus[i] = "Underweight";
            else if (personData[i, 2] <= 24.9)
                weightStatus[i] = "Normal";
            else if (personData[i, 2] <= 39.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        // Print the results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Height (m)\tWeight (kg)\tBMI\t\tStatus");
        Console.WriteLine("--------------------------------------------------");

        // Display the height, weight, BMI, and weight status of each person
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine(personData[i, 0].ToString("0.00") + "\t\t" + personData[i, 1].ToString("0.0") + "\t\t" +
                              personData[i, 2].ToString("0.0") + "\t\t" + weightStatus[i]);
        }
    }
}
