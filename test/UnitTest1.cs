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
		}
	}
}