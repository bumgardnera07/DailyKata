/*https://www.codewars.com/kata/plus-1-array/train/csharp/5c524559ab3c5177739cca22

Given an array of integers of any length, return an array that has 1 added to the value represented by the array.

the array can't be empty
only non-negative, single digit integers are allowed
Return nil (or your language's equivalent) for invalid inputs.

Examples
For example the array [2, 3, 9] equals 239, adding one would return the array [2, 4, 0].

[4, 3, 2, 5] would return [4, 3, 2, 6]

*/


using System;

namespace Kata
{
  public static class Kata
  {
    public static int[] UpArray(int[] num)
		{
      if ((num == null || num.Length == 0)) return null;
      int[] result = new int[num.Length];
      bool added = false;
      for (int i = num.Length-1; i >=0; i--)
      {
        if (0 > num[i] || num[i] > 9)
          return null;
        else if (added == false) {
          if (num[i] == 9){
             result[i] = 0;
             if (i == 0) {
               int[] bigresult = new int[num.Length+1];
               bigresult[0] = 1;
               Array.Copy(result, 0, bigresult, 1, num.Length);
               return bigresult; 
             }
          }
          else {
            result[i] = num[i]++;
            added = true;
            i++;
          }
        }
        else 
          result[i] = num[i];
      }
      return result;
		}
  }
}

/*
using NUnit.Framework;
using System;

namespace Kata 
{  
  [TestFixture]
  public class ArrayTest
  {
    [Test]
    public void Test1()
    {
      var num = new int[] {2, 3, 9};
      var newNum = new int[] {2, 4, 0};
      Assert.AreEqual(newNum, Kata.UpArray(num));
    }
    
    [Test]
    public void Test2()
    {
      var num = new int[] {4, 3, 2, 5};
      var newNum = new int[] {4, 3, 2, 6};
      Assert.AreEqual(newNum, Kata.UpArray(num));
    }
  }
}

*/