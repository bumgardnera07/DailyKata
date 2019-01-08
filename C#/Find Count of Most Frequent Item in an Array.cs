//https://www.codewars.com/kata/56582133c932d8239900002e

using System.Collections.Generic;

public class Kata
{
  public static int MostFrequentItemCount(int[] collection)
  {
    var solSet = new Dictionary<int, int>();
    int max = 0;
    foreach (int number in collection)
    {
      if (solSet.ContainsKey(number))
      {
        solSet[number]++;
      }
      else
      {
        solSet.Add(number, 1);
      }
      if (solSet[number] > max)
      {
        max = solSet[number];
      }
    }
    return max;
  }
}

//Test Cases

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    
    private static object[] Basic_Test_Cases = new object[]
    {
      new object[] {new int[] {3, -1, -1}, 2},
      new object[] {new int[] {3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3}, 5},
    };
  
    [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
    public void Basic_Test(int[] test, int expected)
    {
      Assert.AreEqual(expected, Kata.MostFrequentItemCount(test));
    }
    
    // Note: Random tests output total user code execution time
  }
}