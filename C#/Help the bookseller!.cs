//https://www.codewars.com/kata/54dc6f5a224c26032800005c

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


public class StockList {

    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter) {
        if (lstOfArt.Length ==0 || lstOf1stLetter.Length ==0)
          return "";
        
        var ltrCount = new Dictionary<char, int>();
        string[] lstCount = (lstOfArt.Select(x => Regex.Match(x, @"\d+").Value)).ToArray();
        
        for (int i = 0; i<lstOf1stLetter.Length; i++)
        {
              ltrCount.Add(lstOf1stLetter[i][0], 0);
        }
        
        for (int k=0; k<lstOfArt.Length; k++)
        {
              if (ltrCount.ContainsKey(lstOfArt[k][0]))
                ltrCount[lstOfArt[k][0]] += Convert.ToInt32(lstCount[k]);
        }
        string[] counts = (ltrCount.Select(kvp => "(" + kvp.Key + " : " + kvp.Value.ToString() + ")")).ToArray();
        return string.Join(" - ", counts);
    }
}

//Test Cases

[TestFixture]
public class StockListTests {

[Test]
  public void Test1() {
    string[] art = new string[] {"ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600"};
    String[] cd = new String[] {"A", "B"};
    Assert.AreEqual("(A : 200) - (B : 1140)", StockList.stockSummary(art, cd));
  }
}

