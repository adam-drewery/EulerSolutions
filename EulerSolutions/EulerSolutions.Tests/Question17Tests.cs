using System.Linq;
using FluentAssertions;
using Xunit;

namespace EulerSolutions.Tests
{
	public class Question17Tests
	{
		[Fact]
		public void Gets_the_number_letter_count_for_1_to_5()
		{
			var range = Enumerable.Range(1, 5);
			Question17.NumberLetterCounts(range).Should().Be(19);
		}

		[Fact]
		public void Gets_the_number_letter_count_for_1_to_1000()
		{
			var range = Enumerable.Range(1, 1000);
			Question17.NumberLetterCounts(range).Should().Be(21124);
		}
	}
}