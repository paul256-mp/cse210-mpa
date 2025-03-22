
public class Fractions

{
  private_top int;
  private_bottom int;
}
public fraction
{
  _top = 1;
  _bottom = 1;
}

public fraction(int whole_number)
{
  _top = whole_number;
  _bottom = 1;
}

public class fraction(int top, int bottom)
{
  _top= top;
  _bottom = bottom;
}

public string Getfractionstring()
{
  string text = $"{_top}" /{ _bottom};
  return text
}

public double Getdecimalvalue()
{
  return (double)_top / (double)bottom;
}