using System;
using System.IO;

class Product
{
    // Private fields (Encapsulation)
    private string name;
    private double price;
    private int stock;

    // Public properties with validation
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        // Validation: Price cannot be negative
        set { if (value >= 0) price = value; }
    }

    public int Stock
    {
        get { return stock; }
        // Validation: Stock cannot be negative
        set { if (value >= 0) stock = value; }
    }

    // Constructor
    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    // Decrease stock when selling
    public void Sell(int quantity)
    {
        if (quantity > 0 && quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} {Name}(s). Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine($"Failed to sell {quantity} {Name}(s). Not enough stock!");
        }
    }

    // Increase stock when restocking
    public void Restock(int quantity)
    {
        if (quantity > 0)
        {
            Stock += quantity;
            Console.WriteLine($"Restocked {quantity} {Name}(s). New stock: {Stock}");
        }
    }

    // Format product details for display and file saving
    public string GetDetails()
    {
        return $"Name: {Name}, Price: {Price}, Stock: {Stock}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- 1. Operations ---");

        Product p1 = new Product("Laptop", 800, 10);
        Product p2 = new Product("Mouse", 25, 50);
        Product p3 = new Product("Keyboard", 45, 30);

        p1.Sell(3);      
        p2.Sell(60);      
        p3.Restock(20);   

        Console.WriteLine("\n--- 2. Saving to File ---");

        string filePath = "products.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(p1.GetDetails());
            writer.WriteLine(p2.GetDetails());
            writer.WriteLine(p3.GetDetails());
        }
        Console.WriteLine("Data successfully saved to products.txt");

        Console.WriteLine("\n--- 3. Reading from File ---");

        if (File.Exists(filePath))
        {
            string[] savedProducts = File.ReadAllLines(filePath);
            foreach (string line in savedProducts)
            {
                Console.WriteLine(line);
            }
        }
    }
}