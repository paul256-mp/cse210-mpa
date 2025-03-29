
using System;
using System.Net.Sockets;
public class _Customer
{
  private string _name;
  private Address address;

  public bool isinUSA()
  {
    // Assuming 'country' is a property or variable to check
    return address.IsInUSA();
  }

}