using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.Write("Enter divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result: " + (arr[index] / divisor));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}
