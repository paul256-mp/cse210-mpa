
public class Order
{
    private readonly List<Product> _products;
    private readonly Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal productsTotal = _products.Sum(product => product.GetTotalCost());
        decimal shippingCost = _customer.IsInUSA() ? 5m : 35m;
        return productsTotal + shippingCost;
    }

    public string GeneratePackingLabel()
    {
        IEnumerable<string> labels = _products.Select(product => $"{product.GetName()} (ID: {product.GetProductId()})");
        return string.Join("\n", labels);
    }

    public string GenerateShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
