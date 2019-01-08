//https://www.codewars.com/kata/5663f5305102699bad000056

using System;
using System.Linq;
using System.Collections.Generic;

public class MaxDiffLength 
{
    
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        int max = 0;
        if (a1.Length == 0 || a2.Length == 0)
        {
           return -1;
        }
        else
        {
        List<string> aLengths = a1.OrderBy(x => x.Length).ToList();
        List<string> bLengths = a2.OrderBy(x => x.Length).ToList();
        if (Math.Abs(aLengths[0].Length - bLengths.Last().Length) > Math.Abs(bLengths[0].Length - aLengths.Last().Length))
        {
          max = Math.Abs(aLengths[0].Length - bLengths.Last().Length);  
        }
        else
        {
          max = Math.Abs(bLengths[0].Length - aLengths.Last().Length);
        }
        return max;
        }
    }
}

//Test Cases

[TestFixture]
public static class MaxDiffLengthTests {

[Test]
    public static void test1() 
    {
        string[] s1 = new string[]{"hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"};
        string[] s2 = new string[]{"cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"};
        Assert.AreEqual(13, MaxDiffLength.Mxdiflg(s1, s2));
    }
}
