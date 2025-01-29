using InventoryManagementSystem;

/// <summary>
/// Main program class for the Inventory Management System.
/// </summary>
class Program
{
    static void Main()
    {
        InventoryManager inventory = new InventoryManager();

        while (true)
        {
            Console.WriteLine("\n--- Inventory Management System ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Update Product Quantity");
            Console.WriteLine("4. List Products");
            Console.WriteLine("5. Get Total Inventory Value");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Product ID: ");
                    if (!int.TryParse(Console.ReadLine(), out int productId) || productId <= 0)
                    {
                        Console.WriteLine("Invalid Product ID. Please enter a positive integer.");
                        break;
                    }
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
                    {
                        Console.WriteLine("Invalid Quantity. Please enter a non-negative integer.");
                        break;
                    }
                    Console.Write("Enter Price: ");
                    if (!double.TryParse(Console.ReadLine(), out double price) || price < 0)
                    {
                        Console.WriteLine("Invalid Price. Please enter a non-negative number.");
                        break;
                    }

                    Product newProduct = new Product(productId, name, quantity, price);
                    inventory.AddProduct(newProduct);
                    break;

                case 2:
                    Console.Write("Enter Product ID to remove: ");
                    if (!int.TryParse(Console.ReadLine(), out int removeId) || removeId <= 0)
                    {
                        Console.WriteLine("Invalid Product ID. Please enter a positive integer.");
                        break;
                    }
                    inventory.RemoveProduct(removeId);
                    break;

                case 3:
                    Console.Write("Enter Product ID to update: ");
                    if (!int.TryParse(Console.ReadLine(), out int updateId) || updateId <= 0)
                    {
                        Console.WriteLine("Invalid Product ID. Please enter a positive integer.");
                        break;
                    }
                    Console.Write("Enter New Quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int newQuantity) || newQuantity < 0)
                    {
                        Console.WriteLine("Invalid Quantity. Please enter a non-negative integer.");
                        break;
                    }
                    inventory.UpdateProduct(updateId, newQuantity);
                    break;

                case 4:
                    inventory.ListProducts();
                    break;

                case 5:
                    inventory.GetTotalValue();
                    break;

                case 6:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
