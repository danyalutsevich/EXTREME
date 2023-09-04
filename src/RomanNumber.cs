using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
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
			int result = 0;
			int prevValue = 0;

			for (int i = roman.Length - 1; i >= 0; i--)
			{
				int currentValue = romanValues[roman[i]];

				if (currentValue < prevValue)
				{
					result -= currentValue;
				}
				else
				{
					result += currentValue;
				}

				prevValue = currentValue;
			}

			return new()
			{
				Value=result
			};
		}

	}
}
