//https://www.codewars.com/kata/52f3149496de55aded000410

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int SumDigits(int number)
  {
    var numList = new Stack<int>();
    int posnum = Math.Abs(number);
    
    for(;posnum > 0; posnum /= 10)
        numList.Push(posnum % 10);
    
    return numList.ToArray().Sum();
  }
}

//Test Cases

namespace Solution 
{
  using NUnit.Framework;
  using System;
  using System.Collections.Generic;

  [TestFixture]
  public class Fixed_Tests
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData(10).Returns(1);
        yield return new TestCaseData(99).Returns(18);
        yield return new TestCaseData(-32).Returns(5);
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public int FixedTest(int number) => Kata.SumDigits(number);
  }
}