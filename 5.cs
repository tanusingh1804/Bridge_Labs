using System;

class Program5
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int maxDigits = 10;
        int[] digits = new int[maxDigits];
        int index = 0;

        while (number != 0)
        {
            if (index == maxDigits)
            {
                maxDigits += 10;
                int[] temp = new int[maxDigits];
                Array.Copy(digits, temp, digits.Length);
                digits = temp;
            }

            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = 0, secondLargest = 0;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest Digit: {0}", largest);
        Console.WriteLine("Second Largest Digit: {0}", secondLargest);
    }
}
