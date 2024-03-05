using System.Runtime.InteropServices.Marshalling;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        this.ItemName = itemName;  //initializing the properties
        this.ItemId = itemId;
        this.Price= price;
        this.QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
        Console.WriteLine($"Price of {ItemName} updated to $ {Price}");
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"{additionalQuantity} new {ItemName}'s are added to stock. " +
            $"Now we have {QuantityInStock} {ItemName}'s in stock");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.

        if (quantitySold > QuantityInStock)
        {
            Console.WriteLine($"Error: Not enough {ItemName} in stock.");
            return;
        }

        QuantityInStock -= quantitySold;
        Console.WriteLine($"{quantitySold} {ItemName}'s sold. Only {QuantityInStock} {ItemName} left in stock");
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
   
    public void PrintDetails()
    {
        Console.WriteLine($" Name is: {ItemName} ID is: {ItemId} Price is: {Price} Total quantity is: {QuantityInStock}");

    }
}
class Program
{
    public static object PrintDetails{ get; private set; }
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);


        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Basic Inventory Management System:");
            Console.WriteLine("1. Print details of all items.");
            Console.WriteLine("2. Sell some items and then print the updated details.");
            Console.WriteLine("3. Restock an item and print the updated details.");
            Console.WriteLine("4. Check if an item is in stock.");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {

                case 1:
                    //Printing details of all items
                    Console.WriteLine("All items that are available now:");
                    item1.PrintDetails();
                    item2.PrintDetails();
                    Console.WriteLine();
                    break;
                case 2:

                    //Selling some items
                    Console.WriteLine("Selling 10 Laptops and 6 Smartphones.");
                    item1.SellItem(10);
                    item2.SellItem(6);
                    Console.WriteLine("Updated stock after selling:");
                    item1.PrintDetails();
                    item2.PrintDetails();
                    Console.WriteLine();
                    break;

                case 3:
                    //Restocking items
                    Console.WriteLine("Restocking 3 laptops and 2 smartphones");
                    item1.RestockItem(3);
                    item2.RestockItem(2);
                    Console.WriteLine("Updated stock after restocking:");
                    item1.PrintDetails();
                    item2.PrintDetails();
                    Console.WriteLine();
                    break;

                case 4:
                    //checking if an item is in stock
                    Console.Write("Enter the name of the item to check if it's in stock: ");
                    string itemName = Console.ReadLine();
                    if (string.Equals(itemName, item1.ItemName, StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine($"Is {item1.ItemName} in stock? {item1.IsInStock()}");
                    else if (string.Equals(itemName, item2.ItemName, StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine($"Is {item2.ItemName} in stock? {item2.IsInStock()}");
                    else
                        Console.WriteLine("Item not found.");
                    Console.WriteLine();
                    break;
                case 5:
                    exit = true;
                    break;



            }










        }


    }
}
