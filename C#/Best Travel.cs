//Description of the Problem: https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa

using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfK 
{
    public static int? chooseBestSum(int t, int k, List<int> ls) {
      int townCount = ls.Count;
      int[] totals = new int[BiCo(townCount,k)];
      int totalindex = 0;

      if (k > townCount || k <= 0 || townCount <= 0)   // check if input is valid;
        return null;

      var options = Combinations(k, townCount);        //possible combinations of indexes. See below
      
      foreach (int[] c in options)                     //calculate the sum for all possible combinations of distances. How can this be more efficient?
      {
        for (int i = 0; i < k; i++)
        {
          totals[totalindex] += ls.ToArray()[c[i]-1];
        }
        totalindex++;
      }
      Array.Sort(totals);          //backwards through the list of sums; find the first one that's short enough
      for (int i = totals.Length-1; i>=0; i--)
        if (totals[i] <= t) 
          return totals[i];
      return null;
    }
    
    /*This method returns all the possible combinations of m elements in a collection comprised of integers 1 through n as an enumerable collection of arrays.
    I will use this collection to return possible combinations of indexes to pass to the array of city distances.
    I can then store the sum of those addresses.
    REF: https://rosettacode.org/wiki/Combinations#C.23
    */
    
    private static IEnumerable<int[]> Combinations(int m, int n)
    {
            int[] result = new int[m];
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
 
            while (stack.Count > 0)
           {
                int index = stack.Count - 1;
                int value = stack.Pop();
 
                while (value < n) 
               {
                    result[index++] = ++value;
                    stack.Push(value);
 
                    if (index == m) 
                    {
                        yield return result;
                        break;
                    }
                }
            }
    }

    /* This method returns the Binomial Coefficient for m elements of collection n.
    This corresponds to the total possible combinations of m from n */
    
    private static int BiCo(int m, int n)
    {
      int result = 1;
      for (int i = 1; i <= n; i++)
      {
          result *= m - (n - i);
          result /= i;
      }
      return (int)result;
    }
}


//Test Cases

[TestFixture]
public class SumOfKTests {

[Test]
  public void Test1() {
    Console.WriteLine("****** Basic Tests");    
    List<int> ts = new List<int> {50, 55, 56, 57, 58};
    int? n = SumOfK.chooseBestSum(163, 3, ts);
    Assert.AreEqual(163, n);

    ts = new List<int> {50}; 
    n = SumOfK.chooseBestSum(163, 3, ts);
    Assert.AreEqual(null, n);   

    ts = new List<int> {91, 74, 73, 85, 73, 81, 87};
    n = SumOfK.chooseBestSum(230, 3, ts);
    Assert.AreEqual(228, n);
  }
}

