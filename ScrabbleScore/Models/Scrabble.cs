using System;
using System.Text.RegularExpressions;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string Word { get; }
    public Scrabble(string word)
    {
      Word = word.ToLower();
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
      Regex r = new Regex("^[a-z]*$");
      if (r.IsMatch(Word))
      {
        return false;
      }
      return true;
    }

    public bool IsWordEmptyString()
    {
      if (Word == "")
      {
        return true;
      }
      return false;
    }

    public int CalculateOnePointLetters()
    {
      Regex onePoint = new Regex("[aeioulnrst]");
      MatchCollection matches = onePoint.Matches(Word);
      return matches.Count;
    }

    public int CalculateTwoPointLetters()
    {
      Regex twoPoint = new Regex("[dg]");
      MatchCollection matches = twoPoint.Matches(Word);
      return matches.Count * 2;
    }

    public int CalculateThreePointLetters()
    {
      Regex threePoint = new Regex("[bcmp]");
      MatchCollection matches = threePoint.Matches(Word);
      return matches.Count * 3;
    }
  }
}
