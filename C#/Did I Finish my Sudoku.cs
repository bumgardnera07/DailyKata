//https://www.codewars.com/kata/53db96041f1a7d32dc0004d2

//I implemented multiple solutions with this coding exercise.
//HashSet, String Comparison, and BitMask. The Bitmask solution includes some data validation for input and was created with a fellow programmer -> Github/ MaxxWizard
//While none of these algs use linq, I think a Linq Solution would produce similar performance since Sudoku always has 81 values to access

using System;
using System.Collections.Generic;


//String Comparison Solution
public class Sudoku
{
  public static string DoneOrNot(int[][] board)
  {
    string fullSet = "123456789";
    int[] col = new int[9];
    int[] box = new int[9];
    int[] row = new int[9];
   for(int i =0; i<9; i++)
   {
     for (int k=0; k<9; k++)
     {
       row[k] = board[i][k];
       col[k]= board[k][i];
       box[k]= board[(k/3)+3*(i/3)][(k%3)+3*(i%3)];
     }
     
     Array.Sort(col);
     string checkcol = string.Join("", col);     
     Array.Sort(box);
     string checkbox = string.Join("", box);
     Array.Sort(row);
     string checkrow = string.Join("", row);
     if (checkrow != fullSet || checkcol != fullSet || checkbox != fullSet)
     return "Try again!";
   }
   return "Finished!";
  }
}

//HashSet Solution
public class Sudoku
{
  public static string DoneOrNot(int[][] board)
  {
    HashSet<int> col = new HashSet<int>();
    HashSet<int> row = new HashSet<int>();
    HashSet<int> box = new HashSet<int>();
   for(int i =0; i<9; i++)
   {
     for (int k=0; k<9; k++)
     {
       if( !(row.Add(board[i][k])) || !(col.Add(board[k][i])) || !(box.Add(board[(k/3)+3*(i/3)][(k%3)+3*(i%3)])))
         return "Try again!";
       else
       {
       row.Add(board[i][k]);
       col.Add(board[k][i]);
       box.Add(board[(k/3)+3*(i/3)][(k%3)+3*(i%3)]);
       }
     }
     row.Clear();
     col.Clear();
     box.Clear();
   }
   return "Finished!";
  }
}

//BitMask Solution

namespace SudokuChecker
{
    class Program
    {
        public static string DoneOrNot(int[,] board)
        {
            if (!(board.Rank == 2 && board.GetLength(0) == 9 && board.GetLength(1) == 9))
            {
                throw new ArgumentException("board must be 9x9");
            }
            else
            {
                // to be done, 3 conditions must be satisfied:
                // - every column
                // - every row
                // - every subsquare

                // represent each condition as a fully-enabled bit mask
                var columnCheck = new ushort[9];
                var rowCheck = new ushort[9];
                var subsquareCheck = new ushort[9];
                for (int i = 0; i < 9; i++)
                {
                    columnCheck[i] = 0b0000_0001_1111_1111;
                    rowCheck[i] = 0b0000_0001_1111_1111;
                    subsquareCheck[i] = 0b0000_0001_1111_1111;
                }

                // walk through the 2-dimensional array once
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        // flip the "bit" by XOR'ing the value with the bitmask
                        ushort flipWithMe = 0;
                        switch (board[i, j])
                        {
                            case 1:
                                flipWithMe = 0b0000_0000_0000_0001;
                                break;
                            case 2:
                                flipWithMe = 0b0000_0000_0000_0010;
                                break;
                            case 3:
                                flipWithMe = 0b0000_0000_0000_0100;
                                break;
                            case 4:
                                flipWithMe = 0b0000_0000_0000_1000;
                                break;
                            case 5:
                                flipWithMe = 0b0000_0000_0001_0000;
                                break;
                            case 6:
                                flipWithMe = 0b0000_0000_0010_0000;
                                break;
                            case 7:
                                flipWithMe = 0b0000_0000_0100_0000;
                                break;
                            case 8:
                                flipWithMe = 0b0000_0000_1000_0000;
                                break;
                            case 9:
                                flipWithMe = 0b0000_0001_0000_0000;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("values on the board must be 1 to 9");
                        }

                        columnCheck[j] = (ushort)(columnCheck[j] ^ flipWithMe);
                        rowCheck[i] = (ushort)(rowCheck[i] ^ flipWithMe);
                        subsquareCheck[(j%2)+3*(i/3)] = (ushort)(subsquareCheck[(j%2)+3*(i/3)] ^ flipWithMe);
                    }
                }

                // now check that the bit masks are correct (equal to zero)
                // TODO: add subsquareCheck
                for (int i = 0; i < 9; i++)
                {
                    if (columnCheck[i] != 0 || rowCheck[i] != 0 || subsquareCheck[i] != 0)
                        return "Try Again!";
                }

                return "Finished!";
            }
        }
    }
}

//Test Cases

namespace Solution 
{
  using NUnit.Framework;
  using System;
  using System.Collections.Generic;

  [TestFixture]
  public class Sample_Tests
  {
    private static object[] testCases = new object[]
    {
      new object[]
      {
        "Finished!",
        new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2}, 
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
          new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
        },
      },
      new object[]
      {
        "Try again!",
        new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2}, 
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
          new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
        },
      },
    };
  
    [Test, TestCaseSource("testCases")]
    public void Test(string expected, int[][] board) => Assert.AreEqual(expected, Sudoku.DoneOrNot(board));
  }
}