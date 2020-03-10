using System;
using FluentAssertions;
using Xunit;

namespace EulerSolutions.Tests
{
	public class Question19Tests
	{
		[Fact]
		public void Finds_the_number_of_sundays_in_march_2020()
		{
			var start = new DateTime(2020, 3, 1);
			var end = new DateTime(2020, 3, 31);
			Question19.CountingSundays(start, end).Should().Be(5);
		}

		[Fact]
		public void Finds_the_number_of_sundays_in_the_20th_century()
		{
			var start = new DateTime(1901, 1, 1);
			var end = new DateTime(2000, 12, 31);
			Question19.CountingSundays(start, end).Should().Be(5217);
		}
	}
}