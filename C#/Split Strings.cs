//https://www.codewars.com/kata/515de9ae9dcfc28eb6000001

using System;
using System.Text.RegularExpressions;
public class SplitString
{

public static string CharCombine(char c0, char c1)
    {
        char[] chars = new char[2];
        chars[0] = c0;
        chars[1] = c1;
        return new string(chars);
    }
    
public static string[] Solution(string str)
  {
    if (str.Length % 2 == 1)
      str+="_";
    string[] strout = new string[str.Length/2];
    for (int i=0; i<strout.Length;i++)
    {
      strout[i] = CharCombine(str[2*i], (str[2*i+1]));
    }
    return strout;
  }
}

//Test Cases

namespace Solution 
{
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class SplitStringTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual(new string[] { "ab", "c_" }, SplitString.Solution("abc"));
      Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
    }
  }
}