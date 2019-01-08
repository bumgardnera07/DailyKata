//https://www.codewars.com/kata/5270d0d18625160ada0000e4

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    var arr =integers.ToList().Select(x => x % 2).ToArray();
    int result = -1;
    int evod = -1;
    Array.Sort(arr);
    if (arr[0] == arr[1])
      evod = 1;
    else
      evod = 0;
    result = integers.ToList().Where(x => x % 2 ==evod).ToArray()[0]; 
    return result;
  }
}

//Test Cases
public static class ScoreChecker
{
  [Test]
  public static void ShouldBeWorthless()
  {
    Assert.AreEqual(0, Kata.Score(new int[] {2, 3, 4, 6, 2}), "Should be 0 :-(");
  }
  
  [Test]
  public static void ShouldValueTriplets()
  {
    Assert.AreEqual(400, Kata.Score(new int[] {4, 4, 4, 3, 3}), "Should be 400");
  }
  
  [Test]
  public static void ShouldValueMixedSets()
  {
    Assert.AreEqual(450, Kata.Score(new int[] {2, 4, 4, 5, 4}), "Should be 450");
  }
}