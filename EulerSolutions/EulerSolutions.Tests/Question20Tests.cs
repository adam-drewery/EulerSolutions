using FluentAssertions;
using Xunit;

namespace EulerSolutions.Tests
{
	public class Question20Tests
	{
		[Fact]
		public void Finds_the_sum_of_digits_in_the_factorial_of_5()
		{
			Question20.FactorialDigitSum(5).Should().Be(3);
		}

		[Fact]
		public void Finds_the_sum_of_digits_in_the_factorial_of_100()
		{
			Question20.FactorialDigitSum(100).Should().Be(648);
		}
	}
}