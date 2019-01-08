//https://www.codewars.com/kata/55c04b4cc56a697bb0000048

using System;
using System.Collections.Generic;
using System.Linq;
public class Scramblies 
{
    
    public static bool Scramble(string str1, string str2) 
    {
        if (str1.Length < str2.Length)
          return false;
        Dictionary<char, int> word = 
           new Dictionary<char, int>();
        char []sort1 =str1.ToCharArray();
        char []sort2 =str2.ToCharArray();
        Array.Sort(sort1);
        Array.Sort(sort2);
        if (sort1 == sort2)
          return true;
        else
          for (int i=0; i<sort1.Length; i++)
          {
            if (word.ContainsKey(sort1[i]))
              word[sort1[i]]++;
            else
              word.Add(sort1[i], 1);
          }
          for (int k=0; k<sort2.Length; k++)
          {
            if (!word.ContainsKey(sort2[k]))
              return false;
            else
              word[sort2[k]]--;
          }
          var negcheck = word.Values.ToList();
          negcheck.Sort();
          if (negcheck[0] <0)
            return false;
          else
             return true;
    }

}

//Test Cases

[TestFixture]
public static class ScrambliesTests 
{

    private static void testing(bool actual, bool expected) 
    {
        Assert.AreEqual(expected, actual);
    }

[Test]
    public static void test1() 
    {
        testing(Scramblies.Scramble("rkqodlw","world"), true);
        testing(Scramblies.Scramble("cedewaraaossoqqyt","codewars"),true);
        testing(Scramblies.Scramble("katas","steak"),false);
        testing(Scramblies.Scramble("scriptjavx","javascript"),false);
        testing(Scramblies.Scramble("scriptingjava","javascript"),true);
        testing(Scramblies.Scramble("scriptsjava","javascripts"),true);
        testing(Scramblies.Scramble("javscripts","javascript"),false);
        testing(Scramblies.Scramble("aabbcamaomsccdd","commas"),true);
        testing(Scramblies.Scramble("commas","commas"),true);
        testing(Scramblies.Scramble("sammoc","commas"),true);
    }
}
