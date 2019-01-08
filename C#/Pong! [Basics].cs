//https://www.codewars.com/kata/5b432bdf82417e3f39000195

using System;
namespace CodeWars
{
    class Pong
    {
      private int maxScore;
      private int currentPlayer = 0;
      private int otherPlayer = 0;
      private int scoreOne = 0;
      private int scoreTwo = 0;
        
      public Pong(int maxScore) {
        this.maxScore = maxScore;
      }
      
      public void switchPlayers() {
           if (currentPlayer == 1) 
              {
                currentPlayer = 2;
                otherPlayer = 1;
              }
              else
              {
                 currentPlayer = 1;
                 otherPlayer = 2;
              }
      }
      public string play(int ballPos, int playerPos) {
        bool hit = (Math.Abs(ballPos - playerPos) < 4);
        bool gameover = ((scoreOne == maxScore) || (scoreTwo == maxScore));
        if (gameover) {
          return "Game Over!";
        }
        switchPlayers();
        if (hit)
            {
              return $"Player {currentPlayer.ToString()} has hit the ball!";
            }
          else
            {    
                    if (currentPlayer == 1)
          {
            scoreTwo++;
            if (scoreTwo == maxScore) {
             return "Player 2 has won the game!";
            }
          }
        else
          {
            scoreOne++;
            if (scoreOne == maxScore) {
             return "Player 1 has won the game!";
            }
          }
            return $"Player {currentPlayer.ToString()} has missed the ball!";
            }
          }
        }
      }

//Test Cases


namespace CodeWars
{
    [TestFixture]
    class KataTestClass
    {
        private Pong game = new Pong(2);

        [TestCase]
        public void SampleTest()
        {
            Assert.AreEqual("Player 1 has hit the ball!", game.play(50, 53));
            Assert.AreEqual("Player 2 has hit the ball!", game.play(100, 97));
            Assert.AreEqual("Player 1 has missed the ball!", game.play(0, 4));
            Assert.AreEqual("Player 2 has hit the ball!", game.play(25, 25));
            Assert.AreEqual("Player 2 has won the game!", game.play(75, 25));
            Assert.AreEqual("Game Over!", game.play(50, 50));
        }
    }
}