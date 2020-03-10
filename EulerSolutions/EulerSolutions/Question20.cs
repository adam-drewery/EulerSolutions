using System.Linq;
using System.Numerics;

namespace EulerSolutions
{
	/// <summary>
	/// n! means n × (n − 1) × ... × 3 × 2 × 1
	/// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
	/// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
	/// Find the sum of the digits in the number 100!
	/// </summary>
	public static class Question20
	{
		public static int FactorialDigitSum(int input)
		{
			return Enumerable.Range(1, input)
				.Select(x => (BigInteger) x)
				.Aggregate((x, y) => x * y)
				.Digits()
				.Sum();
		}
	}
}