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
      string word = "Hello";
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
  }
}