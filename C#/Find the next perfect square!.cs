//https://www.codewars.com/kata/56269eb78ad2e4ced1000013

using System;

public class Kata
{
  public static long FindNextSquare(long num)
  {
    if (Math.Sqrt(num) == (int)Math.Sqrt(num))
    {
    return Convert.ToInt64((Math.Sqrt(num) +1)*(Math.Sqrt(num) +1));
    }
    else return -1;
  }
}

//Test Cases

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(155, ExpectedResult=-1)]
  [TestCase(121, ExpectedResult=144)]
  [TestCase(625, ExpectedResult=676)]
  [TestCase(319225, ExpectedResult=320356)]
  [TestCase(15241383936, ExpectedResult=15241630849)]
  public static long FixedTest(long num)
  {
    return Kata.FindNextSquare(num);
  }
}