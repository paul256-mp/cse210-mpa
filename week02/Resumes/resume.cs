
using System;

public class Resume
{
  public string _Name;
  public List<Job> _Jobs = new List<Job>();
  
  public void Display()
  {
    Console.WriteLine($"Name: {_Name}");
    Console.WriteLine("jobs:");
    foreach (var job in _Jobs)

    {
      job.Display();
    }
  }
}
      