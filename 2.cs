using System;
using System.Collections.Generic;

// Abstract Class
public abstract class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public abstract double CalculateDiscount();
}

// Concrete Classes
public class Electronics : Product
{
    public override double CalculateDiscount()
    {
        return Price * 0.10;  // 10% discount
    }
}

public class Clothing : Product
{
    public override double CalculateDiscount()
    {
        return Price * 0.20;  // 20% discount
    }
}

public class Groceries : Product
{
    public override double CalculateDiscount()
    {
        return Price * 0.05;  // 5% discount
    }
}

// Interface
public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Main Program
public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics { ProductId = 1, Name = "Laptop", Price = 1000 },
            new Clothing { ProductId = 2, Name = "Shirt", Price = 50 }
        };

        foreach (var product in products)
        {
            double discount = product.CalculateDiscount();
            double finalPrice = product.Price - discount;
            Console.WriteLine("Product: " + product.Name + ", Discount: " + discount + ", Final Price: " + finalPrice);
        }
    }
}
