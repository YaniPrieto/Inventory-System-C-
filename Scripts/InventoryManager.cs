namespace InventoryManagementSystem
{
    /// <summary>
    /// Manage the inventory product, adding, removing, updating and listing products.
    /// </summary>
    public class InventoryManager
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public void AddProduct(Product product)
        {
            if (products.ContainsKey(product.ProductId))
            {
                Console.WriteLine("Product ID already exists!");
                return;
            }
            products[product.ProductId] = product;
            Console.WriteLine("Product added successfully.");
        }

        public void RemoveProduct(int productId)
        {
            if (products.Remove(productId))
            {
                Console.WriteLine("Product removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void UpdateProduct(int productId, int newQuantity)
        {
            if (products.TryGetValue(productId, out Product product))
            {
                product.UpdateQuantity(newQuantity);
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void ListProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products in inventory.");
                return;
            }

            Console.WriteLine("\nInventory List:");
            foreach (var product in products.Values)
            {
                Console.WriteLine(product);
            }
        }

        public void GetTotalValue()
        {
            double totalValue = products.Values.Sum(p => p.QuantityInStock * p.Price);
            Console.WriteLine($"Total inventory value: Pesos {totalValue:F2}");
        }
    }
}
