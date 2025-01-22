using System;

class TriangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter the base of the triangle (in cm):");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height of the triangle (in cm):");
        double height = Convert.ToDouble(Console.ReadLine());

        double areaCm = 0.5 * baseLength * height;
        double areaInches = areaCm / 6.4516;

        Console.WriteLine("The area of the triangle is " + areaCm + " square cm and " + areaInches + " square inches.");
    }
}
