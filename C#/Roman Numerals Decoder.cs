//https://www.codewars.com/kata/51b6249c4612257ac0000005

using System;
using System.Collections.Generic;

public class RomanDecode
{
	public static int Solution(string roman)
	{
	 int total = 0;
   int comparer = 1;
   SortedList<int, char> decring = new SortedList<int, char>()
                                      {
                                          {1, 'I'},
                                          {5, 'V'},
                                          {10, 'X'},
                                          {50, 'L'},
                                          {100, 'C'},
                                          {500, 'D'},
                                          {1000, 'M'}
                                      };
    
    for (int i=0; i<roman.Length;i++)
    {
       if (i > 0 && decring.IndexOfValue(roman[i]) > comparer)
          {
            total += decring.Keys[decring.IndexOfValue(roman[i])]-(2*decring.Keys[comparer]);
          }
          else
          {
            total += decring.Keys[decring.IndexOfValue(roman[i])];
          }
       comparer = decring.IndexOfValue(roman[i]);
    }
    return total;
	}
}

//Test Cases
public class RomanDecode
{
	public static int Solution(string roman)
	{
	 int total = 0;
   int comparer = 1;
   SortedList<int, char> decring = new SortedList<int, char>()
                                      {
                                          {1, 'I'},
                                          {5, 'V'},
                                          {10, 'X'},
                                          {50, 'L'},
                                          {100, 'C'},
                                          {500, 'D'},
                                          {1000, 'M'}
                                      };
    
    for (int i=0; i<roman.Length;i++)
    {
       if (i > 0 && decring.IndexOfValue(roman[i]) > comparer)
          {
            total += decring.Keys[decring.IndexOfValue(roman[i])]-(2*decring.Keys[comparer]);
          }
          else
          {
            total += decring.Keys[decring.IndexOfValue(roman[i])];
          }
       comparer = decring.IndexOfValue(roman[i]);
    }
    return total;
	}
}