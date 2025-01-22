using System;

class HeightConverter
{
    static void Main()
    {
        Console.WriteLine("Enter your height in centimeters:");
        double cm = Convert.ToDouble(Console.ReadLine());
        double totalInches = cm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;
        Console.WriteLine("Your height in cm is " + cm + ", in feet is " + feet + ", and in inches is " + inches);
    }
}
