//https://www.codewars.com/kata/57ea5b0b75ae11d1e800006c

using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static string[] SortByLength (string[] array)
  {
    return array.ToList().OrderBy(x => x.Length).ToArray();
  }
}

//Test Cases

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void ExampleTests()
    {
      Assert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, Kata.SortByLength(new string[] { "Beg", "Life", "I", "To" }));
      Assert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, Kata.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
      Assert.AreEqual(new string[] { "Short", "Longer", "Longest" }, Kata.SortByLength(new string[] { "Longer", "Longest", "Short" }));
    }
  }
}