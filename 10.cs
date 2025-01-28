using System;

class ChocolateDistribution
{
    public static int[] DistributeChocolates(int chocolates, int children)
    {
        int eachChildGets = chocolates / children;
        int remainingChocolates = chocolates % children;
        return new int[] { eachChildGets, remainingChocolates };
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());

        int[] result = DistributeChocolates(chocolates, children);

        Console.WriteLine("Each child gets: " + result[0] + ", Remaining chocolates: " + result[1] + ".");
    }
}
}