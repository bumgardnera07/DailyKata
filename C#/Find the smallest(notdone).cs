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
moved digit and destination. 
I'm trying to write a solution/ alg for this problem that doesn't involve computer and comparing every permutation of the digits. This has proven to be a real monster.
What I have now works for a large percentage of the cases, but there are some not so difficult to find edge cases that break it.
*/


/* I'd like to remove a lot of the conditionals from this alg to make it more generalized/ reduce all the random comparisons and variable checks
This still doesn't always return the right solution when there are sequences of optimal characters at the beginning of the number. The issues
are with the 'MoveRight' function. I need to rewrite the logic for how it decides to move the number right or left. 

Also need to go back and comment through solution for context*/
using System;
using System.Collections.Generic;

public class ToSmallest
{
    public static long[] Smallest (long n)  //main, process number, print output
    {
        
    try 
    {

        long[] output = new long[3];
        long[] numQ = stackUpInts(n);
        long[] sortednumQ = new long[numQ.Length];       
        
        sortednumQ = (long[]) numQ.Clone();
        Array.Sort(sortednumQ);

       if (perfect(numQ, sortednumQ)) 
       {
       output[0] = n;
       output[1] = 0;
       output[2] = 0;
       return output;
       } 

        int dest = findDest(numQ, sortednumQ);        
        int addr = findAddr(numQ, sortednumQ, dest);
            
       
       if (dest > 0)
       {
          while (numQ[addr] == numQ[dest-1])
            {
              dest--;
              if (dest == 0)
                break;
            }
       }
       
      if (addr > 0)
       {
          while (numQ[addr] == numQ[addr-1])
            {
              addr--;
              if (addr == 0)
                break;
            }
       }
        
        if(moveRight(numQ, sortednumQ, dest)){
          output[0] = formatNum(numQ, dest, addr);
          output[1] = dest;
          output[2] = addr;}
        else {
          output[0] = formatNum(numQ, addr, dest);
          output[1] = addr;
          output[2] = dest;
          }
        if (addr-dest == 1)
          {
          output[1] = dest;
          output[2] = addr;
          }
        if (addr == dest)
          output[0] = n;
        return output;
        }
        
        catch (IndexOutOfRangeException)
      {
        long[] output = new long[3];
        output[0] = n;
        output[1] = 1;
        output[2] = 2;
        return output;
      }
    }
    
     private static int findDest(long[] intQ, long[] sortednumQ)
     {
        for (int i = 0; i < intQ.Length-1; i++)
        {
          if (!(intQ[i] == sortednumQ[i]))
            {
              return i;
            }
        }
        return 0;
     }
     
     private static int findAddr(long[] intQ, long[] sortednumQ, int dest)
     {
        if (moveRight(intQ, sortednumQ, dest))
          {
            for (int i = dest; i< intQ.Length-1; i++)
              {
                
                if (intQ[dest] < intQ[i+1])
               {
               while (intQ[dest] == intQ[i] && intQ[dest] > intQ[i-1])
                 {
                 i--;
                 if (i == 0)
                   return i;
                 }
               return i;
               }
              }
            return intQ.Length-1;
          }
        else
        {
          for (int i = intQ.Length-1; i > dest; i--)
          {
             if (intQ[i] == sortednumQ[dest])
               {
               while (intQ[i] == intQ[i-1])
                 {
                 i--;
                 if (i == 0)
                   return i;
                 }
               return i;
               }
          }
          return 0;
        }
     }
     
     private static bool perfect(long[] intQ, long[] sortednumQ)  
     { 
       for (int i = 0; i < intQ.Length; i++)
       {
         if (intQ[i] != sortednumQ[i])
           return false;
       }
       return true;
     }
       
       
     private static long formatNum(long[] intQ, long addr, long dest)  // format output should take the number, the location of the lowest out of order digit
     {
        long smallest = 0;
        for (int j = 0; j<intQ.Length; j++)
        {
          if (j == dest && addr > dest) 
          {
            smallest += intQ[addr];
            smallest *= 10;
          }          
          
          if (j == addr && j < intQ.Length-1)
          {
            j++;
          }
    
          smallest += intQ[j];
          if (!(j ==addr && j == intQ.Length-1))
            smallest *= 10;
          
          if (j == dest && addr < dest) 
          {
            smallest += intQ[addr];
            smallest *= 10;
          }          
        }
        return smallest/10;
      }
     
     private static bool moveRight(long[] intQ, long[] sortednumQ, long dest)
     {
        long firstdiff = sortednumQ[dest];
        if (intQ[dest+1] == firstdiff) {
          for (long i = (int)dest+1; i < intQ.Length; i++)
          {
            if (intQ[i] != firstdiff)
              {
              firstdiff = i;
              break;
              }
          }
        if (firstdiff- dest > 2)
          return true;
        for (int k = 0; k < firstdiff; k++)
        {
          if (intQ[firstdiff+k] < intQ[dest+k])
             return true;
          else if (intQ[firstdiff+k] != intQ[dest+k])
            return false;
        }
       }
      return false;
     }

     private static long[] stackUpInts(long num)  //helper to make a Stack of ints
      {
        int digitCount = (int)Math.Floor(Math.Log10((long)num) + 1);
        long[] intQ = new long[digitCount];
        for (int i= 0; i < digitCount; i++)
        {
           intQ[i] =(long)num % 10;
           num = (long) num / 10;
        }
        Array.Reverse(intQ);
       return intQ;
      }
    }


/*First Approach, Abandoning
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
*/

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
        public static void test2() 
    {        
        Console.WriteLine("Basic Tests smallest");
        testing(60349654900076672, "[3469654900076672, 0, 3]");
        testing(151212563342982848, "[112125563342982848, 1, 5]");
        testing(0203340367508748192, "[20334036758748192, 10, 0]");
        testing(909968704408951840, "[90996870440895184, 17, 0]");
        testing(400042120553575136, "[421204553575136, 0, 8]");
    }
}
