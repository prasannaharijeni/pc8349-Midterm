using System;
public class InventoryItem
{
    // Properties of the inventory Item class
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // Updating the item's price with the new price assigned.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        QuantityInStock = Math.Max(QuantityInStock - quantitySold, 0);
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Item Name: {ItemName}, Item ID: {ItemId}, Price: ${Price}, Quantity in Stock: {QuantityInStock}");
    }
}
class Program
{
    static double ApplyDiscount(double originalPrice, double discountPercentage)
    {
        double discountAmount = originalPrice * discountPercentage / 100;
        return originalPrice - discountAmount;
    }
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:

        // 1. Print details of all items.

        Console.WriteLine("Stock Record Details: ");
        item1.PrintDetails();
        item2.PrintDetails();

        //5. Update the price of the item with 10% discount
        double discountPercentage = 10;
        item1.UpdatePrice(ApplyDiscount(item1.Price, discountPercentage));
        item2.UpdatePrice(ApplyDiscount(item2.Price, discountPercentage));
        Console.WriteLine("\nUpdated Item Details after Applying Discount:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 2. Sell some items and then print the updated details.

        item1.SellItem(2);
        item2.SellItem(5);
        Console.WriteLine("\nUpdated Item Details after Selling:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 3. Restock an item and print the updated details.

        item1.RestockItem(5);
        Console.WriteLine("\nUpdated Item Details after Restocking:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 4. Check if an item is in stock and print a message accordingly.

        if (item1.IsInStock())
        {
            Console.WriteLine("\n The Item1 is in stock!! Grab Soon!!");
        }
        else
        {
            Console.WriteLine("\n The Item1 is not in stock at the moment!!! Please wait for further updates!!!");
        }
        if (item2.IsInStock())
        {
            Console.WriteLine("\n The Item2 is in stock!! Grab Soon!!");
        }
        else
        {
            Console.WriteLine("\n The Item2 is not in stock at the moment!!! Please wait for further updates!!!");
        }

    }
}
