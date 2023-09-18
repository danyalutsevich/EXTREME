// See https://aka.ms/new-console-template for more information
using Code;


Console.WriteLine(RomanNumber.Parse("-MMDCXC"));
Console.WriteLine(RomanNumber.Parse("LVIII"));
var roman = new RomanNumber(-4);
Console.WriteLine(roman.ToString());
