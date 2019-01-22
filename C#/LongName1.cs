/* https://www.codewars.com/kata/they-say-that-only-the-name-is-long-enough-to-attract-attention-they-also-said-that-only-a-simple-kata-will-have-someone-to-solve-it-this-is-a-sadly-story-number-1-are-they-opposite/train/csharp/5c4681765a0b632ce0dfccf6

They say that only the name is long enough to attract attention. They also said that only a simple Kata will have someone to solve it series #1:
Are they opposite?

#Task
Give you two strings: s1 and s2. If they are opposite, return true; otherwise, return false. Note: The result should be a boolean value, instead of a string.

The opposite means: All letters of the two strings are the same, but the case is opposite. you can assume that the string only contains letters or it's a empty string. Also take note of the edge case - if both strings are empty then you should return false/False.

#Some examples:
isOpposite("ab","AB") should return true;
isOpposite("aB","Ab") should return true;
isOpposite("aBcd","AbCD") should return true;
isOpposite("AB","Ab") should return false;
isOpposite("","") should return false; */

using System;

public class Kata
{
  public static bool IsOpposite(string s1, string s2)
  {
    char[] strOp = s1.ToCharArray();
    if (String.IsNullOrEmpty(s1) || String.IsNullOrEmpty(s2))
      return false;
    for (int i =0; i < strOp.Length; i++ )
      {
        if (Char.IsLower(strOp[i]))
           strOp[i] = Char.ToUpper(strOp[i]);
        else
            strOp[i] = Char.ToLower(strOp[i]);
      }
    
    return s2.Equals(string.Join("",strOp));
  }
}

/*namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
      Assert.AreEqual(true, Kata.IsOpposite("ab","AB"), "ab, AB => true");
      Assert.AreEqual(true, Kata.IsOpposite("aB","Ab"), "aB, Ab => true");
      Assert.AreEqual(true, Kata.IsOpposite("aBcd","AbCD"), "aBcd, AbCD => true");
      Assert.AreEqual(false, Kata.IsOpposite("aBcde","AbCD"), "aBcde, AbCD => false");
      Assert.AreEqual(false, Kata.IsOpposite("AB","Ab"), "AB, Ab => false");
      Assert.AreEqual(false, Kata.IsOpposite("",""), "String.Empty, String.Empty => false");
    }
  }
} */