/*Introduction
 	Snakes and Ladders is an ancient Indian board game regarded today as a worldwide classic. It is played between two or more players on a gameboard having numbered, gridded squares. A number of "ladders" and "snakes" are pictured on the board, each connecting two specific board squares. (Source Wikipedia)
 

Task
 	Your task is to make a simple class called SnakesLadders. The test cases will call the method play(die1, die2) independantly of the state of the game or the player turn. The variables die1 and die2 are the die thrown in a turn and are both integers between 1 and 6. The player will move the sum of die1 and die2.
The Board


Rules
 	1.  There are two players and both start off the board on square 0.

2.  Player 1 starts and alternates with player 2.

3.  You follow the numbers up the board in order 1=>100

4.  If the value of both die are the same then that player will have another go.

5.  Climb up ladders. The ladders on the game board allow you to move upwards and get ahead faster. If you land exactly on a square that shows an image of the bottom of a ladder, then you may move the player all the way up to the square at the top of the ladder. (even if you roll a double).

6.  Slide down snakes. Snakes move you back on the board because you have to slide down them. If you land exactly at the top of a snake, slide move the player all the way to the square at the bottom of the snake or chute. (even if you roll a double).

7.  Land exactly on the last square to win. The first person to reach the highest square on the board wins. But there's a twist! If you roll too high, your player "bounces" off the last square and moves back. You can only win by rolling the exact number needed to land on the last square. For example, if you are on square 98 and roll a five, move your game piece to 100 (two moves), then "bounce" back to 99, 98, 97 (three, four then five moves.)
Returns
 	Return Player n Wins!. Where n is winning player that has landed on square 100 without any remainding moves left.

Return Game over! if a player has won and another player tries to play.

Otherwise return Player n is on square x. Where n is the current player and x is the sqaure they are currently on. */

using System;
using System.Collections.Generic;

namespace CodeWars
{
    class SnakesLadders
    {
      private int gameOver;
      private int currentPlayer;
      private int[] positions;
      private Dictionary<int, int> snakesLadders;

        public SnakesLadders ()
        {
            positions = new int[2];  //position for player1 in address 0, player 2 address 1
            gameOver = 0;
            currentPlayer=0;      //player 1 is 0, player 2 is 1
            snakesLadders = new Dictionary<int, int> {
                                              {2, 38},
                                              {7, 14},
                                              {8, 31},
                                              {15, 26},
                                              {16, 6},
                                              {21, 42},
                                              {28, 84},
                                              {36, 44},
                                              {46, 25},
                                              {49, 11},
                                              {51, 67},
                                              {62, 19},
                                              {64, 60},
                                              {71, 91},
                                              {74, 53},
                                              {78, 98},
                                              {87, 94},
                                              {89, 68},
                                              {92, 88},
                                              {95, 75},
                                              {99, 80}
                                              };
      }  
      
        
        
        public string play (int die1, int die2)
        {
          if (gameOver == 1)
            return "Game over!";
          int place = positions[currentPlayer];
            
          place += die1 + die2;
          
          if (place > 100)
            place = 200 - place; 
          
          if (snakesLadders.ContainsKey(place))
            place = snakesLadders[place];
          
          if (place == 100)  
          {
            gameOver ++;
            return "Player " + (currentPlayer + 1) + " Wins!";
          }
          
          string message = "Player " + (currentPlayer + 1) + " is on square " + (place);
          
          positions[currentPlayer] = place;
          
          if (die1 != die2)
            nextPlayer();
          
          return message;
        }
        
        private void nextPlayer ()
          {
          if (currentPlayer ==0)
            currentPlayer++;
          else currentPlayer--;
          }
    }
}


/* Test Cases */

namespace CodeWars
{
    [TestFixture]
    class KataTestClass
    {
        private SnakesLadders test = new SnakesLadders();

        [TestCase]
        public void BasicTest1()
        {
            string result = test.play(1, 1);
            Assert.AreEqual("Player 1 is on square 38",result, "Should return: 'Player 1 is on square 38'");
        }

        [TestCase]
        public void BasicTest2()
        {
            string result = test.play(1, 5);
            Assert.AreEqual("Player 1 is on square 44",result, "Should return: 'Player 1 is on square 44'");
        }

        [TestCase]
        public void BasicTest3()
        {
            string result = test.play(6, 2);
            Assert.AreEqual("Player 2 is on square 31",result, "Should return: 'Player 2 is on square 31'");
        }

        [TestCase]
        public void BasicTest4()
        {
            string result = test.play(1, 1);
            Assert.AreEqual("Player 1 is on square 25", result, "Should return: 'Player 1 is on square 25'");
        }
    }
}