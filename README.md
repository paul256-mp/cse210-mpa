Encapsulation is a fundamental concept in object-oriented programming (OOP). It refers to bundling the data (variables) and methods (functions) that operate on the data into a single unit or class.

Benefit of Encapsulation: Encapsulation enhances the security and integrity of the code by preventing unauthorized or unintended interference with the data

Application of Encapsulation: A common application is in creating a banking system, where details like account balance are hidden (private) and only accessible through methods like deposit() or withdraw().


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

Reference and _Words are part of the class Scripture and represent its data.

The internal representation of _Words (a List<Word> object) is protected from external interference.

The operations on _Words, such as splitting the string text and adding Word objects, are contained within the class's constructor.