using System.Collections.Concurrent;

public class Address
{
  public string Street;
  public string City;
  public string State;
  public string ZipCode;

  private string country;

  public bool IsInUSA()
  {

    {
      return country.ToLower() == "usa";
    }
  }
  public string GetFullAddress()
  {
      return $"{Street}, {City}, {State}, {ZipCode}, {country}";
  }
}
