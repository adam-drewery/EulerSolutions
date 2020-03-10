using System.Collections.Generic;

namespace EulerSolutions
{
	public static class Int64Extensions
	{
		public static IEnumerable<int> Digits(this long input)
		{
			var digits = new List<int>();
			// I googled this:
			// https://www.includehelp.com/dot-net/find-sum-of-all-digits-of-a-given-number.aspx
			// Without googling a solution I'd have just converted the source to a string and parsed each digit.
			while (input != 0)
			{
				digits.Add((int) (input % 10));
				input /= 10;
			}

			digits.Reverse();
			return digits;
		}
	}
}