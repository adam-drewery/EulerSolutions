using FluentAssertions;
using Xunit;

namespace EulerSolutions.Tests
{
	public class Int64ExtensionsTests
	{
		public class Digits : Int64ExtensionsTests
		{
			[Fact]
			public void Returns_all_digits_in_a_number()
			{
				567432L.Digits().Should().BeEquivalentTo(new[] {5, 6, 7, 4, 3, 2});
			}
		}
	}
}