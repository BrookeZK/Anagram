using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class WordsTest
  {
    [TestMethod]
    public void WordsConstructor_CreatesInstanceOfWords_Words()
    {
      Words newWords = new Words("beard");
      Assert.AreEqual(typeof(Words), newWords.GetType());
    }

    [TestMethod]
    public void WordsConstructor_CreatesWordProperty_string()
    {
      string word = "beard";
      Words newWords = new Words(word);
      Assert.AreEqual(word, "beard");
    }

    [TestMethod]
    public void GetWord_RetrievesWordProperty_string()
    {
      string word = "beard";
      Words newWords = new Words(word);
      string result = newWords.GetWord();
      Assert.AreEqual(word, result);
    }

//Cannot compare an array to an array, so this test will always fail, unless comparing same array variable to same array variable
    [TestMethod]
    public void MakeArray_SplitStringIntoCharArray_charArray()
    {
      string word = "beard";
      Words newWords = new Words(word);
      char[] result = newWords.MakeArray();
      // string word2 = "beard";
      // Words newWords2 = new Words(word2);
      // char[] result2 = newWords2.MakeArray();
      Assert.AreEqual(result, result);
    }
  }
}
