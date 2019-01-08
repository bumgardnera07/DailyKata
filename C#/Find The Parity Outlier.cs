//https://www.codewars.com/kata/5526fc09a1bbd946250002dc

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    int result = -1;
    int evod = -1;
    var arr =integers.Take(3).Select(x => x % 2).ToArray();
    Array.Sort(arr);
    if (arr[0] == arr[1])
      evod = 1;
    else
      evod = 0;
    foreach(int i in integers)
    {
      if (i % 2 == evod)
        result = i;
    }

    // result = integers.ToList().Where(x => x % 2 ==evod).ToArray()[0];
    // Linq Query is a little easier to read here, but much slower for large data sets.
    return result;
  }
}

//Test Cases

[TestFixture]
public class Tests
{
  [Test]
  public static void Test1()
  {
    int[] exampleTest1 = {2,6,8,-10,3}; 
    Assert.IsTrue(3 == Kata.Find(exampleTest1));
  }
  
  [Test]
  public static void Test2()
  {  
    int[] exampleTest2 = {206847684,1056521,7,17,1901,21104421,7,1,35521,1,7781};
    Assert.IsTrue(206847684 == Kata.Find(exampleTest2));
  }
  
  [Test]
  public static void Test3()
  {
    int[] exampleTest3 = { int.MaxValue, 0, 1 };
    Assert.IsTrue(0 == Kata.Find(exampleTest3));
  }
}