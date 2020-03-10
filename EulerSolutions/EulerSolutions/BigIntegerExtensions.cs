using System.Collections.Generic;
using System.Numerics;

namespace EulerSolutions
{
	public static class BigIntegerExtensions
	{
		public static IEnumerable<int> Digits(this BigInteger input)
		{
			if (input == 0) yield return 0;
			
			// I did google this one:
			// https://www.includehelp.com/dot-net/find-sum-of-all-digits-of-a-given-number.aspx
			// Without googling a solution I'd have just converted the source to a string and parsed each digit.
			while (input != 0)
			{
				yield return (short) (input % 10);
				input /= 10;
			}
		}
	}
}