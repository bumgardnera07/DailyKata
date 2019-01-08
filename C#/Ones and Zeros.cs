//https://www.codewars.com/kata/578553c3a1b8d5c40300037c

namespace Solution
{
using System;
using System.Linq;
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          int[] numArray = BinaryArray;
          for (int i = 0; i < numArray.Length; i++) {
              if (BinaryArray[i] == 1) {numArray[i] = Convert.ToInt32(Math.Pow(2,(numArray.Length-(i+1))));} 
          }
          int result = numArray.Sum();
          return result;
        }
    }
}

//Test Cases

namespace Solution {
  using NUnit.Framework;
  using System;
  [TestFixture]
  public class SolutionTest
  {
    int[] Test1 = new int[] {0,0,0,0};
    int[] Test2 = new int[] {1,1,1,1};
    int[] Test3 = new int[] {0,1,1,0};
    int[] Test4 = new int[] {0,1,0,1};
    [Test]
    public void BasicTesting()
    {
      Assert.AreEqual(0 , Kata.binaryArrayToNumber(Test1));
      Assert.AreEqual(15 , Kata.binaryArrayToNumber(Test2));
      Assert.AreEqual(6 , Kata.binaryArrayToNumber(Test3));
      Assert.AreEqual(5 , Kata.binaryArrayToNumber(Test4));
    }
  }
}