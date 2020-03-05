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
    public void WordContainsOnlyLetterCharacters_ChecksWordForNonLetterCharactersReturnFalseIfWordContainsNonLetterCharacters_False()
    {
      Scrabble newWord = new Scrabble("H3llo");
      bool result = newWord.WordContainsOnlyLetterCharacters();
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void WordContainsOnlyLetterCharacters_ChecksWordOnlyContainsLetters_True()
    {
      Scrabble newWord = new Scrabble("Hello");
      bool result = newWord.WordContainsOnlyLetterCharacters();
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
    public void CheckIfNonLettersOrEmpty_ReturnTrueIfEmptyOrNonLetterCharacters_True()
    {
      Scrabble newWord = new Scrabble("425");
      bool result = newWord.CheckIfNonLettersOrEmpty();
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CheckIfNonLettersOrEmpty_ReturnFalseIfNotEmptyAndOnlyLetterCharacters_False()
    {
      Scrabble newWord = new Scrabble("hello");
      bool result = newWord.CheckIfNonLettersOrEmpty();
      Assert.AreEqual(false, result);
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

    [TestMethod]
    public void CalculateFourPointLetters_ReturnZeroIfNoLettersMatch_0()
    {
      Scrabble newWord = new Scrabble("degiuxz");
      int result = newWord.CalculateFourPointLetters();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateFourPointLetters_ReturnScoreIfSomeLettersMatch_16()
    {
      Scrabble newWord = new Scrabble("highway");
      int result = newWord.CalculateFourPointLetters();
      Assert.AreEqual(16, result);
    }

    [TestMethod]
    public void CalculateFivePointLetters_ReturnZeroIfNoLettersMatch_0()
    {
      Scrabble newWord = new Scrabble("queen");
      int result = newWord.CalculateFivePointLetters();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateFivePointLetters_ReturnScoreIfSomeLettersMatch_5()
    {
      Scrabble newWord = new Scrabble("king");
      int result = newWord.CalculateFivePointLetters();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void CalculateEightPointLetters_ReturnZeroIfNoLettersMatch_0()
    {
      Scrabble newWord = new Scrabble("queen");
      int result = newWord.CalculateEightPointLetters();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateEightPointLetters_ReturnScoreIfSomeLettersMatch_8()
    {
      Scrabble newWord = new Scrabble("jack");
      int result = newWord.CalculateEightPointLetters();
      Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void CalculateTenPointLetters_ReturnZeroIfNoLettersMatch_0()
    {
      Scrabble newWord = new Scrabble("shiva");
      int result = newWord.CalculateTenPointLetters();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateTenPointLetters_ReturnScoreIfSomeLettersMatch_20()
    {
      Scrabble newWord = new Scrabble("quetzalcoatl");
      int result = newWord.CalculateTenPointLetters();
      Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void CalculateScore_ReturnScoreForAllLetters_8()
    {
      Scrabble newWord = new Scrabble("hello");
      int result = newWord.CalculateScore();
      Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void CalculateScore_ReturnScoreForAllLetters_32()
    {
      Scrabble newWord = new Scrabble("quetzalcoatl");
      int result = newWord.CalculateScore();
      Assert.AreEqual(32, result);
    }
  }
}