using System.Collections.Generic;

namespace EulerSolutions
{
	public static class Int64Extensions
	{
		public static IEnumerable<int> Digits(this long input)
		{
			if (input == 0) return new[] { 0 };
			
			var digits = new List<int>();
			
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