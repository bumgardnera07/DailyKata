//https://www.codewars.com/kata/546f922b54af40e1e90001da

using System.Text.RegularExpressions;
using System;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    string alphastring = Regex.Replace(text.ToUpper(), @"[^A-Z]", "");
    string alpharray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string[] resultarray = new string[alphastring.Length];
    for (int i = 0; i<alphastring.Length; i++)
    {
      resultarray[i] = (alpharray.IndexOf(alphastring[i])+1).ToString(); 
    }
    return String.Join(" ", resultarray);
  }
}

//Test Cases

namespace Solution 
{
  using NUnit.Framework;
  using System;
  
  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
      Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Kata.AlphabetPosition("The narwhal bacons at midnight."));
    }
  }
}