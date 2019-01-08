//https://www.codewars.com/kata/55225023e1be1ec8bc000390

using System;

public static class Kata
{
  public static string greet(string name)
  {

    if(name == "Johnny")
      return "Hello, my love!";
    return "Hello, " + name + "!";
  }
}

//Test Cases

[TestFixture]
public class JennysGreeting
{
  [Test]
  public static void ShouldGreetJimNormally()
  {
    Assert.AreEqual("Hello, Jim!", Kata.greet("Jim"));
  }
  [Test]
  public static void ShouldGreetJaneNormally()
  {
    Assert.AreEqual("Hello, Jane!", Kata.greet("Jane"));
  }
  [Test]
  public static void ShouldGreetSimonNormally()
  {
    Assert.AreEqual("Hello, Simon!", Kata.greet("Simon"));
  }
  
  [Test]
  public static void ShouldGreetJohnnySpecially()
  {
    Assert.AreEqual("Hello, my love!", Kata.greet("Johnny"));
  }
}