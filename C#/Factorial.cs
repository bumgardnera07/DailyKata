//https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc

using System;

public static class Kata
{
  public static int Factorial(int n)
  {
    if( n<0 || n>12)
    {
      throw new ArgumentOutOfRangeException();
    }
    int product = 1;
    for (; n>0;n--)
    {
        product *= n;
    }
    return product;
  }
}

//Test Cases

[TestFixture]
public class FactorialTests
{
  [Test]
  public void FactorialOf0ShouldBe1()
  {
    Assert.AreEqual(1, Kata.Factorial(0));
  }
  
  [Test]
  public void FactorialOf1ShouldBe1()
  {
    Assert.AreEqual(1, Kata.Factorial(1));
  }
  
  [Test]
  public void FactorialOf2ShouldBe2()
  {
    Assert.AreEqual(2, Kata.Factorial(2));
  }
  
  [Test]
  public void FactorialOf3ShouldBe6()
  {
    Assert.AreEqual(6, Kata.Factorial(3));
  }
}