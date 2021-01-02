using System;
using System.Linq;

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
			if (phrase== null)
      {
				return 0;
      }

			int c = 0;
			var segments = phrase.Split(' ');

			foreach( string segment in segments)
      {
				if(segment != "")
        {
					c++;
        }
      }

			return c;
		}
	}
}
