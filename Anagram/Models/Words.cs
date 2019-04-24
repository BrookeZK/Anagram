namespace Anagram
{
  public class Words
  {
    private string _word;

    public Words (string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    public char[] MakeArray()
    {
      char[] charWordArray = _word.ToCharArray();
      return charWordArray;
    }
  }
}
