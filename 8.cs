using System;

class FriendsUtils
{
    public static int FindYoungest(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }
        return youngestIndex;
    }

    public static int FindTallest(int[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }
        return tallestIndex;
    }
}

class Program8
{
    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        int[] heights = new int[3];

        Console.WriteLine("Enter age and height for Amar, Akbar, and Anthony:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age for " + names[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter height (in cm) for " + names[i] + ": ");
            heights[i] = int.Parse(Console.ReadLine());
        }

        int youngestIndex = FriendsUtils.FindYoungest(ages);
        int tallestIndex = FriendsUtils.FindTallest(heights);

        Console.WriteLine("The youngest is: " + names[youngestIndex] + " (Age: " + ages[youngestIndex] + ")");
        Console.WriteLine("The tallest is: " + names[tallestIndex] + " (Height: " + heights[tallestIndex] + " cm)");
    }
}
