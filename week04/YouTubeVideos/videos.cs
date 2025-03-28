
using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
public class Videos
{
  private string _titles;
  private string _author;
  private int length;
  private List<Comments> comments = new List<Comments>();

  public List<Comments> GetComments()
  {
      return comments;
  }

}