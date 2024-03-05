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
        PrintDetails(item1);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        // 2. Sell some items and then print the updated details.
        // 3. Restock an item and print the updated details.
        // 4. Check if an item is in stock and print a message accordingly.


    }
}
