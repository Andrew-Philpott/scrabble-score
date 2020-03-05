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

    public bool WordContainsOnlyLetterCharacters()
    {
      Regex r = new Regex("^[a-z]*$");
      if (r.IsMatch(Word))
      {
        return true;
      }
      return false;
    }

    public bool IsWordEmptyString()
    {
      if (Word == "")
      {
        return true;
      }
      return false;
    }

    public bool CheckIfNonLettersOrEmpty()
    {
      if (IsWordEmptyString() || !WordContainsOnlyLetterCharacters())
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

    public int CalculateFourPointLetters()
    {
      Regex fourPoint = new Regex("[fhvwy]");
      MatchCollection matches = fourPoint.Matches(Word);
      return matches.Count * 4;
    }

    public int CalculateFivePointLetters()
    {
      Regex fivePoint = new Regex("[k]");
      MatchCollection matches = fivePoint.Matches(Word);
      return matches.Count * 5;
    }

    public int CalculateEightPointLetters()
    {
      Regex eightPoint = new Regex("[j]");
      MatchCollection matches = eightPoint.Matches(Word);
      return matches.Count * 8;
    }

    public int CalculateTenPointLetters()
    {
      Regex tenPoint = new Regex("[qz]");
      MatchCollection matches = tenPoint.Matches(Word);
      return matches.Count * 10;
    }

    public int CalculateScore()
    {
      int score = 0;
      score += CalculateOnePointLetters();
      score += CalculateTwoPointLetters();
      score += CalculateThreePointLetters();
      score += CalculateFourPointLetters();
      score += CalculateFivePointLetters();
      score += CalculateEightPointLetters();
      score += CalculateTenPointLetters();
      return score;
    }
  }
}
