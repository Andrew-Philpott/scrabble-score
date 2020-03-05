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
      Scrabble newWord = new Scrabble("");
      bool result = newWord.IsWordEmptyString();
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CalculateOnePointLetters_ReturnZeroIfNoLettersMatch_0()
    {
      Scrabble newWord = new Scrabble("bcdfghj");
      int result = newWord.CalculateOnePointLetters();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateOnePointLetters_ReturnScoreIfSomeLettersMatch_4()
    {
      Scrabble newWord = new Scrabble("hello");
      int result = newWord.CalculateOnePointLetters();
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void CalculateTwoPointLetters_ReturnZeroIfNoLettersMatch_0()
    {
      Scrabble newWord = new Scrabble("abcefh");
      int result = newWord.CalculateTwoPointLetters();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateTwoPointLetters_ReturnScoreIfSomeLettersMatch_4()
    {
      Scrabble newWord = new Scrabble("good");
      int result = newWord.CalculateTwoPointLetters();
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void CalculateThreePointLetters_ReturnZeroIfNoLettersMatch_0()
    {
      Scrabble newWord = new Scrabble("adefglnoq");
      int result = newWord.CalculateThreePointLetters();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateThreePointLetters_ReturnScoreIfSomeLettersMatch_9()
    {
      Scrabble newWord = new Scrabble("bump");
      int result = newWord.CalculateThreePointLetters();
      Assert.AreEqual(9, result);
    }
  }
}