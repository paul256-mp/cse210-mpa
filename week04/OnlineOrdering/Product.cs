
public class Product
{
    private readonly string _name;
    private readonly string _productId;
    private readonly decimal _price;
    private readonly int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() => _name;
    public string GetProductId() => _productId;
    public decimal GetTotalCost() => _price * _quantity;
}
