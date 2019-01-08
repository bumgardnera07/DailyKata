//https://www.codewars.com/kata/585d7d5adb20cf33cb000235

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    var list = numbers.ToList();
    list.Sort();
    if (list[0] == list[1])
      return list.Last();
    else
      return list[0];
  }
}

//Test Cases

namespace Solution {
  using NUnit.Framework;
  using System;
  using System.Collections.Generic;

  [TestFixture]
  public class SolutionTest
  {
    [TestCase(new [] {1, 2, 2, 2}, ExpectedResult = 1)]
    [TestCase(new [] {-2, 2, 2, 2}, ExpectedResult = -2)]
    [TestCase(new [] {11, 11, 14, 11, 11}, ExpectedResult = 14)]
    public int BaseTest(IEnumerable<int> numbers)
    {
      return Kata.GetUnique(numbers);
    }
  }
}