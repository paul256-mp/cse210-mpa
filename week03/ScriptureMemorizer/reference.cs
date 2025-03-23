using System.Collections.Concurrent;
using System.Dynamic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
  private string _Book;
  private int _chapter;

  private int _verse;
  private int _endverse;

  public Reference(string book, int chapter, int verse)
  {
    _Book = book;
    _chapter = chapter;
    _verse = verse;
    _endverse = verse;

  }

  public Reference(string book, int chapter, int startverse, int endverse)
  {
    _Book = book;
    _chapter = chapter;
    _verse = startverse;
    _endverse = endverse;
  }

  public string GetDisplayText()
  {
    if (_verse == _endverse)
    {
      return $"{_Book} {_chapter}:{_verse}";
    }
    else
    {
      return $"{_Book} {_chapter}:{_verse}-{_endverse}";
    }
  }
}
