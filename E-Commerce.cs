//using System;
//using System.Collections.Generic;

//class Order
//{
//    public int OrderID { get; }
//    public List<Product> Products { get; } = new List<Product>();
//    public double Total { get; private set; }

//    public Order(int orderId)
//    {
//        OrderID = orderId;
//    }

//    public void AddProduct(Product product)
//    {
//        Products.Add(product);
//        Total += product.Price;
//    }

//    public void ShowOrderDetails()
//    {
//        Console.WriteLine($"Order ID: {OrderID}");
//        foreach (Product product in Products)
//        {
//            Console.WriteLine($"Product: {product.Name}, Price: ₹{product.Price}");
//        }
//        Console.WriteLine($"Total: ₹{Total}\n");
//    }
//}

//class Customer
//{
//    public string Name { get; }
//    public List<Order> Orders { get; } = new List<Order>();

//    public Customer(string name)
//    {
//        Name = name;
//    }

//    public void PlaceOrder(Order order)
//    {
//        Orders.Add(order);
//    }

//    public void ShowCustomerOrders()
//    {
//        Console.WriteLine($"\nOrders placed by {Name}:");
//        foreach (Order order in Orders)
//        {
//            order.ShowOrderDetails();
//        }
//    }
//}

//class Product
//{
//    public string Name { get; }
//    public double Price { get; }

//    public Product(string name, double price)
//    {
//        Name = name;
//        Price = price;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter customer name: ");
//        string customerName = Console.ReadLine();
//        Customer customer = new Customer(customerName);

//        Console.Write("Enter number of orders: ");
//        int orderCount = int.Parse(Console.ReadLine());

//        for (int i = 0; i < orderCount; i++)
//        {
//            Console.Write("Enter order ID: ");
//            int orderId = int.Parse(Console.ReadLine());
//            Order order = new Order(orderId);

//            Console.Write("Enter number of products: ");
//            int productCount = int.Parse(Console.ReadLine());

//            for (int j = 0; j < productCount; j++)
//            {
//                Console.Write("Enter product name: ");
//                string productName = Console.ReadLine();
//                Console.Write("Enter product price: ₹");
//                double productPrice = double.Parse(Console.ReadLine());

//                Product product = new Product(productName, productPrice);
//                order.AddProduct(product);
//            }

//            customer.PlaceOrder(order);
//        }

//        customer.ShowCustomerOrders();
//    }
//}
