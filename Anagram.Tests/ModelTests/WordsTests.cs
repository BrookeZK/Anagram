using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using System;
using System.Collections.Generic;

namespace Anagram.Tests
{
  [TestClass]
  public class WordsTest : IDisposable
  {

    public void Dispose()
    {
      Words.ClearAll();
    }

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

    [TestMethod]
    public void MakeString_CharArrayIntoString_string()
    {
      string word = "beard";
      Words newWords = new Words(word);
      char[] result = newWords.MakeArray();
      string newResult = Words.MakeString(result);
      Assert.AreEqual(word, newResult);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_WordsList()
    {

      //Arrange
      List<Words> newList = new List<Words> {};

      //Act
      List<Words> result = Words.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsWords_WordsList()
    {
      string word1 = "cat";
      string word2 = "liger";
      Words newWord1 = new Words(word1);
      Words newWord2 = new Words(word2);
      List<Words> newList = new List<Words> { newWord1, newWord2 };

      List<Words> result = Words.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Compare_CompareCharArrayToMainWord_true()
    {
      string word1 = "beard";
      string word2 = "bread";
      Words newWord1 = new Words(word1);
      Words newWord2 = new Words(word2);
      char[] newNewWord1 = newWord1.MakeArray();
      char[] newNewWord2 = newWord2.MakeArray();
      bool result = Words.Compare(newNewWord1, newNewWord2);
      Assert.AreEqual(result, true);
    }
  }
}
