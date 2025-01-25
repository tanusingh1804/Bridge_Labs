using System;

class Program
{
    public static void Main()
    {
        
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine("Table for " + i + ":");
            
           
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
            }
            Console.WriteLine(); 
        }
    }
}
