using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EulerSolutions
{
	/// <summary>
	/// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
	/// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
	/// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
	/// The use of "and" when writing out numbers is in compliance with British usage.
	/// </summary>
	public static class Question17
	{
		public static int NumberLetterCounts(IEnumerable<int> numbers)
		{
			var strings = numbers.Select(i => i.ToPrettyString()).ToArray();

			foreach (var s in strings) Debug.WriteLine(s);

			return strings.Sum(s => s.Count(char.IsLetter));
		}
	}
}