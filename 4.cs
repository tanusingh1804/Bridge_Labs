using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] arr = null; // Change to new int[]{1,2,3} for valid case

            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value at index {0}: {1}", index, arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}
