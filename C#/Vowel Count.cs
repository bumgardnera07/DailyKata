//https://www.codewars.com/kata/54ff3102c1bad923760001f3

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        string word = str.ToUpper();
        string[] vowels = {"A","E","I","O","U"};
        for (int v=0; v < vowels.Length; v++) { for (int w=0; w < word.Length; w++) {if (vowels[v] == word[w].ToString()) {vowelCount++;}}}
        return vowelCount;
    }
}

//Test Cases

[TestFixture]
public class KataTests
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
    }
}
