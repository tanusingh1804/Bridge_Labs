using System;
using System.Collections.Generic;

// Abstract class for warehouse items
abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }
}

// Different item types
class Electronics : WarehouseItem { }
class Groceries : WarehouseItem { }
class Furniture : WarehouseItem { }

// Generic storage class
class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item) => items.Add(item);

    public void DisplayItems()
    {
        foreach (var item in items)
            Console.WriteLine($"{item.Name} - ${item.Price}");
    }
}

// Main execution
class Program
{
    static void Main()
    {
        Storage<Electronics> electronicStorage = new Storage<Electronics>();
        electronicStorage.AddItem(new Electronics { Name = "Laptop", Price = 1200 });
        electronicStorage.AddItem(new Electronics { Name = "Smartphone", Price = 800 });

        Storage<Groceries> groceryStorage = new Storage<Groceries>();
        groceryStorage.AddItem(new Groceries { Name = "Apple", Price = 2 });
        groceryStorage.AddItem(new Groceries { Name = "Milk", Price = 3 });

        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture { Name = "Chair", Price = 150 });
        furnitureStorage.AddItem(new Furniture { Name = "Table", Price = 300 });

        // Display stored items
        electronicStorage.DisplayItems();
        groceryStorage.DisplayItems();
        furnitureStorage.DisplayItems();
    }
}
