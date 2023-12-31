
using System.Runtime.Intrinsics.X86;

namespace Tests
{
	[TestClass]
	public class RomanNumbersTest
	{
		[TestMethod]
		public void TestRomanNumberParse()
		{
			Assert.AreEqual(1, RomanNumber.Parse("I").Value);
			Assert.AreEqual(2, RomanNumber.Parse("II").Value);
			Assert.AreEqual(3, RomanNumber.Parse("III").Value);
			Assert.AreEqual(4, RomanNumber.Parse("IV").Value);
			Assert.AreEqual(5, RomanNumber.Parse("V").Value);
			Assert.AreEqual(6, RomanNumber.Parse("VI").Value);
			Assert.AreEqual(7, RomanNumber.Parse("VII").Value);
			Assert.AreEqual(8, RomanNumber.Parse("VIII").Value);
			Assert.AreEqual(9, RomanNumber.Parse("IX").Value);
			Assert.AreEqual(10, RomanNumber.Parse("X").Value);
			Assert.AreEqual(11, RomanNumber.Parse("XI").Value);
			Assert.AreEqual(12, RomanNumber.Parse("XII").Value);
			Assert.AreEqual(13, RomanNumber.Parse("XIII").Value);
			Assert.AreEqual(14, RomanNumber.Parse("XIV").Value);
			Assert.AreEqual(15, RomanNumber.Parse("XV").Value);
			Assert.AreEqual(16, RomanNumber.Parse("XVI").Value);
			Assert.AreEqual(17, RomanNumber.Parse("XVII").Value);
			Assert.AreEqual(18, RomanNumber.Parse("XVIII").Value);
			Assert.AreEqual(19, RomanNumber.Parse("XIX").Value);
			Assert.AreEqual(20, RomanNumber.Parse("XX").Value);
			Assert.AreEqual(21, RomanNumber.Parse("XXI").Value);
			Assert.AreEqual(22, RomanNumber.Parse("XXII").Value);
			Assert.AreEqual(23, RomanNumber.Parse("XXIII").Value);
			Assert.AreEqual(24, RomanNumber.Parse("XXIV").Value);
			Assert.AreEqual(25, RomanNumber.Parse("XXV").Value);
			Assert.AreEqual(26, RomanNumber.Parse("XXVI").Value);
			Assert.AreEqual(27, RomanNumber.Parse("XXVII").Value);
			Assert.AreEqual(28, RomanNumber.Parse("XXVIII").Value);
			Assert.AreEqual(29, RomanNumber.Parse("XXIX").Value);
			Assert.AreEqual(30, RomanNumber.Parse("XXX").Value);
			Assert.AreEqual(31, RomanNumber.Parse("XXXI").Value);
			Assert.AreEqual(32, RomanNumber.Parse("XXXII").Value);
			Assert.AreEqual(33, RomanNumber.Parse("XXXIII").Value);
			Assert.AreEqual(34, RomanNumber.Parse("XXXIV").Value);
			Assert.AreEqual(35, RomanNumber.Parse("XXXV").Value);
			Assert.AreEqual(36, RomanNumber.Parse("XXXVI").Value);
			Assert.AreEqual(37, RomanNumber.Parse("XXXVII").Value);
			Assert.AreEqual(38, RomanNumber.Parse("XXXVIII").Value);
			Assert.AreEqual(39, RomanNumber.Parse("XXXIX").Value);
			Assert.AreEqual(40, RomanNumber.Parse("XL").Value);
			Assert.AreEqual(41, RomanNumber.Parse("XLI").Value);
			Assert.AreEqual(42, RomanNumber.Parse("XLII").Value);
			Assert.AreEqual(43, RomanNumber.Parse("XLIII").Value);
			Assert.AreEqual(44, RomanNumber.Parse("XLIV").Value);
			Assert.AreEqual(45, RomanNumber.Parse("XLV").Value);
			Assert.AreEqual(46, RomanNumber.Parse("XLVI").Value);
			Assert.AreEqual(47, RomanNumber.Parse("XLVII").Value);
			Assert.AreEqual(48, RomanNumber.Parse("XLVIII").Value);
			Assert.AreEqual(49, RomanNumber.Parse("XLIX").Value);
			Assert.AreEqual(50, RomanNumber.Parse("L").Value);
			Assert.AreEqual(51, RomanNumber.Parse("LI").Value);
			Assert.AreEqual(52, RomanNumber.Parse("LII").Value);
			Assert.AreEqual(53, RomanNumber.Parse("LIII").Value);
			Assert.AreEqual(54, RomanNumber.Parse("LIV").Value);
			Assert.AreEqual(55, RomanNumber.Parse("LV").Value);
			Assert.AreEqual(56, RomanNumber.Parse("LVI").Value);
			Assert.AreEqual(57, RomanNumber.Parse("LVII").Value);
			Assert.AreEqual(58, RomanNumber.Parse("LVIII").Value);
			Assert.AreEqual(59, RomanNumber.Parse("LIX").Value);
			Assert.AreEqual(60, RomanNumber.Parse("LX").Value);
			Assert.AreEqual(61, RomanNumber.Parse("LXI").Value);
			Assert.AreEqual(62, RomanNumber.Parse("LXII").Value);
			Assert.AreEqual(63, RomanNumber.Parse("LXIII").Value);
			Assert.AreEqual(64, RomanNumber.Parse("LXIV").Value);
			Assert.AreEqual(65, RomanNumber.Parse("LXV").Value);
			Assert.AreEqual(66, RomanNumber.Parse("LXVI").Value);
			Assert.AreEqual(67, RomanNumber.Parse("LXVII").Value);
			Assert.AreEqual(68, RomanNumber.Parse("LXVIII").Value);
			Assert.AreEqual(69, RomanNumber.Parse("LXIX").Value);
			Assert.AreEqual(70, RomanNumber.Parse("LXX").Value);
			Assert.AreEqual(71, RomanNumber.Parse("LXXI").Value);
			Assert.AreEqual(72, RomanNumber.Parse("LXXII").Value);
			Assert.AreEqual(73, RomanNumber.Parse("LXXIII").Value);
			Assert.AreEqual(74, RomanNumber.Parse("LXXIV").Value);
			Assert.AreEqual(75, RomanNumber.Parse("LXXV").Value);
			Assert.AreEqual(76, RomanNumber.Parse("LXXVI").Value);
			Assert.AreEqual(77, RomanNumber.Parse("LXXVII").Value);
			Assert.AreEqual(78, RomanNumber.Parse("LXXVIII").Value);
			Assert.AreEqual(79, RomanNumber.Parse("LXXIX").Value);
			Assert.AreEqual(80, RomanNumber.Parse("LXXX").Value);
			Assert.AreEqual(81, RomanNumber.Parse("LXXXI").Value);
			Assert.AreEqual(82, RomanNumber.Parse("LXXXII").Value);
			Assert.AreEqual(83, RomanNumber.Parse("LXXXIII").Value);
			Assert.AreEqual(84, RomanNumber.Parse("LXXXIV").Value);
			Assert.AreEqual(85, RomanNumber.Parse("LXXXV").Value);
			Assert.AreEqual(86, RomanNumber.Parse("LXXXVI").Value);
			Assert.AreEqual(87, RomanNumber.Parse("LXXXVII").Value);
			Assert.AreEqual(88, RomanNumber.Parse("LXXXVIII").Value);
			Assert.AreEqual(89, RomanNumber.Parse("LXXXIX").Value);
			Assert.AreEqual(90, RomanNumber.Parse("XC").Value);
			Assert.AreEqual(91, RomanNumber.Parse("XCI").Value);
			Assert.AreEqual(92, RomanNumber.Parse("XCII").Value);
			Assert.AreEqual(93, RomanNumber.Parse("XCIII").Value);
			Assert.AreEqual(94, RomanNumber.Parse("XCIV").Value);
			Assert.AreEqual(95, RomanNumber.Parse("XCV").Value);
			Assert.AreEqual(96, RomanNumber.Parse("XCVI").Value);
			Assert.AreEqual(97, RomanNumber.Parse("XCVII").Value);
			Assert.AreEqual(98, RomanNumber.Parse("XCVIII").Value);
			Assert.AreEqual(99, RomanNumber.Parse("XCIX").Value);
			Assert.AreEqual(100, RomanNumber.Parse("C").Value);
		}

