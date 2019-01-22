# https://www.codewars.com/kata/reflection-number-2-give-me-all-methods/train/csharp/5c4727213dd41b1b121ca60a

/* You get an object and should return the names of all(!) methods, that you found for the object.

The code of this object:

using System;

public class Refl 
{
  static void Main(string[] args) 
  { 
    Console.WriteLine(new Refl().Output());
    Console.WriteLine(new Refl().AddInts(1,2));
  } 

  public string Output()
  {
    return "Test-Output";
  }

  public int AddInts[n](int i1, int i2) 
  {
    return i1 + i2;
  }
}
For using random, the Name of the AddInts-Methods has an additonal number at the end. For null return an empty string array! */

using System;
using System.Reflection;
using System.Reflection.Emit;

public static class Reflection
{
  public static string[] GetMethodNames(object TestObject)
  { 
    if (TestObject == null)
      return new string[0];
      
    Type testObjectType = TestObject.GetType();
    MethodInfo[] testObjectMethodInfo = testObjectType.GetMethods(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Static|BindingFlags.Instance);
    string[] output = new string[testObjectMethodInfo.Length];
    
    for (int i = 0; i < testObjectMethodInfo.Length; i++)
      output[i] = testObjectMethodInfo[i].Name;
    return output;
  }
}

/*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class ReflectionTests
{
  [Test]
  public void NullTest()
  {
    Assert.AreEqual(0, Reflection.GetMethodNames(null).Length);
  }
  
  [Test]
  public void NewObjectTest()
  { 
    var testObject = new object();
    var methodNameArray = Reflection.GetMethodNames(testObject);
    Assert.IsTrue(methodNameArray.Contains("ToString"));    
  }
}

*/