using System;
using System.Linq;

namespace EulerSolutions
{
	internal class NumberPrettyPrinter
	{
		public string PrettyPrint(int input)
		{
			if (input < 1) throw new ArgumentOutOfRangeException(nameof(input));
			
			if (input < 20) return LessThan20(input);
			if (input < 100) return LessThan100(input);
			if (input < 1000) return LessThan1000(input);
			if (input == 1000) return "one thousand";

			throw new ArgumentOutOfRangeException(nameof(input), "Input must be between 1 and 1000");
		}

		private string LessThan1000(int input)
		{
			var digits = ((long) input).Digits().ToArray();
			var last2Digits = digits.Reverse().Take(2).Reverse().ToArray();

			if (last2Digits[0] == 0 && last2Digits[1] == 0)
				return $"{LessThan20(digits[0])} hundred"; 
			
			var last2DigitsString = LessThan100(last2Digits[0] * 10 + last2Digits[1]);
			return $"{LessThan20(digits[0])} hundred and {last2DigitsString}";
		}
		
		private string LessThan100(int input)
		{
			if (input < 20) return LessThan20(input);
			
			var digits = ((long) input).Digits().ToArray();

			if (digits[1] == 0) return MultipleOfTen(digits[0]);
			
			return MultipleOfTen(digits[0]) + " " + LessThan20(digits[1]);
		}
		
		private string MultipleOfTen(int input)
		{
			switch (input)
			{
				case 1: return "ten";
				case 2: return "twenty";
				case 3: return "thirty";
				case 4: return "forty";
				case 5: return "fifty";
				case 6: return "sixty";
				case 7: return "seventy";
				case 8: return "eighty";
				case 9: return "ninety";
				default: throw new ArgumentOutOfRangeException(nameof(input));
			}
		}

		private string LessThan20(int input)
		{
			switch (input)
			{
				case 1: return "one";
				case 2: return "two";
				case 3: return "three";
				case 4: return "four";
				case 5: return "five";
				case 6: return "six";
				case 7: return "seven";
				case 8: return "eight";
				case 9: return "nine";
				case 10: return "ten";
				case 11: return "eleven";
				case 12: return "twelve";
				case 13: return "thirteen";
				case 14: return "fourteen";
				case 15: return "fifteen";
				case 16: return "sixteen";
				case 17: return "seventeen";
				case 18: return "eighteen";
				case 19: return "nineteen";
				default: throw new ArgumentOutOfRangeException(nameof(input));
			}
		}
	}
}