
using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture

  {
    private Reference Reference;
    private List<Word> _Words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
      Reference = reference;
      _Words = new List<Word>();
    string[] wordarray = text.Split();
      foreach (string word in wordarray)
      {
        _Words.Add(new Word(word));
      }
    }

  public void HideRandomWords(int numberToHide=3)
  {
    for (int i = 0; i < numberToHide; i++)
    {
      int index = _random.Next(_Words.Count);
      _Words[index].hide();
        
      }
  }

  public string GetDisplayText()
  {
      string displayText = Reference.GetDisplayText() + " ";
      foreach (var word in _Words)
      {
        displayText += word.getdisplay() + " ";
      }
      return displayText.Trim();
  }

  public bool IsCompletelyHidden()
  {
      foreach (var word in _Words)
      {
        if (!word.ishidden())
        {
          return false;
        }
      }
      return true;
  }
  }

        