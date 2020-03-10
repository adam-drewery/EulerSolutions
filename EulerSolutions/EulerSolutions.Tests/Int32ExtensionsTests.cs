using FluentAssertions;
using Xunit;

namespace EulerSolutions.Tests
{
	public class Int32ExtensionsTests
	{
		public class ToPrettyString : Int32ExtensionsTests
		{
			[Fact]
			public void Pretty_prints_a_single_digit()
			{
				5.ToPrettyString().Should().Be("five");
			}

			[Fact]
			public void Pretty_prints_a_small_2_digit_number()
			{
				14.ToPrettyString().Should().Be("fourteen");
			}
			
			[Fact]
			public void Pretty_prints_a_large_2_digit_number()
			{
				97.ToPrettyString().Should().Be("ninety seven");
			}
			
			[Fact]
			public void Pretty_prints_a_3_digit_number()
			{
				518.ToPrettyString().Should().Be("five hundred and eighteen");
			}
			
			[Fact]
			public void Pretty_prints_1000()
			{
				1000.ToPrettyString().Should().Be("one thousand");
			}
		}
	}
}