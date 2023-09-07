using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	public class RomanNumber
	{
		public int Value { get; set; }

		private static Dictionary<char, int> romanValues = new Dictionary<char, int>
		{
			{ 'I', 1 },
			{ 'V', 5 },
			{ 'X', 10 },
			{ 'L', 50 },
			{ 'C', 100 },
			{ 'D', 500 },
			{ 'M', 1000 }
		};

		public static RomanNumber Parse(string roman)
		{
			if (String.IsNullOrEmpty(roman))
			{
				throw new ArgumentException("Roman number is null or Empty");
			}

			int result = 0;
			int prev = 0;
			int lastDigitIndex = roman.StartsWith("-") ? 1 : 0;
			
			roman = roman.Trim();

			for (int i = roman.Length - 1; i >= 0; i--)
			{

				if (!romanValues.Keys.Any((key) => key == roman[i]))
				{
					throw new ArgumentException($"'{roman[i]}' is an invalid symbol");
				}

				int current = romanValues[roman[i]];

				if (current < prev)
				{
					result -= current;
				}
				else
				{
					result += current;
				}

				prev = current;
			}

			return new()
			{
				Value = lastDigitIndex == 0 ? result : -result
			};
		}

	}
}
