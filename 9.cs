using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose operation (+, -, *, /):");
        char op = Console.ReadLine()[0];

        double result = 0;
        if (op == '+')
            result = num1 + num2;
        else if (op == '-')
            result = num1 - num2;
        else if (op == '*')
            result = num1 * num2;
        else if (op == '/')
            result = num1 / num2;
        else
            Console.WriteLine("Invalid operator.");

        Console.WriteLine("Result: " + result);
    }
}
