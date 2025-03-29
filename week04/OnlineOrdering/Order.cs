
using System;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Order
{
  private customer _Customer;
  private List<string> products;

  public decimal GetTotalPrice()
  {
    // Example implementation: calculate total price based on products
    decimal price = 10.0m; // Example price per product
    return products.Count * price;

  }
  public string GetPackingLabel()
  {
      // Example implementation: return a packing label for the order
      return $"Packing Label for Customer: {_Customer}";
  }






}