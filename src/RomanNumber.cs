using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	public class RomanNumber
	{
		public int Value { get; set; }

		public RomanNumber(int value)
		{
			this.Value = value;
		}

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
			roman = roman.Replace("-", "");
			roman = roman.Trim();

			if (string.IsNullOrEmpty(roman))
			{
				throw new ArgumentException("Input is null or empty");
			}

			ValidateNumber(roman);

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

			return new(lastDigitIndex == 0 ? result : -result);
		}

		private static bool ValidateNumber(string roman)
		{
			List<char> invalid = new List<char>();

			foreach (var number in roman)
			{
				if (!romanValues.Keys.Any((val) => val == number))
				{
					invalid.Add(number);
				}
			}

			if (invalid.Count > 0)
			{
				string invalidChars = string.Join(", ", invalid.Select(val => $"'{val}'").ToArray());
				throw new ArgumentException($"Invalid numbers found in input {invalidChars}");
			}

			return true;
		}

		public override string ToString()
		{
			if (this.Value == 0)
			{
				return "N";
			}

			if (this.Value < 0)
			{
				return "-" + ToRoman(-Value);
			}

			return ToRoman(Value);

		}

		private string ToRoman(int num)
		{
			string[] romanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
			int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

			string roman = "";
			int index = 0;

			while (num > 0)
			{
				if (num - values[index] >= 0)
				{
					roman += romanSymbols[index];
					num -= values[index];
				}
				else
				{
					index++;
				}
			}

			return roman;
		}
	}



}
