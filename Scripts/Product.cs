
/// <summary>
/// Product in the inventory.
/// </summary>
public class Product
{
    public int ProductId { get; private set; }
    public string Name { get; private set; }
    public int QuantityInStock { get; private set; }
    public double Price { get; private set; }

    public Product(int productId, string name, int quantityInStock, double price)
    {
        ProductId = productId;
        Name = name;
        QuantityInStock = quantityInStock;
        Price = price;
    }

    public void UpdateQuantity(int newQuantity)
    {
        if (newQuantity < 0)
        {
            Console.WriteLine("Quantity cannot be negative.");
            return;
        }

        QuantityInStock = newQuantity;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {Name}, Quantity: {QuantityInStock}, Price: Pesos {Price:F2}";
    }
}