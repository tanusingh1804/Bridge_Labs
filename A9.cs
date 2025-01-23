class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Enter the countdown value:");
        int countdown = int.Parse(Console.ReadLine());

        for (int i = countdown; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Launch!");
    }
}