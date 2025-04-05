using System;

public class assignment
{
  private string _name;
  private string _topic;

  public void setassignment(string name, string topic)
  {
    _name = name;
    _topic = topic;
  }
  public string getName()
  {
    return _name;
  }
  public string getTopic()
  {
    return _topic;
  }
}
