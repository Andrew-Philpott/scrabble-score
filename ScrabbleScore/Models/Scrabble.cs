namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string Word { get; }
    public Scrabble(string word)
    {
      Word = word;
    }
  }
}