		[TestMethod]
		public void TestRomanNumberInvalid()
		{
			Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse(null!), "() => RomanNumber.Parse(null!)");
			var ex = Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse(""), "() => RomanNumber.Parse(\"\")");

			Assert.IsFalse(String.IsNullOrEmpty(ex.Message), "Exception message is null or empty");


			var testCases = new Dictionary<string, string>()
			{
				{"XA","A" },
				{"G","G" },
				{"#","#" },
				{"$","$" },
				{"F","F" },
				{"%","%" },
				{"T","T" },
				{"@","@" },
				{"IVX","IVX" },
				{"VIX","VIX" },
				{"IIIX","IIIX" },
				{"VVIX","VVIX" },
				{"IIIC","IIIC" },
				{"IIDC","IIDC" },
			};

			foreach (var testCase in testCases)
			{
				ex = Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse(testCase.Key), $"Roman number parse {testCase.Key} -> Exception");

				Assert.IsTrue(ex.Message.Contains($"'{testCase.Value}'"), $"{testCase.Value} expected in message: {ex.Message}");
			}

		}

		[TestMethod]
		public void TestRomanNumberDubious()
		{
			string[] dubious = { "IIX", "VVX", "IVX", "VIX", "IIIX", "VVIX" };

			foreach (var dub in dubious)
			{
				Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse(dub), $"{dub} cause exception");
			}
		}

		[TestMethod]
		public void TestParseInvalid()
		{
			Dictionary<String, char[]> testCases2 = new()
			{
				{ "12XC",  new[] { '1', '2' } },
				{ "XC12",  new[] { '1', '2' } },
				{ "123XC", new[] { '1', '2', '3' } },
				{ "321X",  new[] { '3', '2', '1' } },
				{ "3V2C1X",  new[] { '3', '2', '1' } },
			};

			foreach (var pair in testCases2)
			{
				var ex = Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse(pair.Key));
				foreach (char c in pair.Value)
				{
					Assert.IsTrue(ex.Message.Contains($"'{c}'"), $"Roman number parse ({pair.Key}): ex.Message contains '{c}'");
				}
			}
		}

		[TestMethod]
		public void TestToString()
		{
			Dictionary<int, string> testCases = new()
			{
				{0,"N"},
				{1, "I"},
				{2, "II"},
				{3, "III"},
				{4, "IV"},
				{ -45, "-XLV"},
				{-95,  "-XCV"},
				{-285, "-CCLXXXV"},
			};


			foreach (var testCase in testCases)
			{
				var roman = new RomanNumber(testCase.Key);
				Assert.AreEqual(roman.ToString(), testCase.Value, $"{roman} != {testCase.Value}");
			}

			var rnd = new Random();

			for (int i = 0; i < 10; i++)
			{
				int testCase = rnd.Next(500);
				var roman = new RomanNumber(testCase);
				Assert.IsNotNull(testCase);
				var parsedRoman = RomanNumber.Parse(roman.ToString()).Value;
				Assert.AreEqual(testCase, parsedRoman, $"{testCase} != {parsedRoman}");
			}
		}

		[TestMethod]
		public void TestMinus()
		{
			Assert.AreEqual(RomanNumber.Parse("-II").Value, -2);

			var r1 = new RomanNumber(-6);
			var r2 = new RomanNumber(-4);

			Assert.AreEqual(r1.Minus(r2).ToString(), "-II");

		}

		[TestMethod]
		public void TestSum()
		{
			RomanNumber r1 = new(10);
			RomanNumber r2 = new(10);
			RomanNumber r3 = new(10);
			RomanNumber r4 = new(10);

			var sum = RomanNumber.Sum(r1, r2, r3, r4);

			Assert.IsInstanceOfType(sum, typeof(RomanNumber));
			Assert.AreEqual(40, sum.Value);
			Assert.AreEqual(0, RomanNumber.Sum().Value);

			Assert.AreEqual(RomanNumber.Sum(null, null, null), null);
			Assert.AreEqual(RomanNumber.Sum([null, null, null]), null);
		}

		[TestMethod]
		public void TestEval()
		{
			var rNull = RomanNumber.Eval("");
			Assert.AreEqual(rNull, null);

			var r1 = RomanNumber.Eval("III + II");
			Assert.IsInstanceOfType(r1, typeof(RomanNumber));
			Assert.AreEqual(r1.Value, 5);

			var random = new Random();

			for (int i = 0; i < 100; i++)
			{

				var operand1 = random.Next(-3000, 3000);
				var operand2 = random.Next(-3000, 3000);

				var rom1 = new RomanNumber(operand1);
				var rom2 = new RomanNumber(operand2);

				var evaluatedPlus = RomanNumber.Eval(rom1.ToString() + " + " + rom2.ToString());
				var evaluatedMinus = RomanNumber.Eval(rom1.ToString() + " - " + rom2.ToString());

				Assert.AreEqual(operand1 + operand2, evaluatedPlus.Value, $"{i} Operands: {operand1} + {operand2}");
				Assert.AreEqual(operand1 - operand2, evaluatedMinus.Value, $"{i} Operands: {operand1} + {operand2}");

			}

			Assert.AreEqual(-3, RomanNumber.Eval("-III").Value);
			Assert.AreEqual(-4, RomanNumber.Eval("-IV").Value);
			Assert.AreEqual(-10, RomanNumber.Eval("-X").Value);
			Assert.AreEqual(0, RomanNumber.Eval("N").Value);
			Assert.AreEqual(0, RomanNumber.Eval("N+N").Value);
			Assert.AreEqual(0, RomanNumber.Eval("N-N").Value);
			Assert.AreEqual(1, RomanNumber.Eval("I-N").Value);

		}
	}
}