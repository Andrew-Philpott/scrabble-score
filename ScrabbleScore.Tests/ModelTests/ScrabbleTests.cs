using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {

    [TestMethod]
    public void ScrabbleConstructor_CreatesInstanceScrabble_Scrabble()
    {
      string word = "hello";
      Scrabble newWord = new Scrabble("Hello");
      Assert.AreEqual(typeof(Scrabble), newWord.GetType());
      Assert.AreEqual(word, newWord.Word);
    }

    [TestMethod]
    public void CheckIfMultipleWords_ChecksStringForMultipleWordsReturnsTrueIfMoreThanOneWord_True()
    {
      Scrabble newWord = new Scrabble("Hello hi");
      bool result = newWord.CheckIfMultipleWords();
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void WordContainsNonLetterCharacters_ChecksWordForNonLetterCharactersReturnTrueIfWordContainsNonLetterCharacters_True()
    {
      Scrabble newWord = new Scrabble("H3llo");
      bool result = newWord.WordContainsNonLetterCharacters();
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CalculateWordScore_Calculates_True()
    {
      Scrabble newWord = new Scrabble("H3llo");
      bool result = newWord.WordContainsNonLetterCharacters();
      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void IsWordEmptyString_ReturnTrueIfTheWordStringDoesntContainAnyLetters_True()
    {
      Scrabble newWord = new Scrabble("Hello");
      bool result = newWord.IsWordEmptyString();
      Assert.AreEqual(true, result);
    }
  }
}