using System.Numerics;
using FluentAssertions;
using Xunit;

namespace EulerSolutions.Tests
{
	public class BigIntegerExtensionsTests
	{
		public class Digits : BigIntegerExtensionsTests
		{
			[Fact]
			public void Returns_all_digits_in_a_number()
			{
				BigInteger number = 567432;
				number.Digits().Should().BeEquivalentTo(new[] {5, 6, 7, 4, 3, 2});
			}
			
			[Fact]
			public void Returns_zero_for_a_zero_input()
			{
				BigInteger number = 0;
				number.Digits().Should().BeEquivalentTo(new[] { 0 });
			}
		}
	}
}