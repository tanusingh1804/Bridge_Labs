using System;

class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 1200);
        Product p2 = new Product("Mouse", 25);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();
        Product.DisplayTotalProducts();
    }
}

class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    private static int totalProducts = 0;

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
        totalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product: " + ProductName + ", Price: " + Price);
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + totalProducts);
    }
}
