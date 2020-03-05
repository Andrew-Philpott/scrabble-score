using System;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string Word { get; }
    public Scrabble(string word)
    {
      Word = word;
    }

    public bool CheckIfMultipleWords()
    {
      string[] splitWord = Word.Split(" ", StringSplitOptions.RemoveEmptyEntries);
      if (splitWord.Length > 1)
      {
        return true;
      }
      return false;
    }

    public bool WordContainsNonLetterCharacters()
    {
      return false;
    }
  }
}
