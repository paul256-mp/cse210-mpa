using System;

public class Word
{
  private string _text;
  private bool _isHidden;
  public Word(string text)
  {
    _text = text;
    _isHidden = false;
  }
  public void hide()
  {
    _isHidden = true;
  }

  public void show()
  {
    _isHidden = false;
  }

  public bool ishidden()
  {
    return _isHidden;
  }

  public string getdisplay()
  {
    return _isHidden ? new string('_', _text.Length) : _text;


  }
}