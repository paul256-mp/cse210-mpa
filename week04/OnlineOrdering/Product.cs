
using System;
using System.Runtime.CompilerServices;
public class Products
{
  private int _productId;
  private int _price;
  private int _quantity;

  public Products(int productId, int price, int quantity)
  {
      _productId = productId;
      _price = price;
      _quantity = quantity;
  }

  Products products = new Products(1, 100, 2);




}
