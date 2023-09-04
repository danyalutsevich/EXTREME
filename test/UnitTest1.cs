using App;

namespace testProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestRomanNumberParse()
		{
			Assert.AreEqual(1, RomanNumber.Parse("I").Value);
			Assert.AreEqual(2, RomanNumber.Parse("II").Value);
			Assert.AreEqual(3, RomanNumber.Parse("III").Value);
			Assert.AreEqual(4, RomanNumber.Parse("IV").Value);
		}
	}
}