using NUnit.Framework;
using WordCount;

namespace WordCounterTests
{
	public class Tests
	{
		private WordCounter _wordCounter;

		[SetUp]
		public void Setup() => _wordCounter = new WordCounter();

		[TestCase(null, 0)]
		[TestCase("", 0)]
		[TestCase(" ", 0)]
		[TestCase("  ", 0)]
		[TestCase("   ", 0)]
		[TestCase("I", 1)]
		[TestCase("I ", 1)]
		[TestCase(" I", 1)]
		[TestCase(" I ", 1)]
		[TestCase("I  ", 1)]
		[TestCase("  I", 1)]
		[TestCase("  I  ", 1)]
		[TestCase("Hello", 1)]
		[TestCase("Hello ", 1)]
		[TestCase(" Hello", 1)]
		[TestCase(" Hello ", 1)]
		[TestCase("Hello  ", 1)]
		[TestCase("  Hello", 1)]
		[TestCase("  Hello  ", 1)]
		[TestCase("Hello World", 2)]
		[TestCase("Hello  World", 2)]
		[TestCase(" Hello World", 2)]
		[TestCase("Hello World ", 2)]
		[TestCase("Hello   World", 2)]
		[TestCase("  Hello World", 2)]
		[TestCase("Hello World  ", 2)]
		[TestCase("Hi, my name is Slim Shady.", 6)]
		public void Returns_Word_Count(string phrase, int expectedWordCount)
		{
			var calculatedWordCount = _wordCounter.CountWords(phrase);
			Assert.AreEqual(expectedWordCount, calculatedWordCount);
		}
	}
}