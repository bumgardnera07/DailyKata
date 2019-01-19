/* You have a positive number n consisting of digits. You can do at most one operation: Choosing the index of a digit in the number, remove this digit at that index and insert it back to another place in the number.

Doing so, find the smallest number you can get.

#Task: Return an array or a tuple or a string depending on the language (see "Sample Tests") with

1) the smallest number you got
2) the index i of the digit d you took, i as small as possible
3) the index j (as small as possible) where you insert this digit d to have the smallest number.
Example:

smallest(261235) --> [126235, 2, 0] or (126235, 2, 0) or "126235, 2, 0"
126235 is the smallest number gotten by taking 1 at index 2 and putting it at index 0

smallest(209917) --> [29917, 0, 1] or ...

[29917, 1, 0] could be a solution too but index `i` in [29917, 1, 0] is greater than 
index `i` in [29917, 0, 1].
29917 is the smallest number gotten by taking 2 at index 0 and putting it at index 1 which gave 029917 which is the number 29917.

smallest(1000000) --> [1, 0, 6] or ... */


/* Store the digits in an array using mod10. sort array. compare sorted 'lowest number array' to actual number.
Find the first number that is not 'optimal' position. If moving that number right will shift the following digit to 'optimal' 
position, then move that digit right until you hit a number higher than that digit. Otherwise, find the lowest value digit in the array
not in optimal position, and move it to the lowest position where it is 'optimal'. Return this first optimizing step, location of the 
moved digit and destination. */

using System;
using System.Collections.Generic;

public class ToSmallest
{

    public static long[] Smallest (long n)  //main, process number, print output
    {
        long[] numQ = stackUpInts(n).ToArray();
        long[] sortednumQ = new long[numQ.Length];
        numQ.CopyTo(sortednumQ, 0);
        Array.Sort(sortednumQ);
        return formatOutput(numQ, sortednumQ);
    }
    
     private static long[] formatOutput(long[] intQ, long[] adds)  // format output should take the number, the location of the lowest out of order digit
     {
        long[] output = new long[3];
        long low = adds[0];
        long lowadd = 0;
        long place = 0;
        long numout = 0;
        long dest = 0;
        for (int j = 0; j<intQ.Length; j++)
        {
          if (Array.IndexOf(intQ, adds[j]) != j)
            {
                dest = j;
                low = adds[j];
                lowadd = Array.LastIndexOf(intQ, adds[j]);
                break;
            }
            numout +=intQ[j];
            numout *= 10;
            place++;
        }
        
        for (int i = (int) place; i<intQ.Length; i++)
        {            
            if ((i != lowadd))
            {
              numout *= 10;
              numout += intQ[i];
            }
        }
        if ( (lowadd - dest == 1 || intQ[lowadd] == intQ[lowadd-1]))
            {
              if (dest != 0)
              {
              if (intQ[dest] == intQ[dest+1])
                dest--;
              }
            adds[lowadd]--;
            output[0] = numout + (long) Math.Pow(10,(intQ.Length-(dest+1))) * low;
            output[1] = adds[lowadd];
            output[2] = dest+1;
            return output;
            }           
          
        output[0] = numout + (long) Math.Pow(10,((intQ.Length-dest-1))) * low;
        output[1] = (long)lowadd;
        output[2] = (long)dest;
        return output;
     }
     
    private static Stack<long> stackUpInts(long num)  //helper to make a Stack of ints
      {
        Stack<long> intQ = new Stack<long>();
        while((long)num > 0)
        {
           intQ.Push((long)num % 10);
           num = (long) num / 10;
        }
       return intQ;
      }
}


/* Test Cases */

using System;
using NUnit.Framework;

[TestFixture]
public static class ToSmallestTests 
{

    private static void testing(long n, string res) 
    {
        Assert.AreEqual(res, Array2String(ToSmallest.Smallest(n)));
    }
    private static string Array2String( long[] list )
    {
        return "[" + string.Join(", ", list) + "]";
    }
[Test]
    public static void test1() 
    {        
        Console.WriteLine("Basic Tests smallest");
        testing(18786302809, "[18786300289, 10, 0]");
        testing(209917, "[29917, 0, 1]");
        testing(285365, "[238565, 3, 1]");
        testing(269045, "[26945, 3, 0]");
        testing(296837, "[239687, 4, 1]");
    }
}
