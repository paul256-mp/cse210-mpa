using System;

public class fraction
{
  private int _top;
  private int _bottom;
  public fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  public string GetFractionString()
  {
    string text = $"{_top}/{_bottom}";
    return text;
  }

  public double GetDecimalValue()
  {
    return (double)_top / _bottom;
  }
}
    