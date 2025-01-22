using System;

class DiscountCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the fee amount:");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the discount percentage:");
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        double discountAmount = fee * discountPercent / 100;
        double finalFee = fee - discountAmount;
        Console.WriteLine("The discount amount is INR " + discountAmount + " and the final discounted fee is INR " + finalFee);
    }
}
