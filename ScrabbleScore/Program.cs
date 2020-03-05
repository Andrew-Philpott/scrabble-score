using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Welcome()
    {
      Console.WriteLine("Welcome to Scrabble Score! Enter a word and determine it's score value with our score calculator.");
    }
    public static void Error()
    {
      Console.WriteLine("Multiple words are not allowed. Please enter a single word.");
    }
    public static void AskForWordInput()
    {
      Console.WriteLine("Please enter a word containing only letter characters. Multiple words cannot be used.");
      string userWord = Console.ReadLine();
      Scrabble scrabble = new Scrabble(userWord);
      bool ismultipleWords = scrabble.CheckIfMultipleWords();
      if (ismultipleWords)
      {
        Error();
        AskForWordInput();
      }
      else
      {
        bool isScoreZero = scrabble.CheckIfNonLettersOrEmpty();
        if (isScoreZero)
        {
          Console.WriteLine("Score is equal to 0.");
        }
        else
        {
          int score = scrabble.CalculateScore();
          Console.WriteLine("The score value for your word is:");
          Console.WriteLine(score);
        }
      }
    }
    public static void Main()
    {
      Welcome();
      AskForWordInput();
    }
  }
}