using System;

class ChocolateDistribution
{
    static void Main()
    {
        Console.Write("Enter numberOfChocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter numberOfChildren: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + " and the number of remaining chocolates is " + remainingChocolates);
    }
}
