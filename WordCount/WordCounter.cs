namespace WordCount
{
  public class WordCounter
  {
    /// <summary>
    /// Returns the number of the words in the phrase argument.  Assume that the phrase is a single line and
    /// that words are only delimited by spaces.  A word must contain at least 1 non-space character
    /// but does not necessarily need to be valid English. 
    /// </summary>
    public int CountWords(string phrase)
    {
      if (phrase == null)
      {
        return 0;
      }

      var count = 0;

      for (int i = 0; i < phrase.Length; i++)
      {
        var endOfWord = i != 0 && phrase[i] == ' ' && phrase[i - 1] != ' ';
        var letterAtEndOfString = phrase[i] != ' ' && i == phrase.Length - 1;

        if (endOfWord || letterAtEndOfString)
        {
          count++;
        }
      }

      return count;
    }
  }
}
