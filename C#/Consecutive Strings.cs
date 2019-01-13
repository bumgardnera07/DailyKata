//https://www.codewars.com/kata/56a5d994ac971f1ac500003e

using System;
using System.Collections;

public class LongestConsecutives 
{
    
    public static String LongestConsec(string[] strarr, int k) 
    {
        ArrayList stringsets = new ArrayList();
        stringsets.AddRange(strarr); 
        string Maxstring = "";
        
        if (strarr.Length==0 || strarr.Length < k || k < 0)
          return "";
        else
          for (int i = 0; i <= (strarr.Length-k); i++)
          {
            string check = string.Join("",stringsets.GetRange(i,k).ToArray());
            if (check.Length > Maxstring.Length)
            {
               Maxstring = check;
            }
          }
        return Maxstring;
    }
}

//Test Cases

[TestFixture]
public static class LongestConsecutivesTests 
{
    private static void testing(string actual, string expected) 
    {
        Assert.AreEqual(expected, actual);
    }
[Test]
    public static void test1() 
    {        
        Console.WriteLine("Basic Tests");
        testing(LongestConsecutives.LongestConsec(new String[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}, 2), "abigailtheta");
        testing(LongestConsecutives.LongestConsec(new String[] {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"}, 1), "oocccffuucccjjjkkkjyyyeehh");
        testing(LongestConsecutives.LongestConsec(new String[] {}, 3), "");
        testing(LongestConsecutives.LongestConsec(new String[] {"itvayloxrp","wkppqsztdkmvcuwvereiupccauycnjutlv","vweqilsfytihvrzlaodfixoyxvyuyvgpck"}, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
        testing(LongestConsecutives.LongestConsec(new String[] {"wlwsasphmxx","owiaxujylentrklctozmymu","wpgozvxxiu"}, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
        testing(LongestConsecutives.LongestConsec(new String[] {"zone", "abigail", "theta", "form", "libe", "zas"}, -2), "");
        testing(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 3), "ixoyx3452zzzzzzzzzzzz");
        testing(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 15), "");
        testing(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 0), "");
    }
}
