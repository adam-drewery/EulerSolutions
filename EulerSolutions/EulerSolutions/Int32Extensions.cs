using System;

namespace EulerSolutions
{
	public static class Int32Extensions
	{
		private static readonly NumberPrettyPrinter NumberPrettyPrinter = new NumberPrettyPrinter();

		public static string ToPrettyString(this int input)
		{
			// Obviously not going to work for any number
			try
			{
				return NumberPrettyPrinter.PrettyPrint(input);
			}
			catch (ArgumentOutOfRangeException e)
			{
				throw new ArgumentOutOfRangeException(nameof(input), "Couldn't pretty-print " + input);
			}
		}
	}
}